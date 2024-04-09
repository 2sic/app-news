using AppCode.Data;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;
using System;

namespace AppCode.Razor
{
  public abstract partial class AppRazor<TModel> : Custom.Hybrid.RazorTyped<TModel>
  {
    /// <summary>
    /// Show info to admin whether the article will publish or is already expired 
    /// </summary>
    public IHtmlTag AdminArticleInformation(News article)
    {
      if (MyUser.IsContentAdmin && article.Get("ShowFrom") != null && article.ShowFrom.Date > DateTime.Now.Date)
        return Tag.Div(App.Resources.LabelShowFromPill + " " + article.ShowFrom.Date.ToString("d")).Class("alert").Class("alert-warning");

      if (MyUser.IsContentAdmin && article.Get("ShowTo") != null && article.ShowTo.Date <= DateTime.Now.Date)
        return Tag.Div(App.Resources.LabelShowToPill + " " + article.ShowTo.Date.ToString("d")).Class("alert").Class("alert-danger");

      return Tag.Div();
    }

    /// <summary>
    /// Show warning that the details page needs to be changed
    /// </summary>
    public IHtmlTag AdminDetailsPageConfigWarning()
    {
      return App.Settings.DetailsPageShowWarning
        ? Tag.Div().Class("alert").Class("alert-danger")
          .Attr(Kit.Toolbar.Empty().AppSettings())
          .Wrap(App.Resources.LabelAdminDetailPageWarning)
        : Tag.Div();
    }

    /// <summary>
    /// Returns a safe url to a post details page
    /// </summary>
    public string LinkToDetailsPage(News article)
    {
      // TODO:: Why is use .String("UrlKey") instead of .UrlKey?
      var detailsPage = App.Settings.String("DetailsPage");

      if (!detailsPage.Contains(":")) return "";
      var detailsPageId = int.Parse(detailsPage.Split(':')[1]);

      return Link.To(pageId: detailsPageId, parameters: "details=" + article.UrlKey);
    }

    public string TeaserAssembly(News article)
    {
      return Text.First(article.Teaser, Text.Ellipsis(Kit.Scrub.All(article.Content), 100));
    }
  }

    internal class Todo
    {
    }

}
