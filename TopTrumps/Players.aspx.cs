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
    public partial class Players : System.Web.UI.Page
    {
        // Get storage connection string. LOCAL: Storage Emulator. CLOUD: Azure Storage Account.
        private string StorageConnectionString3
        {
            get
            {
                return "UseDevelopmentStorage=true";
            }
        }


        private int GetNextPlayerRowKey()
        {
            CloudTable getCategoryTable = GetPlayersCloudTable();
            TableQuery<CategoryEntity> query = new TableQuery<CategoryEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "P1"));
            List<int> outcome = new List<int> { };
            foreach (CategoryEntity entity in getCategoryTable.ExecuteQuery(query))
            {
                outcome.Add(Convert.ToInt16(entity.RowKey));
            }

            if (outcome.Count == 0)
            {
                return 1;
            }

            else
            {
                outcome.Sort();
                outcome.Reverse();
                int newRowKey = 1 + Convert.ToInt16(outcome[0]);
                return newRowKey;
            }
        }


        protected void btnInsert3_Click(object sender, EventArgs e)
        {
            if (!IsPostBack) { return; } // Do not insert new message on browser refresh.

            // Create message object from web form data.
            PlayersEntity insertPlayer = new PlayersEntity();
            insertPlayer.PlayerName = txtPlayerName.Text;
            insertPlayer.Age = txtAge.Text;
            insertPlayer.Wins = "0";
            insertPlayer.Losses = "0";

            
            int newRowKey = GetNextPlayerRowKey();
            insertPlayer.RowKey = Convert.ToString(newRowKey);
            // Get Cloud Table object for Messages Table.
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();


            // Create Table Operation to insert new Message Entity.
            TableOperation insertOperation = TableOperation.Insert(insertPlayer);

            //New Photo Code
            if (PhotoUpload.HasFile)
            {
                CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
                CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(insertPlayer.PartitionKey + "-" + insertPlayer.RowKey);
                myBlobIdentity.UploadFromStream(PhotoUpload.FileContent);
                insertPlayer.ImageURI = myBlobIdentity.Uri.ToString();
            }
            else
            {
                insertPlayer.ImageURI = string.Empty;

            }

            // Insert new message into Messages Table.
            myPlayersCloudTable.Execute(insertOperation);


            // Update web form. Clear text boxes. Refresh messages list.
            txtPlayerName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPartitionKey.Text = string.Empty;
            txtRowKey.Text = string.Empty;

            dataListMessages.DataBind();
        }

        protected void btnDelete3_Click(object sender, EventArgs e)
        {
            string rowKey = GetRowKeyFirstSelectedCategory();

            //obtain messages cloud table
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();

            // retrieve table operation object
            TableOperation retrieveOperation =
            TableOperation.Retrieve<PlayersEntity>("P1", rowKey);

            //Obtain the message entity that will be deleted
            TableResult retrieveResult =
            myPlayersCloudTable.Execute(retrieveOperation);

            PlayersEntity deleteMessage =
            (PlayersEntity)retrieveResult.Result;

            // Create Table Operation to delete a Message Entity
            TableOperation deleteOperation = TableOperation.Delete(deleteMessage);

            //My delete blobs

            // Access cloud storage account. Uses connection string obtained above.
            CloudStorageAccount myCloudStorgageAccount = CloudStorageAccount.Parse(StorageConnectionString3);

            // Create cloud storage account. Provides access to the Blobs in the Storage Account 
            CloudBlobClient myCloudBlobClient = myCloudStorgageAccount.CreateCloudBlobClient();

            // Get the container for the reference 'myblobcontainer'.
            CloudBlobContainer myMessagesCloudBlob = myCloudBlobClient.GetContainerReference("thegameblobs");

            //Now select the blob associated with the message. Its a combination of the partition key P1 a - and the row key
            CloudBlockBlob myBlockBlob = myMessagesCloudBlob.GetBlockBlobReference("P1" + "-" + rowKey);

            //Now run the command to delete the blob
            myBlockBlob.Delete();

            // Delete message in Messages Table
            myPlayersCloudTable.Execute(deleteOperation);

            // Update web form. Clear text boxes. Refresh messages list.
            txtPlayerName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPartitionKey.Text = string.Empty;
            txtRowKey.Text = string.Empty;

            dataListMessages.DataBind();
        }

        protected void btnEdit3_Click(object sender, EventArgs e)
        {
            string rowKey = GetRowKeyFirstSelectedCategory();

            //obtain messages cloud table
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();

            // retrieve table operation object
            TableOperation retrieveOperation =
            TableOperation.Retrieve<PlayersEntity>("P1", rowKey);

            //Obtain the message entity that will be edited
            TableResult retrieveResult =
            myPlayersCloudTable.Execute(retrieveOperation);

            PlayersEntity editMessage =
            (PlayersEntity)retrieveResult.Result;

            // values to edit a message in the text boxes (values come from message entity class)
            txtPlayerName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPartitionKey.Text = string.Empty;
            txtRowKey.Text = string.Empty;

            dataListMessages.DataBind();
        }

        protected void btnReplace3_Click(object sender, EventArgs e)
        {

            //obtain messages cloud table
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();

            // retrieve table operation object
            TableOperation retrieveOperation =
            TableOperation.Retrieve<PlayersEntity>("P1", txtRowKey.Text);

            //Obtain the message entity that will be replaced
            TableResult retrieveResult =
            myPlayersCloudTable.Execute(retrieveOperation);

            PlayersEntity replaceMessage =
            (PlayersEntity)retrieveResult.Result;

            CardEntity deleteMessage =
            (CardEntity)retrieveResult.Result;

            // Create Table Operation to replace a Message Entity
            TableOperation replaceOperation = TableOperation.Replace(replaceMessage);

            // replace message in Messages Table
            myPlayersCloudTable.Execute(replaceOperation);

            txtPlayerName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPartitionKey.Text = string.Empty;
            txtRowKey.Text = string.Empty;

            dataListMessages.DataBind();
        }

        public IEnumerable<PlayersEntity> GetPlayers()
        {

            // Get Cloud Table object for Messages Table.
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();


            // Create a Table Query object.
            TableQuery<PlayersEntity> myTableQuery =
            new TableQuery<PlayersEntity>();


            // Get list from Messages Table.
            IEnumerable<PlayersEntity> messagesList =
            myPlayersCloudTable.ExecuteQuery(myTableQuery);


            // Sort in reverse chronological order.
            messagesList = messagesList.OrderByDescending(msg => msg.Timestamp);

            // Output to data list on web form.
            return messagesList;

        }

        public IEnumerable<PlayersEntity> GetPlayerScores()
        {

            // Get Cloud Table object for Messages Table.
            CloudTable myPlayersCloudTable = GetPlayersCloudTable();


            // Create a Table Query object.
            TableQuery<PlayersEntity> myTableQuery =
            new TableQuery<PlayersEntity>();


            // Get list from Messages Table.
            IEnumerable<PlayersEntity> messagesList =
            myPlayersCloudTable.ExecuteQuery(myTableQuery);


            // Sort in reverse chronological order.
            messagesList = messagesList.OrderByDescending(msg => msg.Wins);

            // Output to data list on web form.
            return messagesList;

        }


        private CloudTable GetPlayersCloudTable()
        {
            // Access cloud storage account. Uses connection string obtained above.
            CloudStorageAccount myCloudStorageAccount =
            CloudStorageAccount.Parse(StorageConnectionString3);


            // Create cloud table client. Provides access to Tables in your Storage Account 
            CloudTableClient myCloudTableClient =
            myCloudStorageAccount.CreateCloudTableClient();


            // Get Cloud Table for Message Table.
            CloudTable myPlayersCloudTable =
            myCloudTableClient.GetTableReference("PlayerTable");

            // Create Messages Table if it does not already exist. 
            myPlayersCloudTable.CreateIfNotExists();


            // Output Messages Cloud Table object. Provides the means of accessing the Messages Table.
            return myPlayersCloudTable;

        }

        private CloudBlobContainer GetImagesBlobContainer()
        {
            // Access cloud storage account. Uses connection string obtained above.
            CloudStorageAccount myCloudStorgageAccount = CloudStorageAccount.Parse(StorageConnectionString3);

            // Create cloud table client. Provides access to Tables in your Storage Account 
            CloudBlobClient myCloudBlobClient = myCloudStorgageAccount.CreateCloudBlobClient();

            // Get Cloud Table for Message Table.
            //CloudBlob myMessagesCloudBlob = myCloudBlobClient.GetBlobReference("MessagesTable");
            CloudBlobContainer myPlayersCloudBlob = myCloudBlobClient.GetContainerReference("thegameblobs");

            // Create Messages Table if it does not already exist. 
            myPlayersCloudBlob.CreateIfNotExists();

            //The purpose of the this code is to make the images in your container publicly accessible. Without it you would not be able to see the images in your application or by using their URLs.
            myPlayersCloudBlob.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });


            // Output Messages Cloud Table object. Provides the means of accessing the Messages Table.
            return myPlayersCloudBlob;
        }

        private string GetRowKeyFirstSelectedCategory()
        {
            List<string> selectedCustomerRowKeys = new List<string>();

            foreach (Control ctrl in dataListMessages.Controls)
            {
                CheckBox chkBox = (CheckBox)ctrl.FindControl("RowKey");

                if (chkBox.Checked)
                {
                    return chkBox.Text;
                }
            }

            return string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}