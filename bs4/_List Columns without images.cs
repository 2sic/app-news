@inherits Custom.Hybrid.Razor12Code
@using ToSic.Sxc.Search;
@using ToSic.Eav.Run;

@functions{
  /// <summary>
  /// Prevent duplicated search results.
  /// Since the main list will already add all the items to the search, this view should not add them again.
  /// </summary>
  
  //TODO: 2dm
  public override void CustomizeSearch(Dictionary<string, List<ISearchItem>> searchInfos, IContainer moduleInfo, DateTime beginDate) {
    searchInfos.Clear();
  }
}