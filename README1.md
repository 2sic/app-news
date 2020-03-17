## 2sxc News App

A standard news / announcements app to use with 2sxc

## Getting Started
This app is only useful is you use DNN. So assuming you have a DNN installation, all you need to do is install 2sxc and this app.

* Here's how to [install 2sxc and an App of your Choice](http://2sxc.org/en/blog/post/install-2sxc-and-an-app-of-your-choice)

* Now you can use this app as-is, or customize it to be whatever you need it to be.

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