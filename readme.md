<image src="app-icon.png" align="right" width="200px">

# News 5 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A standard news / announcements app to use with 2sxc

| Aspect              | Status | Comments or Version
| ------------------- | :----: | -------------------
| 2sxc                | ✅    | requires 2sxc v17.07.00
| Dnn                 | ✅    | For v9.6.1+
| Oqtane              | ✅    | Requires v5.00+
| No jQuery           | ✅    |
| Live Demo           | ➖    |
| Install Checklist   | ✅    | See [Installation](https://azing.org/2sxc/r/Ro8wsQG3) on [azing.org](https://azing.org/2sxc)
| Source & License    | ✅    | included, ISC/MIT
| App Catalog         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/news-app-v5-hybrid-for-dnn-and-oqtane)
| Screenshots         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/news-app-v5-hybrid-for-dnn-and-oqtane)
| Best Practices      | ✅    | Uses v13.10 conventions
| Bootstrap 3         | ✅    |
| Bootstrap 4         | ✅    |
| Bootstrap 5         | ✅    |

## Customize the App

The News App has an important app setting which you can configure with the ["Configure Main-List and Details Page" checklist](https://azing.org/2sxc/r/SGLKKOiE). But it also has a lot of app resources you can change if you want to.

If you want to customize the CSS, you will usually follow the ["Create Custom Styles in a Standard 2sxc App" checklist](https://azing.org/2sxc/r/gg_aB9FD)

## History

* v.12.05 2021-12
  * Updated to 2sxc 12.5 standards
  * Made hybrid / compatible with Oqtane
  * Removed jQuery
* v.05.00.02 2022-03
  * Bugfix assets
* v.05.00.03 2022-04
  * Minor toolbar prefill
* v.05.01.00 2022-04
  * Changed all access to Services to ToSic.Sxc.Services
  * Implemented IScrub service
  * Made the teaser optional
  * Changed the detail page URL generation for bs3
  * Enabled image configuration
  * Replaced data-enableoptimization with pageSvc.AssetAttributes()
  * Changed fancybox image to use the new IImageService to load images
* v.05.02.00 2022-07
  * Replaced all base classes with their 2sxc 14 migration
  * Changed all GetService<> to the new ServiceKit14
  * Changed all toolbar configurations to use the IToolbarService
  * Updated webpack
* v.05.02.01 2022-07
  * Removed unnecessary using
  * Replaced a missed base class
* v.05.03.00 2023-05
  * Removed _ from Filenames
  * Enhanced Kit.Image with `imgAltFallback`
  * Replaced turnOn Tag with `Kit.Page.TurnOn`
  * Code in one file the bs5, less duplicated code
* v05.04.00 2023-07
  * 2sxc 16.02 coding conventions
  * everything typed
* v05.17.00 2024-04
  * strong typed
  * Auto Generated Class
  * Typed MyItem
  * Merge List Columns and List Columns without Image into List Columns
* v05.17.01 2024-07
  * Update app.sln and app.csproj
