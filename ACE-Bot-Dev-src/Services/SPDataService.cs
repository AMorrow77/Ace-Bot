using System;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;

namespace Microsoft.SDK.SharePointServices.Samples
{
    class RetrieveListItems
    {
        static void Main()
        {

        }
        void DataCall(string clientName){
            string siteUrl = "https://plusdemo01.sharepoint.com";

            ClientContext clientContext = new ClientContext(siteUrl);
            SP.List oList = clientContext.Web.Lists.GetByTitle("Mock Projects");

            CamlQuery camlQuery = new CamlQuery();
            camlQuery.ViewXml = "<View><Query><Where><Geq><FieldRef Name='Title'/>" +
                "<Value Type='Text'>Arconic</Value></Geq></Where></Query><RowLimit>100</RowLimit></View>";
            ListItemCollection collListItem = oList.GetItems(camlQuery);

            clientContext.Load(collListItem);

            clientContext.ExecuteQuery();

            foreach (ListItem oListItem in collListItem)
            {
                
            }
        }
    }
}