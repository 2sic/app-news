using ToSic.Razor.Blade;
using System;
using System.Web;

public class Details: Custom.Hybrid.Code12
{
  //TODO: 2dm
  public void SetNotFoundHttpHeaders() {
    // Dnn only
    #if !NETCOREAPP
      Response.StatusCode = 404;
      Response.TrySkipIisCustomErrors = true;
    #endif
  }

  // Shows a back to list button
  public dynamic BackToListButton() {
    return Tag.A(App.Resources.LabelBackToList).Class("btn").Class("btn-outline-primary").Class("app-backtolist").Href(Tags.SafeUrl(Link.To()).ToString());
  }

  public void AddMetaTags(dynamic article) {
    // Dnn only
    #if !NETCOREAPP
      HtmlPage.AddMeta("description", Tags.Strip(article.Teaser));
      HtmlPage.Title = article.Date.ToString("d") + " - " + article.Title +  " | " + HtmlPage.Title;
    #endif
  }
}

