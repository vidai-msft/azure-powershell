---
external help file: Az.Orbital-help.xml
Module Name: Az.Orbital
online version: https://learn.microsoft.com/powershell/module/Az.Orbital/new-azorbitalspacecraftlinkobject
schema: 2.0.0
---

# New-AzOrbitalSpacecraftLinkObject

## SYNOPSIS
Create an in-memory object for SpacecraftLink.

## SYNTAX

```
New-AzOrbitalSpacecraftLinkObject -BandwidthMHz <Single> -CenterFrequencyMHz <Single> -Direction <String>
 -Name <String> -Polarization <String> [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for SpacecraftLink.

## EXAMPLES

### Example 1: Create a SpacecraftLink object for OrbitalSpacecraft.
```powershell
New-AzOrbitalSpacecraftLinkObject -BandwidthMHz 50 -CenterFrequencyMHz 50 -Direction 'Uplink' -Name spacecraftlink -Polarization 'LHCP'
```

```output
BandwidthMHz CenterFrequencyMHz Direction Name           Polarization
------------ ------------------ --------- ----           ------------
50           50                 Uplink    spacecraftlink LHCP
```

Create a SpacecraftLink object for OrbitalSpacecraft.

## PARAMETERS

### -BandwidthMHz
Bandwidth in MHz.

```yaml
Type: System.Single
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CenterFrequencyMHz
Center Frequency in MHz.

```yaml
Type: System.Single
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Direction
Direction (Uplink or Downlink).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Link name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Polarization
Polarization.
e.g.
(RHCP, LHCP).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.SpacecraftLink

## NOTES

## RELATED LINKS
