using ToSic.Razor.Blade;
using ToSic.Sxc.Images;

namespace AppCode.Razor
{
  /// <summary>
  /// Base Class for Razor Views which have a typed App but don't use the Model or use the typed MyModel.
  /// </summary>
  public abstract class DetailRazor : AppRazor<object>
  {

    /// <summary>
    /// Shows a back to list button
    /// </summary>
    public IHtmlTag BackToListButton()
    {
      return Kit.HtmlTags.A(App.Resources.LabelBackToList).Class("btn").Class("btn-outline-primary").Class("app-backtolist").Href(Link.To().ToString());
    }

    /// <summary>
    /// Return a FancyBox data object for a picture
    /// </summary>
    public IHtmlTag GetFancyboxData(IResponsivePicture lbPic)
    {
      var tags = Kit.HtmlTags;

      return tags.RawHtml(
        tags.Attr("data-srcset", lbPic.SrcSet),
        tags.Attr("data-sizes", lbPic.Sizes),
        tags.Attr("data-src", lbPic.Src),
        tags.Attr("data-preload", false),
        tags.Attr("data-caption", lbPic.Alt)
      );
    }
  }
}
