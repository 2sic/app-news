using System;
using System.Globalization;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;

public class Helpers: Custom.Hybrid.CodeTyped
{
  // @* Show info to admin whether the article will publish or is already expired *@
  public IHtmlTag AdminArticleInformation(ITypedItem article) {
    if (MyUser.IsContentAdmin && article.Get("ShowFrom") != null && article.DateTime("ShowFrom").Date > DateTime.Now.Date)
      return Tag.Div(App.Resources.String("LabelShowFromPill") + " " + article.DateTime("ShowFrom").Date.ToString("d")).Class("alert").Class("alert-warning");

    if (MyUser.IsContentAdmin && article.Get("ShowTo") != null && article.DateTime("ShowTo").Date <= DateTime.Now.Date)
      return Tag.Div(App.Resources.String("LabelShowToPill") + " " + article.DateTime("ShowTo").Date.ToString("d")).Class("alert").Class("alert-danger");

    return Tag.Div();
  }

  // @* Show warning that the details page needs to be changed *@
  public IHtmlTag AdminDetailsPageConfigWarning() {
    return App.Settings.Bool("DetailsPageShowWarning")
      ? Tag.Div().Class("alert").Class("alert-danger")
        .Attr(Kit.Toolbar.Empty().AppSettings())
        .Wrap(App.Resources.String("LabelAdminDetailPageWarning"))
      : Tag.Div();
  }

  /**
  * Returns a safe url to a post details page
  */
  public string LinkToDetailsPage(ITypedItem article) {
    var detailsPage = App.Settings.String("DetailsPage");

    if (!detailsPage.Contains(":")) return "";
    var detailsPageId = int.Parse(detailsPage.Split(':')[1]);

    return Link.To(pageId: detailsPageId, parameters: "details=" + article.String("UrlKey"));
  }

  public string TeaserAssembly(ITypedItem article) {
    return Text.First(article.String("Teaser"), Text.Ellipsis(article.String("Content", scrubHtml: true), 100));
  }
}