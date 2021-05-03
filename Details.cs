using ToSic.Razor.Blade;
using System;
using System.Web;

public class Details: Custom.Hybrid.Code12
{
  //TODO: 2dm
  public void SetNotFoundHttpHeaders() {
    // Response.StatusCode = 404;
    // Response.TrySkipIisCustomErrors = true;
  }

  // Shows a back to list button
  public dynamic BackToListButton() {
    return Tag.A(App.Resources.LabelBackToList).Class("btn").Class("btn-outline-primary").Class("app-backtolist").Href(Tags.SafeUrl(Link.To()).ToString());
  }

  public void AddMetaTags(dynamic article) {
    HtmlPage.AddMeta("description", Tags.Strip(article.Teaser));
    HtmlPage.Title = article.Date.ToString("d") + " - " + article.Title +  " | " + HtmlPage.Title;
  }
}

