using System;
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  public partial class Paging: Props.ZagPaging
  {  }
}

namespace AppCode.Data.Props
{
  public abstract class ZagPaging: Custom.Data.CustomItem
  {
   
    public int ItemCount => _item.Int("ItemCount");
    public int PageCount => _item.Int("PageCount");
    public int PageSize => _item.Int("PageSize");
    public int PageNumber => _item.Int("PageNumber");
    public string Title => _item.String("Title", fallback: "");
  }
}
