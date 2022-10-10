// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    public class PSCmdletAction : IPSCmdletAction
    {
        private const string CsvHeaderCommandName = "CommandName";
        private const string CsvHeaderParameterSetName = "ParameterSetName";
        private const string CsvHeaderParameters = "Parameters";
        private const string CsvHeaderSourceScript = "SourceScript";
        private const string CsvHeaderScriptLineNumber = "LineNumber";
        private const string CsvHeaderDuration = "Duration";
        private const string CsvHeaderIsSuccess = "IsSuccess";
        private const string Delimiter = ",";

        private static readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        private readonly string StatsOutputRootFolder;

        private readonly bool IsWindowsPlatform;

        private readonly IList<string> ExcludedSource = new List<string>
        {
            "Common.ps1",
            "Assert.ps1",
            "AzureRM.Resources.ps1",
            "AzureRM.Storage.ps1"
        };

        public PSCmdletAction()
        {
            IsWindowsPlatform = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

            var repoRootFolder = ProbeRepoDirectory();
            if (!string.IsNullOrEmpty(repoRootFolder))
            {
                StatsOutputRootFolder = Path.Combine(repoRootFolder, "artifacts", "CmdletStatisticsAnalysis", "Raw");
                DirectoryInfo rawDir = new DirectoryInfo(StatsOutputRootFolder);
                if (!rawDir.Exists)
                {
                    Directory.CreateDirectory(StatsOutputRootFolder);
                }
            }
        }

        private string ProbeRepoDirectory()
        {
            string directoryPath = "..";
            while (Directory.Exists(directoryPath) && (!Directory.Exists(Path.Combine(directoryPath, "src")) || !Directory.Exists(Path.Combine(directoryPath, "artifacts"))))
            {
                directoryPath = Path.Combine(directoryPath, "..");
            }

            string result = Directory.Exists(directoryPath) ? Path.GetFullPath(directoryPath) : null;
            return result;
        }

        private string GenerateCsvHeader()
        {
            StringBuilder headerBuilder = new StringBuilder();
            headerBuilder.Append(CsvHeaderCommandName).Append(Delimiter)
                         .Append(CsvHeaderParameterSetName).Append(Delimiter)
                         .Append(CsvHeaderParameters).Append(Delimiter)
                         .Append(CsvHeaderSourceScript).Append(Delimiter)
                         .Append(CsvHeaderScriptLineNumber).Append(Delimiter)
                         .Append(CsvHeaderDuration).Append(Delimiter)
                         .Append(CsvHeaderIsSuccess);

            return headerBuilder.ToString();
        }

        private string GenerateCsvRecord(string commandName, string parameterSetName, string parameters, string sourceScript, int scriptLineNumber, TimeSpan duration, bool isSuccess)
        {
            StringBuilder recordBuilder = new StringBuilder();
            recordBuilder.Append(commandName).Append(Delimiter)
                         .Append(parameterSetName).Append(Delimiter)
                         .Append(parameters).Append(Delimiter)
                         .Append(sourceScript).Append(Delimiter)
                         .Append(scriptLineNumber).Append(Delimiter)
                         .Append(duration.ToString("h'h 'm'm 's's'")).Append(Delimiter)
                         .Append(isSuccess.ToString().ToLowerInvariant());

            return recordBuilder.ToString();
        }

        public void LogCmdletStats(string moduleName, string commandName, string parameterSetName, string parameters, string sourceScript, int scriptLineNumber, TimeSpan duration, bool isSuccess)
        {
#if DEBUG || CMDLETACTION_STATS
            if (!IsWindowsPlatform || string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(commandName) || ExcludedSource.Contains(sourceScript))
                return;

            var pattern = @"\\(?:artifacts\\Debug|src)\\(?:Az\.)?(?<ModuleName>[a-zA-Z]+)\\";
            var match = Regex.Match(sourceScript, pattern, RegexOptions.IgnoreCase);
            var testingModuleName = $"Az.{match.Groups["ModuleName"].Value}";
            if (string.Compare(testingModuleName, moduleName, true) != 0)
                return;

            var csvFilePath = Path.Combine(StatsOutputRootFolder, $"{moduleName}.csv");

            _lock.EnterWriteLock();
            try
            {
                StringBuilder csvData = new StringBuilder();
                if (!File.Exists(csvFilePath))
                {
                    var csvHeader = GenerateCsvHeader();
                    csvData.Append(csvHeader);
                }

                csvData.AppendLine();
                var csvRecord = GenerateCsvRecord(commandName, parameterSetName, parameters, Path.GetFileName(sourceScript), scriptLineNumber, duration, isSuccess);
                csvData.Append(csvRecord);

                File.AppendAllText(csvFilePath, csvData.ToString());
            }
            finally
            {
                _lock.ExitWriteLock();
            }
#endif
        }
    }
}
