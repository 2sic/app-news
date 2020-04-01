<image src="app-icon.png" align="right" width="200px">

# News App v10 for DNN (DotNetNuke)

A standard news / announcements app to use with 2sxc

## Installing the app

You can install the app straight forward with [this checklist](https://azing.org/2sxc/r/Ro8wsQG3)

## Customizing the app

### Data

The News App has an important app setting which you can configure with [this checklist](https://azing.org/2sxc/r/SGLKKOiE),
but also has a lot of app resources(labels) you can change if you want to.

### Style

If you want to customize the CSS, you will usually follow these checklists:

* [Customize Styles in a standard app](https://azing.org/2sxc/r/gg_aB9FD)
* [Build custom styles](https://azing.org/2sxc/r/MaPs7Mdz)

## Screenshots

FIXME: Add link when App Catalog entry is made

## CSS Framework Detection

_Here you'll see how the content-templates switch between Bootstrap3 and Bootstrap4 templates_

Almost every view is implemented as Bootstrap4, but as one of the first lines you'll see:

```
@if(Connect.Koi.Koi.Is("bs3")) {
  @RenderPage("../bs3/Person/_some-file.cshtml")
  return;
}
```

This does the following

1. Ask Koi if it's using Bootstrap 3 (code 'bs3') using [Koi.Is(...)](https://connect-koi.net/components)
1. If it's a match, it will render the BS3 file and then return

So if it is Boostrap3, then the rest of the view will not be rendered at all. 

> If you start making changes and you're not using Bootstrap3 at all, you can also delete these lines!