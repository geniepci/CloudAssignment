using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Blob;

namespace TopTrumps
{

    public partial class DeveloperPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoryList.Visible = false;
                cardList.Visible = false;
                nameTxtBox.Visible = false;
                attributeOneTxtBox.Visible = false;
                attributeTwoTxtBox.Visible = false;
                attributeThreeTxtBox.Visible = false;
                attributeFourTxtBox.Visible = false;
                attributeFiveTxtBox.Visible = false;
                chooseCategory.Visible = false;
                Button3.Visible = false;
                blobUpload.Visible = false;
                createCategory.Visible = false;
                createCard.Visible = false;
                categoryList.Items.Clear();
                string method = ListAllCategories();
            }
            //This is needed to stop this code being called every time a button is clicked

        }

        protected void chooseOption_Click(object sender, EventArgs e)
        {
            if (optionList.SelectedValue == "1")
            {
                nameTxtBox.Visible = true;
                attributeOneTxtBox.Visible = true;
                attributeTwoTxtBox.Visible = true;
                attributeThreeTxtBox.Visible = true;
                attributeFourTxtBox.Visible = true;
                attributeFiveTxtBox.Visible = true;
                //blobUpload.Visible = true;
                createCategory.Visible = true;
                Label3.Text = "Category Name";
                Label4.Text = "Name of First Attribute";
                Label5.Text = "Name of Second Attribute";
                Label6.Text = "Name of Third Attribute";
                Label7.Text = "Name of Fourth Attribute";
                Label8.Text = "Name of Fifth Attribute";

            }

            if (optionList.SelectedValue == "2")
            {
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;
            }
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
            CloudTable categoryTable = gameTable.GetTableReference(tableName);
            return categoryTable;
        }

        private string ListAllCategories()
        {
            CloudTable getCardTable = GetTable("CategoryTable");
            TableQuery<CategoryEntity> query = new TableQuery<CategoryEntity>();//Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, categoryPartKey));
            foreach (CategoryEntity entity in getCardTable.ExecuteQuery(query))
            {
                categoryList.Items.Add(Convert.ToString(entity.Name) + "-" + Convert.ToString(entity.PartitionKey) + "-" + Convert.ToString(entity.RowKey));

            }

            return string.Empty;
        }

        private int GetNextCategoryRowKey(string categoryPartKey)
        {
            CloudTable getCategoryTable = GetTable("CategoryTable");
            TableQuery<CategoryEntity> query = new TableQuery<CategoryEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, categoryPartKey));
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

        private int GetNextCardRowKey(string cardPartKey)
        {
            CloudTable getCardTable = GetTable("CardTable");
            TableQuery<CardEntity> query = new TableQuery<CardEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, cardPartKey));
            List<int> outcome = new List<int> { };
            foreach (CardEntity entity in getCardTable.ExecuteQuery(query))
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

        protected void chooseCategory_Click(object sender, EventArgs e)
        {
            if (categoryList.SelectedValue == "")
            {
                Label11.Text = "Please select a category";
            }

            else
            {
                string ashTest = categoryList.SelectedValue;
                string[] ashTest1 = ashTest.Split('-');
                Label3.Text = ashTest1[1];
                Label4.Text = ashTest1[2];
                //Label5.Text = ashTest1[2]
                if (optionList.SelectedValue == "2")
                {
                    string method = populateCategoryTitles(ashTest1[1], ashTest1[2]);
                    createCard.Visible = true;
                    Label9.Text = "Card Image";
                    blobUpload.Visible = true;
                }
            }




        }

        private string populateCategoryTitles(string partKey, string rowKey)
        {
            CloudTable getCategoryTable = GetTable("CategoryTable");
            TableOperation retrieveOperation = TableOperation.Retrieve<CategoryEntity>(partKey, rowKey);
            TableResult retrievedResult = getCategoryTable.Execute(retrieveOperation);
            nameTxtBox.Visible = true;
            attributeOneTxtBox.Visible = true;
            attributeTwoTxtBox.Visible = true;
            attributeThreeTxtBox.Visible = true;
            attributeFourTxtBox.Visible = true;
            attributeFiveTxtBox.Visible = true;
            Label3.Text = "Name";
            Label4.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameOne;
            Label5.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameTwo;
            Label6.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameThree;
            Label7.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFour;
            Label8.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFive;




            return string.Empty;
        }


        protected void createCategory_Click(object sender, EventArgs e)
        {
            if (!IsPostBack) { return; } // Do not insert new message on browser refresh.

            // Create message object from web form data.
            CategoryEntity insertCategory = new CategoryEntity();
            insertCategory.Name = nameTxtBox.Text;
            insertCategory.AttributeNameOne = attributeOneTxtBox.Text;
            insertCategory.AttributeNameTwo = attributeTwoTxtBox.Text;
            insertCategory.AttributeNameThree = attributeThreeTxtBox.Text;
            insertCategory.AttributeNameFour = attributeFourTxtBox.Text;
            insertCategory.AttributeNameFive = attributeFiveTxtBox.Text;
            insertCategory.PartitionKey = "Category";

            int newRowKey = GetNextCategoryRowKey("Category");
            insertCategory.RowKey = Convert.ToString(newRowKey);



            // Get Cloud Table object for Messages Table.
            CloudTable myMessagesCloudTable = GetTable("CategoryTable");

            // Create Table Operation to insert new Message Entity.
            TableOperation insertOperation = TableOperation.Insert(insertCategory);



            //New Photo Code
            //if (PhotoUpload.HasFile)
            //{
            //    CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            //    CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(insertMessage.PartitionKey + "-" + insertMessage.RowKey);
            //    myBlobIdentity.UploadFromStream(PhotoUpload.FileContent);
            //    insertMessage.ImageURI = myBlobIdentity.Uri.ToString();
            //}
            //else
            //{
            //    insertMessage.ImageURI = string.Empty;
            //}

            // Insert new message into Messages Table.
            myMessagesCloudTable.Execute(insertOperation);

            // Update web form. Clear text boxes. Refresh messages list.
            //txtAuthor.Text = string.Empty;
            //txtMessage.Text = string.Empty;
            //txtPartitionKey.Text = string.Empty;
            //txtRowKey.Text = string.Empty;
            //dataListMessages.DataBind();


        }

        protected void createCard_Click(object sender, EventArgs e)
        {
            if (!IsPostBack) { return; } // Do not insert new message on browser refresh.

            // Create message object from web form data.
            CardEntity insertCard = new CardEntity();
            insertCard.Name = nameTxtBox.Text;
            insertCard.AttributeOne = attributeOneTxtBox.Text;
            insertCard.AttributeTwo = attributeTwoTxtBox.Text;
            insertCard.AttributeThree = attributeThreeTxtBox.Text;
            insertCard.AttributeFour = attributeFourTxtBox.Text;
            insertCard.AttributeFive = attributeFiveTxtBox.Text;
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            insertCard.PartitionKey = ashTest1[1]+ashTest1[2];

            int newRowKey = GetNextCardRowKey(ashTest1[1] + ashTest1[2]);
            insertCard.RowKey = Convert.ToString(newRowKey);



            // Get Cloud Table object for Messages Table.
            CloudTable myMessagesCloudTable = GetTable("CardTable");

            // Create Table Operation to insert new Message Entity.
            TableOperation insertOperation = TableOperation.Insert(insertCard);



            //New Photo Code
            //if (PhotoUpload.HasFile)
            //{
            //    CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            //    CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(insertMessage.PartitionKey + "-" + insertMessage.RowKey);
            //    myBlobIdentity.UploadFromStream(PhotoUpload.FileContent);
            //    insertMessage.ImageURI = myBlobIdentity.Uri.ToString();
            //}
            //else
            //{
            //    insertMessage.ImageURI = string.Empty;
            //}

            // Insert new message into Messages Table.
            myMessagesCloudTable.Execute(insertOperation);

            // Update web form. Clear text boxes. Refresh messages list.
            //txtAuthor.Text = string.Empty;
            //txtMessage.Text = string.Empty;
            //txtPartitionKey.Text = string.Empty;
            //txtRowKey.Text = string.Empty;
            //dataListMessages.DataBind();


        }
    }
}
