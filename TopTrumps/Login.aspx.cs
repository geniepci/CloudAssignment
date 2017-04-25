using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Blob;

namespace TopTrumps
{
    public partial class HomePage : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {
   

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

                Response.Redirect("GamePage.aspx");


     
        }

        private string StorageConnectionString
        {
            get
            {
                //return "DefaultEndpointsProtocol=https;AccountName=b6039258storage;AccountKey=jOhJQMZO93hr7BuHGfnqdYQ93EauYbfyArfyJD/wKmwwyIwdCDb9XcohAn4lOz1baU0sVtEdH+J7Vg98Q/loeg==";
                return "UseDevelopmentStorage=true";
            }
        }

        private CloudTable GetTable(string tableName)
        {
            CloudStorageAccount gameStorage = CloudStorageAccount.Parse(StorageConnectionString);
            CloudTableClient gameTable = gameStorage.CreateCloudTableClient();
            CloudTable table = gameTable.GetTableReference(tableName);
            table.CreateIfNotExists();
            return table;
        }
    }
}