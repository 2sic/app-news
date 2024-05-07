using AppCode.Data;
using ToSic.Razor.Blade;
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
      // Only compare dates, not times, because the UI only has a date picker
      // remember to change this, if ever you want to have time-bound publishing
      if (MyUser.IsContentAdmin && article.IsNotEmpty("ShowFrom") && article.ShowFrom.Date > DateTime.Now.Date)
        return Kit.HtmlTags.Div(App.Resources.LabelShowFromPill + " " + article.ShowFrom.Date.ToString("d")).Class("alert").Class("alert-warning");

      if (MyUser.IsContentAdmin && article.IsNotEmpty("ShowTo") && article.ShowTo.Date <= DateTime.Now.Date)
        return Kit.HtmlTags.Div(App.Resources.LabelShowToPill + " " + article.ShowTo.Date.ToString("d")).Class("alert").Class("alert-danger");

      return null; 
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
}
