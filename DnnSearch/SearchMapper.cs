using System;
using System.Collections.Generic;
using System.Linq;
using ToSic.Sxc.Context;
using ToSic.Sxc.Search;
/*
Custom code which views use to customize how dnn search treats data of that view.
It's meant for customizing the internal indexer of the platform, _not_ for Google Search.

To use it, create a custom code (.cs) file which implements ICustomizeSearch interface.
You can also inherit from a DynamicCode base class (like Code12) if you need more functionality.

For more guidance on search customizations, see https://r.2sxc.org/customize-search
*/
public class SearchMapper : Custom.Hybrid.Code12, ICustomizeSearch
{
    /// <summary>
    /// Populate the search
    /// </summary>
    /// <param name="searchInfos">Dictionary containing the streams and items in the stream for this search.</param>
    /// <param name="moduleInfo">Module information with which you can find out what page it's on etc.</param>
    /// <param name="beginDate">Last time the indexer ran - because the data you will get is only what was modified since.</param>
    public void CustomizeSearch(Dictionary<string, List<ISearchItem>> searchInfos, IModule moduleInfo, DateTime beginDate)
    {
        // Set this to true if you want to see logs of this search in the insights
        // Only do this while developing, otherwise you'll flood the logs and never see the important parts
        Log.Preserve = false;
        
        foreach (var si in searchInfos["News"])
        {
            var entity = AsDynamic(si.Entity);
            si.Title = "News: " + entity.Title + moduleInfo.Id;
            si.QueryString = "details=" + entity.UrlKey;
        }
    }
}
