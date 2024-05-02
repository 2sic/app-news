namespace AppCode.Data
{
  public partial class Paging: Custom.Data.CustomItem
  {   
    public int ItemCount => _item.Int("ItemCount");
    public int PageCount => _item.Int("PageCount");
    public int PageSize => _item.Int("PageSize");
    public int PageNumber => _item.Int("PageNumber");
  }
}
