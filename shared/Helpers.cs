using ToSic.Razor.Blade;
using System;
using System.Globalization;

public class Helpers: Custom.Hybrid.Code12
{
  // @* Show info to admin whether the article will publish or is already expired *@
  public dynamic AdminArticleInformation(dynamic article) {
    if(Edit.Enabled && article.ShowFrom != null && article.ShowFrom.Date > DateTime.Now.Date) {
      return Tag.Div(App.Resources.LabelShowFromPill + " " + article.ShowFrom.Date.ToString("d")).Class("alert").Class("alert-warning");
    }

    if(Edit.Enabled && article.ShowTo != null && article.ShowTo.Date <= DateTime.Now.Date) {
      return Tag.Div(App.Resources.LabelShowToPill + " " + article.ShowTo.Date.ToString("d")).Class("alert").Class("alert-danger");
    }

    return Tag.Div();
  }

  // @* Show warning that the details page needs to be changed *@
  public dynamic AdminDetailsPageConfigWarning() {
    if(App.Settings.DetailsPageShowWarning) {
      return Tag.Div(App.Resources.LabelAdminDetailPageWarning).Class("alert").Class("alert-danger");
    }

    return Tag.Div();
  }

  /**
  * Returns a safe url to a post details page
  */
  public dynamic LinkToDetailsPage(dynamic article) {
    var detailsPageTabId = int.Parse(AsDynamic(App.Settings).Get("DetailsPage").Split(':')[1]);
    // var detailsPageTabId = int.Parse((AsEntity(App.Settings).GetBestValue("DetailsPage")).Split(':')[1]);

    return "test?details=hello"; // Tags.SafeUrl(Link.To(pageId: detailsPageTabId, parameters: "details=" + article.UrlKey));
  }
}

  