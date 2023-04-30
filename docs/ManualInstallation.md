---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---
<!-- ManualInstallation.md v2.2.99.1
ScrapYard (SYD)
created: 01 Mar 2020
updated: 11 Apr 2023

TEMPLATE: ManualInstallation.md v1.1.9.0
created: 01 Feb 2022
updated: 27 Mar 2023

based upon work by Lisias -->

# [ScrapYard (SYD)][SYD]

[Home](./index.md)

A common part inventory addon for Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `ScrapYard` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/ScrapYard`
* Extract the package's `ScrapYard/` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/ScrapYard` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/ScrapYard`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/ScrapYard`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/ScrapYard`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [ScrapYard][SYD]
      + [Agencies]
        ...
      + [Compatibility]
        ...
      + [Config]
        ...
      + [Flags]
        ...
      + [Localization]
        ...
      + [Plugins]
        ...
        ManualInstallation.htm
      * #.#.#.#.htm
      * Attributions.htm
      * changelog.md
      * GPL-2.0.txt
      * readme.htm
      * ScrapYard.version
    ...
    * [ModularManagement (MM)][MM] or [Module Manager][m-m]
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* *either*
  * [ModularManagement][MM]
  * [Module Manager][m-m]

[SYD]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-* "ScrapYard (SYD)"
[MM]: https://github.com/net-lisias-ksp/ModularManagement "ModularManagement (MM)"
[m-m]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"

THIS FILE: CC BY-ND 4.0 by zer0Kerbal