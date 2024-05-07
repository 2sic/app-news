using AppCode.Data;

namespace AppCode.Razor
{
  public abstract class PagingRazor : AppRazor<object>
  {
    /// <summary>
    /// Generate a paging-link, preserving current category parameters
    /// </summary>
    public string LinkToPageNumber(int pageNumber)
    {
      var filteredCategory = As<Category>(MyData.GetStream("Category"));

      var categoryParam = filteredCategory != null
        ? "category=" + filteredCategory.UrlKey + "&"
        : "";

      return Link.To(parameters: categoryParam + "page=" + pageNumber);
    }

  }
}
