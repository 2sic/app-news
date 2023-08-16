using ToSic.Razor.Blade;
using System;

public class Details: Custom.Hybrid.CodeTyped
{

  // Shows a back to list button
  public object BackToListButton() {
    return Tag.A(App.Resources.String("LabelBackToList")).Class("btn").Class("btn-outline-primary").Class("app-backtolist").Href(Link.To().ToString());
  }
}

