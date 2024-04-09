// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// All the classes are partial, so you can extend them in a separate file.

// Generator:   RazorViewsGenerator v17.06.02
// App/Edition: News/
// User:        2sic Web-Developer
// When:        2024-04-09 07:32:29Z

using AppCode.Data;
using ToSic.Sxc.Apps;

namespace AppCode.Razor
{
  /// <summary>
  /// Base Class for Razor Views which have a typed App but don't use the Model or use the typed MyModel.
  /// </summary>
  public abstract partial class AppRazor: AppRazor<object>
  {
  }

  /// <summary>
  /// Base Class for Razor Views which have a typed App and a typed Model
  /// </summary>
  public abstract partial class AppRazor<TModel>: Custom.Hybrid.RazorTyped<TModel>
  {

    /// <summary>
    /// Typed App with typed Settings & Resources
    /// </summary>
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>();
    private IAppTyped<AppSettings, AppResources> _app;
  }
}
