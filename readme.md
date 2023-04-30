<!-- readme.md v2.2.99.1
created: 05 May 2017
updated: 11 Apr 2023

TEMPLATE: readme.md v1.7.1.0
created: 17 Jul 2017
updated: 15 Mar 2023

THIS FILE: CC BY-ND 4.0 by zer0Kerbal -->

[![ScrapYard][SHD:mod]][CURSFG:url] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![Pages][SHD:pgs]][pages]

![Code][SHD:cde] ![ScrapYard][SHD:dll] ![ScrapYard_CC][SHD:cc]

# ScrapYard (SYD)

A common part inventory addon for Kerbal Space Program.


## By [zer0Kerbal][zer0Kerbal], originally by [magico13][magico13], then by [severedsolo][severedsolo]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/img/HeroLogo_1920x1920.png" alt="ScrapYard Hero" width="50%" height="50%">

### Preamble by [severedsolo][severedsolo]
>
> So you may have heard that @magico13 is giving up modding KSP. I've got the honour of taking over support for ScrapYard, because it makes sense as I have my own mod that depends on it (Oh Scrap!). I want to take this opportunity to thank magico13 for all his hard work and contributions to the community over the years, as I know that my own KSP experience would be much poorer without his mods. Anyway, enough from me.

### The bit you are actually interested in

ScrapYard is a mod that provides a part inventory that can be shared between multiple mods. Parts are added to the inventory when you recover a vessel and are removed from the inventory when you build a new vessel. If you have ever played with Kerbal Construction Time, it's a significantly improved version of the part inventory that KCT had, that is also able to be used by other mods.

### As of writing, ScrapYard does the following

* Parts are added to the inventory automatically upon vessel recovery
* Parts are applied in the editor (not automatically like with KCT)
* Parts are then pulled from the inventory on build (mods can change when this happens)
* Parts are stored individually in the inventory along with any modules that “define” the part (think TweakScale and Procedural Parts)
* The number of times “like” parts are used is tracked and available for mods, both total uses and number of builds (KCT’s part tracker feature, expanded)
* Parts are trackable from the moment they are placed in the editor until they are removed from the game via a unique ID that transcends recovery and new builds
* The number of times an individual part is recovered is tracked, perfect for consumption by part failure mods
* (WIP) Funds can be overridden so that using parts from the inventory do not contribute to the cost of the vessel. You do still need to have the full amount of funds (for now).
* ContractConfigurator support for adding or removing parts from the inventory as part of contracts

### See More

>* [ChangeLog][chlog] for more details of changes
>* [Discussions][discu] or [Forums][forum] for discussions and news
>* [GitHub Pages][pages]
>* [How it Works][works]
>* [Known Issues][issue] for more details of feature requests and known issues
>* [Marketing Slicks][markt]

### Help Wanted

> * Compatibility patches
> * Code improvements through [Github PR][GITHUB:url]
> * Marketing Images and Videos such as hero shots, animated gifs, short highlights
> * Translations: See the [README in the Localization folder][lreadme] for instructions for adding or improving translations. There is also the [quickstart guide][qstart]. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*
> * Have a request? Glad to have them, kindly submit through [GitHub][issue].

### Localization

>* ![English][EN] English
>* ![Português Brasil][BR] Brazilian Portuguese (Português Brasil) - courtesty of [Lisias](https://github.com/Lisias)
>* ![中文][CN] Simplified Chinese (中文) - courtesty of [tinygrox](https://github.com/tinygrox)
>* ***your translation here***

### Installation Directions

Most recent releases only available via CurseForge/OverWolf Website/App

<a href="https://download.curseforge.com/"><img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" height="100px"></a>

### Dependencies

* Either
  * [ModularManagement (MM)][MM]
  * [Module Manager][m-m]
* [Contract Configurator][cc] (only on KSP 1.8.1+)
* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url]

### Recommends

* [KSP Recall (REC)][rec] *handles issues with Procedural Parts/Fairings/Etc* caused by [Procedural Parts (pp)][pp]
* [OhScrap! (OHS)][OHS]

### Suggests

* [Adjustable Mod Panel (KAMP)][KAMP]
* [Field Training Facility (FTF)][FTF]
* [Field Training Lab (FTL)][FTL]
* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]
* [Kaboom! (BOOM)][BOOM]
* [Kerbal Construction Time (KCT)][kct]
* [On Demand Fuel Cells (ODFC)][ODFC]
* [OScience Laboratories (OSL)][OSL]
* [Papa Kerballini's Pizza (PIZZA)][PIZZA]
* [Precise Maneuver (PM)][PM]
* [SimpleConstruction! (SCON)][SCON]
* [SimpleLogistics! (SLOG)][SLOG]
* [SimpleNotes! (NOTE)][NOTES]
* [Solar Science (SOL)][SOL]
* [StageRecovery (SR)][sr]

### Supports

* [Goo Pumps & Oils' (GPO)) Speed Pump (GPOSP)][GPO]
* [On Demand Fuel Cells (ODFC)][ODFC]
* [FAR][far]
* [KRASH][krash]
* [RemoteTech (RT)][rt]
* [TweakScale (TWK)][twk]

#### Mods using ScrapYard (SYD)

* [Kerbal Construction Time][kct]
* [Oh Scrap! (OHS)][OHS]

### Tags

plugin, editor, flags, agency, sound, career

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

* [`magico13`][magico13] for creating this glorious parts addon!
* [`severedsolo`][severedsolo] for the picking up where [`magico13`][magico13] left off
* [`SiriusSam`][siriussame] for the original idea of creating a separate part inventory way back in 2014 and for the name
* [`enneract`][enneract] for discussion and design help.
* see [Attribution][attrb] for more

### Legal Mumbo Jumbo (License *provenance*)

#### Current (3) - [zer0Kerbal][zer0Kerbal]

> Forum: [Thread][forum] - Source: [GitHub][GITHUB:url]
> License: [![License][LIC:shd]][LIC:url]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All assets, including but not limited to: animations, models, sounds and textures are distributed under their own licenses***

##### see [Notices][notic] for more *legal Mumbo Jumbo*

#### Author (2) - Author: [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:2:thread] - Download: [CurseForge][MOD:2:dnload] - Source: [GitHub][MOD:2:source]
> License: [![License][LIC:2:shd]][LIC:2:url]

#### Author (1) - Author: [`severedsolo`][severedsolo]

> Forum: [Thread][MOD:1:thread] - Download: [SpaceDock][MOD:1:dnload] - Source: [GitHub][MOD:1:source]
> License: [![License][LIC:1:shd]][LIC:1:url]

#### Original (0) - Author: [`magico13`][magico13]

> Forum: [Thread][MOD:0:thread] - Download: [SpaceDock][MOD:0:dnload] - Source: [GitHub][MOD:0:source]
> License: [![License][LIC:0:shd]][LIC:0:url]

### How to support this and other great mods by [`zer0Kerbal`][zer0Kerbal]

Comment, click, like, share, up-vote, subscribe

> ***Completely voluntary, absolutely amazing, and really does help me out a lot!***  
> *and it is true.*

[![Support][PAYPAL:img]][PAYPAL:url] [![Patreon][PATREON:img]][PATREON:url]

<!-- links -->
[attrb]: https://zer0kerbal.github.io/ScrapYard/Attributions "Attribution"
[chlog]: https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/changelog.md "Changelog"
[discu]: https://github.com/zer0Kerbal/ScrapYard/discussions "Discussions"
[forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-*/ "ScrapYard (SYD)Forum Thread"
[issue]: https://github.com/zer0Kerbal/ScrapYard/issues "Issues"
[markt]: https://zer0kerbal.github.io/ScrapYard/Marketing "Marketing Slicks"
[notic]: https://zer0kerbal.github.io/ScrapYard/Notices "Notices"
[pages]: https://zer0kerbal.github.io/ScrapYard "GitHub Pages"
[works]: https://zer0kerbal.github.io/ScrapYard/HowItWorks "How It Works"

<!--- shields -->
[SHD:cde]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/code.json
[SHD:mod]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/mod.json
[SHD:pgs]: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

[SHD:dll]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/dll.json
[SHD:cc]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/sycc.json

<!--- mod provenance -->
[MOD:2:dnload]: https://www.curseforge.com/kerbal/ksp-mods/scrapyard "CurseForge"
[MOD:2:source]: https://github.com/zer0Kerbal/ScrapYard "GitHub"
[MOD:2:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-*/ "KSP Forum"

[MOD:1:dnload]: http://spacedock.info/mod/1746 "SpaceDock"
[MOD:1:source]: https://github.com/severedsolo/ScrapYard "GitHub"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/178641-*/ "KSP Forum"

[MOD:0:dnload]: http://spacedock.info/mod/1746 "SpaceDock"
[MOD:0:source]: https://github.com/magico13/ScrapYard "GitHub"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/160257-*/ "KSP Forum"

<!--- license provenance -->
[LIC:2:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:2:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:1:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:1:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:0:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:0:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:url]: https://www.gnu.org/licenses/gpl-2.0-standalone.html "GPL-2.0"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/license.json

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/ScrapYard "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/ScrapYard/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=071776&style=plastic&logo=github "GitHub"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/ksp.json "Kerbal Space Program"

<!-- links to add-ons/mods -->
[BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938-*/ "Kaboom! (BOOM)"
[FTF]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-*/ "Field Training Facility (FTF)"
[FTL]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-*/ "Field Training Lab (FTL)"
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[KAMP]: https://forum.kerbalspaceprogram.com/index.php?/topic/207263-*/ "Adjustable Mode Panel (KAMP)"
[NOTES]: https://forum.kerbalspaceprogram.com/index.php?/topic/207118-*/ "SimpleNotes! (NOTES) (NOTES)"
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells (ODFC)"
[OHS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-*/ "OhScrap (OHS)"
[OSL]: https://forum.kerbalspaceprogram.com/index.php?/topic/209490-*/ "OScience Laboratories (OSL)"
[PIZZA]: https://forum.kerbalspaceprogram.com/index.php?/topic/209577-*/ "Papa Kerballini's Pizza (PIZZA)"
[PM]: https://forum.kerbalspaceprogram.com/index.php?/topic/207261-*/ "Precise Maneuver (PM)"
[SCON]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-*/ "SimpleConstruction! (SCON)"
[SLOG]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-*/ "SimpleLogistics! (SLOG)"
[SOL]: https://forum.kerbalspaceprogram.com/index.php?/topic/192489-*/ "Solar Science (SOL)"

[cc]: https://forum.kerbalspaceprogram.com/index.php?/topic/91625-*/ "Contract Configurator"
[far]: https://forum.kerbalspaceprogram.com/index.php?/topic/179445-*/ "FAR"
[kct]: https://forum.kerbalspaceprogram.com/index.php?/topic/182877-*/ "Kerbal Construction Time"
[krash]: http://forum.kerbalspaceprogram.com/index.php?/topic/133082-*/ "KRASH"
[MM]: https://github.com/net-lisias-ksp/ModularManagement "ModularManagement (MM)"
[m-m]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[pp]: https://forum.kerbalspaceprogram.com/index.php?/topic/204080-*/ "Procedural Parts (pp)"
[rec]: https://www.curseforge.com/kerbal/ksp-mods/ksp-recall "KSP Recall"
[rt]:  http://remotetechnologiesgroup.github.io/RemoteTech/ "RemoteTech"
[sr]: https://forum.kerbalspaceprogram.com/index.php?/topic/179306-*/ "Stage Recovery"
[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00/ "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate/?hosted_button_id=DC22YHMEJREKL "PayPal"
[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon/ "Patreon"
[PATREON:url]: https://www.patreon.com/zer0Kerbal/membership "Patreon"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/img/BR.png "Português Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/CH.png "中文"

[curseforge]: https://www.curseforge.com/members/zer0kerbal/projects
[reddit]: https://www.reddit.com/user/zer0Kerbal
[twitch]: https://www.twitch.tv/zer0kerbal
[twitter]: https://twitter.com/zer0Kerbal
[youtube]: https://www.youtube.com/@zer0Kerbal
[steam]: https://steamcommunity.com/id/zeroKerbal
[projects]: https://zer0kerbal.github.io/zer0Kerbal/projects.html

[enneract]: https://forum.kerbalspaceprogram.com/index.php?/profile/56759-*/ "enneract"
[magico13]: https://forum.kerbalspaceprogram.com/index.php?/profile/73338-*/ "magico13"
[severedsolo]: https://forum.kerbalspaceprogram.com/index.php?/profile/80345-*/ "severedsolo"
[siriussame]: https://forum.kerbalspaceprogram.com/index.php?/profile/116426-*/ "siriussam"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

#### Connect with me

Track progress: issues [here][issue] and projects [here](https://github.com/zer0Kerbal/ScrapYard/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | steam" width="32px" src="https://icons.iconarchive.com/icons/3xhumed/mega-games-pack-05/48/Steam-icon.png" />][steam] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/twitter-32.ico" />][twitter] [<img align="left" alt="zer0Kerbal | project list" width="32px" src="https://www.pngall.com/wp-content/uploads/5/Vector-Checklist-PNG-HD-Image-180x180.png" />][projects]</br> 
