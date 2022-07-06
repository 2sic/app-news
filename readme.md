<image src="app-icon.png" align="right" width="200px">

# News 5 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A standard news / announcements app to use with 2sxc

| Aspect              | Status | Comments or Version |
| ------------------- | :----: | ------------------- |
| 2sxc                | ✅    | requires 2sxc v13.10
| Dnn                 | ✅    | For v7, v8 and v9
| Oqtane 2            | ✅    | Requires v2.02
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

* v12.05 2021-12
  * Updated to 2sxc 12.5 standards
  * Made hybrid / compatible with Oqtane
  * Removed jQuery
* v5.0.2 2022-03
  * Bugfix assets
* v5.0.3 2022-04
  * Minor toolbar prefill
* v5.1 2022-04 
  * Changed all access to Services to ToSic.Sxc.Services
  * Implemented IScrub service
  * Made the teaser optional
  * Changed the detail page URL generation for bs3
  * Enabled image configuration
  * Replaced data-enableoptimization with pageSvc.AssetAttributes()
  * Changed fancybox image to use the new IImageService to load images
* v5.2 2022-07
  * Replaced all base classes with their 2sxc 14 migration
  * Changed all GetService<> to the new ServiceKit14
  * Changed all toolbar configurations to use the IToolbarService
  * Updated webpack
* v5.2.1 2022-07
  * Removed unnecessary using 
  * Replaced a missed base class