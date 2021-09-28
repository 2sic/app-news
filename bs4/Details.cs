using ToSic.Razor.Blade;
using System;
using System.Web;

public class Details: Custom.Hybrid.Code12
{
  public void SetNotFoundHttpHeaders() {
    // Dnn only - this used to be done in Details if the page wasn't found
    // We're not sure if this was a good idea, for now just disable
    // If we plan on reactivating it, we have to pass the Response object to the code, as the code doesn't have a Response object
    // Response.StatusCode = 404;
    // Response.TrySkipIisCustomErrors = true;
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

