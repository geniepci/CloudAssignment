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
            //This is needed to stop this code being called every time a button is clicked
            if (!IsPostBack)
            {
                categoryList.Visible = false;
                cardList.Visible = false;


                Label12.Visible = false;
                Label10.Visible = false;

                string method = HideBoxesAndButtons();
                categoryList.Items.Clear();

            }

        }




        private string HideBoxesAndButtons()
        {
            categoryList.Visible = false;
            cardList.Visible = false;
            chooseCategory.Visible = false;
            chooseCard.Visible = false;
            createCategory.Visible = false;
            createCard.Visible = false;
            updateCategory.Visible = false;
            updateCard.Visible = false;
            deleteCategory.Visible = false;
            deleteCard.Visible = false;
            nameTxtBox.Visible = false;
            nameTxtBox.Text = "";
            attributeOneTxtBox.Visible = false;
            attributeOneTxtBox.Text = "";
            attributeTwoTxtBox.Visible = false;
            attributeTwoTxtBox.Text = "";
            attributeThreeTxtBox.Visible = false;
            attributeThreeTxtBox.Text = "";
            attributeFourTxtBox.Visible = false;
            attributeFourTxtBox.Text = "";
            attributeFiveTxtBox.Visible = false;
            attributeFiveTxtBox.Text = "";
            blobUpload.Visible = false;
            blobImage.Visible = false;
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Visible = false;
            Label11.Text = "";
            Label12.Visible = false;
            return string.Empty;
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

        private string ListAllCategories()
        {
            categoryList.Items.Clear();
            CloudTable getCategoryTable = GetTable("CategoryTable");
            TableQuery<CategoryEntity> query = new TableQuery<CategoryEntity>();//Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, categoryPartKey));
            foreach (CategoryEntity entity in getCategoryTable.ExecuteQuery(query))
            {
                categoryList.Items.Add(Convert.ToString(entity.Name) + "-" + Convert.ToString(entity.PartitionKey) + "-" + Convert.ToString(entity.RowKey));

            }

            return string.Empty;
        }



        private string ListAllCards(string cardPartKey)
        {
            cardList.Items.Clear();
            CloudTable getCardTable = GetTable("CardTable");
            TableQuery<CategoryEntity> query = new TableQuery<CategoryEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, cardPartKey));
            foreach (CategoryEntity entity in getCardTable.ExecuteQuery(query))
            {
                cardList.Items.Add(Convert.ToString(entity.Name) + "-" + Convert.ToString(entity.RowKey));

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
            Label3.Text = "Card Name";
            Label4.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameOne;
            Label5.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameTwo;
            Label6.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameThree;
            Label7.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFour;
            Label8.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFive;




            return string.Empty;
        }

        private string populateCategoryData(string partKey, string rowKey)
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
            Label3.Text = "Category Name";
            Label4.Text = "Name of First Attribute";
            Label5.Text = "Name of Second Attribute";
            Label6.Text = "Name of Third Attribute";
            Label7.Text = "Name of Fourth Attribute";
            Label8.Text = "Name of Fifth Attribute";
            nameTxtBox.Text = ((CategoryEntity)retrievedResult.Result).Name;
            attributeOneTxtBox.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameOne;
            attributeTwoTxtBox.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameTwo;
            attributeThreeTxtBox.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameThree;
            attributeFourTxtBox.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFour;
            attributeFiveTxtBox.Text = ((CategoryEntity)retrievedResult.Result).AttributeNameFive;




            return string.Empty;
        }

        private string populateCardData(string partKey, string rowKey)
        {
            CloudTable getCardTable = GetTable("CardTable");
            TableOperation retrieveOperation = TableOperation.Retrieve<CardEntity>(partKey, rowKey);
            TableResult retrievedResult = getCardTable.Execute(retrieveOperation);
            nameTxtBox.Text = ((CardEntity)retrievedResult.Result).Name;
            attributeOneTxtBox.Text = ((CardEntity)retrievedResult.Result).AttributeOne;
            attributeTwoTxtBox.Text = ((CardEntity)retrievedResult.Result).AttributeTwo;
            attributeThreeTxtBox.Text = ((CardEntity)retrievedResult.Result).AttributeThree;
            attributeFourTxtBox.Text = ((CardEntity)retrievedResult.Result).AttributeFour;
            attributeFiveTxtBox.Text = ((CardEntity)retrievedResult.Result).AttributeFive;
            return string.Empty;
        }


        private string ClearTextBoxes()
        {
            attributeOneTxtBox.Text = string.Empty;
            attributeTwoTxtBox.Text = string.Empty;
            attributeThreeTxtBox.Text = string.Empty;
            attributeFourTxtBox.Text = string.Empty;
            attributeFiveTxtBox.Text = string.Empty;
            nameTxtBox.Text = string.Empty;
            return string.Empty;
        }

        private CloudBlobContainer GetImagesBlobContainer()
        {
            // Access cloud storage account. Uses connection string obtained above.
            CloudStorageAccount myCloudStorgageAccount = CloudStorageAccount.Parse(StorageConnectionString);

            // Create cloud table client. Provides access to Tables in your Storage Account 
            CloudBlobClient myCloudBlobClient = myCloudStorgageAccount.CreateCloudBlobClient();

            // Get Cloud Table for Message Table.
            //CloudBlob myMessagesCloudBlob = myCloudBlobClient.GetBlobReference("MessagesTable");
            CloudBlobContainer myMessagesCloudBlob = myCloudBlobClient.GetContainerReference("thegameblobs");

            // Create Messages Table if it does not already exist. 
            myMessagesCloudBlob.CreateIfNotExists();

            //The purpose of the this code is to make the images in your container publicly accessible. Without it you would not be able to see the images in your application or by using their URLs.
            myMessagesCloudBlob.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });


            // Output Messages Cloud Table object. Provides the means of accessing the Messages Table.
            return myMessagesCloudBlob;
        }

        private string PopulateBlob1(string blobReference)
        {
            CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(blobReference);
            blobImage.ImageUrl = myBlobIdentity.Uri.ToString();
            return string.Empty;

        }


        protected void chooseOption_Click(object sender, EventArgs e)
        {
            Label13.Visible = false;
            updateCard.Visible = false;
            updateCategory.Visible = false;
            createCard.Visible = false;
            createCategory.Visible = false;
            string methoda = HideBoxesAndButtons();


            if (optionList.SelectedValue == "1")
            {
                nameTxtBox.Visible = true;
                attributeOneTxtBox.Visible = true;
                attributeTwoTxtBox.Visible = true;
                attributeThreeTxtBox.Visible = true;
                attributeFourTxtBox.Visible = true;
                attributeFiveTxtBox.Visible = true;
                blobUpload.Visible = true;
                createCategory.Visible = true;
                Label3.Text = "Category Name";
                Label4.Text = "Name of First Attribute";
                Label5.Text = "Name of Second Attribute";
                Label6.Text = "Name of Third Attribute";
                Label7.Text = "Name of Fourth Attribute";
                Label8.Text = "Name of Fifth Attribute";
                Label9.Text = "Select Category Image";

            }

            if (optionList.SelectedValue == "2")
            {
                string method = ListAllCategories();
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;
            }

            if (optionList.SelectedValue == "3")
            {
                string method = ListAllCategories();
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;
            }

            if (optionList.SelectedValue == "4")
            {
                string method = ListAllCategories();
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;
            }

            if (optionList.SelectedValue == "5")
            {
                string method = ListAllCategories();
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;

            }

            if (optionList.SelectedValue == "6")
            {
                string method = ListAllCategories();
                categoryList.Visible = true;
                chooseCategory.Visible = true;
                Label10.Visible = true;
            }


        }


        protected void chooseCategory_Click(object sender, EventArgs e)
        {
            Label13.Visible = false;
            if (categoryList.SelectedValue == "")
            {
                Label11.Text = "Please select a category";
            }

            else
            {
                string ashTest = categoryList.SelectedValue;
                string[] ashTest1 = ashTest.Split('-');
                //Label5.Text = ashTest1[2]



                if (optionList.SelectedValue == "2")
                {
                    string method = populateCategoryTitles(ashTest1[1], ashTest1[2]);
                    createCard.Visible = true;
                    Label9.Text = "Card Image";
                    blobUpload.Visible = true;
                }


                if (optionList.SelectedValue == "3")
                {
                    string method = populateCategoryData(ashTest1[1], ashTest1[2]);
                    updateCategory.Visible = true;
                }

                if (optionList.SelectedValue == "4")
                {
                    string method = ListAllCards(ashTest1[1] + ashTest1[2]);
                    cardList.Visible = true;
                    chooseCard.Visible = true;
                    Label12.Visible = true;
                }


                if (optionList.SelectedValue == "5")
                {
                    string method = populateCategoryData(ashTest1[1], ashTest1[2]);
                    deleteCategory.Visible = true;
                    Label11.Visible = true;
                    Label11.Text = "Warning - Deleting a Category Also Deletes All Category Cards";
                }


                if (optionList.SelectedValue == "6")
                {
                    string method = ListAllCards(ashTest1[1] + ashTest1[2]);
                    cardList.Visible = true;
                    chooseCard.Visible = true;
                    Label12.Visible = true;

                }




            }
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

            CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(insertCategory.PartitionKey + "-" + insertCategory.RowKey);
            myBlobIdentity.UploadFromStream(blobUpload.FileContent);
            insertCategory.ImageURI = myBlobIdentity.Uri.ToString();

            // Insert new message into Messages Table.
            myMessagesCloudTable.Execute(insertOperation);

            // Clear the screen
            string method = ClearTextBoxes();
            Label13.Visible = true;
            Label13.Text = "Category Created";


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
            string partKey = ashTest1[1] + ashTest1[2];
            insertCard.PartitionKey = partKey;

            int newRowKey = GetNextCardRowKey(ashTest1[1] + ashTest1[2]);
            insertCard.RowKey = Convert.ToString(newRowKey);



            // Get Cloud Table object for Messages Table.
            CloudTable myMessagesCloudTable = GetTable("CardTable");

            // Create Table Operation to insert new Message Entity.
            TableOperation insertOperation = TableOperation.Insert(insertCard);

            CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(insertCard.PartitionKey + "-" + insertCard.RowKey);
            myBlobIdentity.UploadFromStream(blobUpload.FileContent);
            insertCard.ImageURI = myBlobIdentity.Uri.ToString();

            // Insert new message into Messages Table.
            myMessagesCloudTable.Execute(insertOperation);


            // Clear the screen
            string method = ClearTextBoxes();
            Label13.Visible = true;
            Label13.Text = "Card Created";

        }



        protected void updateCategory_Click(object sender, EventArgs e)
        {
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            CloudTable myMessagesCloudTable = GetTable("CategoryTable");
            // Create a retrieve operation that takes a category entity.
            TableOperation retrieveOperation = TableOperation.Retrieve<CategoryEntity>(ashTest1[1], ashTest1[2]);
            // Execute the operation.
            TableResult retrievedResult = myMessagesCloudTable.Execute(retrieveOperation);
            // Assign the result to a CustomerEntity object.
            CategoryEntity updateEntity = (CategoryEntity)retrievedResult.Result;
            // Transfer the textbox entries 
            updateEntity.AttributeNameOne = attributeOneTxtBox.Text;
            updateEntity.AttributeNameTwo = attributeTwoTxtBox.Text;
            updateEntity.AttributeNameThree = attributeThreeTxtBox.Text;
            updateEntity.AttributeNameFour = attributeFourTxtBox.Text;
            updateEntity.AttributeNameFive = attributeFiveTxtBox.Text;
            updateEntity.Name = nameTxtBox.Text;

            // Create the Replace TableOperation.
            TableOperation updateOperation = TableOperation.Replace(updateEntity);

            // Execute the operation.
            myMessagesCloudTable.Execute(updateOperation);
            // Clear the screen
            string method = ClearTextBoxes();
            Label13.Visible = true;
            Label13.Text = "Category Created";
        }


        protected void chooseCard_Click(object sender, EventArgs e)
        {
            Label13.Visible = false;
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            string method = populateCategoryTitles(ashTest1[1], ashTest1[2]);


            string ashTry = cardList.SelectedValue;
            string[] ashTry1 = ashTry.Split('-');

            string method1 = populateCardData(ashTest1[1] + ashTest1[2], ashTry1[1]);
            string imageOneID = ashTest1[1] + ashTest1[2] + "-" + ashTry1[1];
            //Then calls the method to obtain the blob image and put it into the image holder
            string callMethod1 = PopulateBlob1(imageOneID);
            blobImage.Visible = true;
            blobUpload.Visible = true;
            if(optionList.SelectedValue == "4")
            {
                updateCard.Visible = true;

            }

            if (optionList.SelectedValue == "6")
            {
                deleteCard.Visible = true;
            }


        }



        protected void updateCard_Click(object sender, EventArgs e)
        {
 
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            string method = populateCategoryTitles(ashTest1[1], ashTest1[2]);

            string ashTry = cardList.SelectedValue;
            string[] ashTry1 = ashTry.Split('-');
            CloudTable myMessagesCloudTable = GetTable("CardTable");
            // Create a retrieve operation that takes a category entity.
            TableOperation retrieveOperation = TableOperation.Retrieve<CardEntity>(ashTest1[1] + ashTest1[2], ashTry1[1]);
            // Execute the operation.
            TableResult retrievedResult = myMessagesCloudTable.Execute(retrieveOperation);
            // Assign the result to a CustomerEntity object.
            CardEntity updateEntity = (CardEntity)retrievedResult.Result;
            // Transfer the textbox entries 
            updateEntity.AttributeOne = attributeOneTxtBox.Text;
            updateEntity.AttributeTwo = attributeTwoTxtBox.Text;
            updateEntity.AttributeThree = attributeThreeTxtBox.Text;
            updateEntity.AttributeFour = attributeFourTxtBox.Text;
            updateEntity.AttributeFive = attributeFiveTxtBox.Text;
            updateEntity.Name = nameTxtBox.Text;



            if (blobUpload.HasFile)
            {
                CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
                CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(ashTest1[1] + ashTest1[2] + "-" + ashTry1[1]);
                myBlobIdentity.Delete();
                myBlobIdentity.UploadFromStream(blobUpload.FileContent);
            }

            // Create the Replace TableOperation.
            TableOperation updateOperation = TableOperation.Replace(updateEntity);

            // Execute the operation.
            myMessagesCloudTable.Execute(updateOperation);

            // Clear the screen
            string method1 = ClearTextBoxes();
            blobImage.ImageUrl="";
            blobImage.Visible = false;
            cardList.Items.Clear();
            string method2 = ListAllCards(ashTest1[1] + ashTest1[2]);
            Label13.Visible = true;
            Label13.Text = "Card Updated";


        }

        protected void deleteCategory_Click(object sender, EventArgs e)
        {
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            CloudTable myMessagesCloudTable = GetTable("CategoryTable");
            // Create a retrieve operation that takes a category entity.
            TableOperation retrieveOperation = TableOperation.Retrieve<CategoryEntity>(ashTest1[1], ashTest1[2]);
            // Execute the operation.
            TableResult retrievedResult = myMessagesCloudTable.Execute(retrieveOperation);
            // Assign the result to a CustomerEntity object.
            CategoryEntity updateEntity = (CategoryEntity)retrievedResult.Result;
            // Create the Delete TableOperation.
            TableOperation deleteOperation = TableOperation.Delete(updateEntity);
            // Execute the operation.
            myMessagesCloudTable.Execute(deleteOperation);



            //Once category is gone the associated cards and blobs need to go too they are also deleted
            CloudTable getCategoryTable = GetTable("CardTable");
            TableQuery<CardEntity> query = new TableQuery<CardEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, ashTest1[1] + ashTest1[2]));
            foreach (CardEntity entity in getCategoryTable.ExecuteQuery(query))
            {
                CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
                CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(entity.PartitionKey + "-" + entity.RowKey);
                myBlobIdentity.Delete();
                // Create the Replace TableOperation.
                TableOperation deleteOperation1 = TableOperation.Delete(entity);
                // Execute the operation.
                getCategoryTable.Execute(deleteOperation1);

            }



            // Clear the screen
            string method = ClearTextBoxes();
            categoryList.Items.Clear();
            string method2 = ListAllCategories();
            Label13.Visible = true;
            Label13.Text = "Category Deleted";
                   



        }

        protected void deleteCard_Click(object sender, EventArgs e)
        {
            string ashTest = categoryList.SelectedValue;
            string[] ashTest1 = ashTest.Split('-');
            string method = populateCategoryTitles(ashTest1[1], ashTest1[2]);

            string ashTry = cardList.SelectedValue;
            string[] ashTry1 = ashTry.Split('-');
            CloudTable myMessagesCloudTable = GetTable("CardTable");
            // Create a retrieve operation that takes a category entity.
            TableOperation retrieveOperation = TableOperation.Retrieve<CardEntity>(ashTest1[1] + ashTest1[2], ashTry1[1]);
            // Execute the operation.
            TableResult retrievedResult = myMessagesCloudTable.Execute(retrieveOperation);
            // Assign the result to a CustomerEntity object.
            CardEntity updateEntity = (CardEntity)retrievedResult.Result;



            CloudBlobContainer myBlobContainer = GetImagesBlobContainer();
            CloudBlockBlob myBlobIdentity = myBlobContainer.GetBlockBlobReference(ashTest1[1] + ashTest1[2] + "-" + ashTry1[1]);
            myBlobIdentity.Delete();


            // Create the Replace TableOperation.
            TableOperation deleteOperation = TableOperation.Delete(updateEntity);

            // Execute the operation.
            myMessagesCloudTable.Execute(deleteOperation);

            // Clear the screen
            string method1 = ClearTextBoxes();
            blobImage.Visible = false;
            cardList.Items.Clear();
            string method2 = ListAllCards(ashTest1[1] + ashTest1[2]);
            Label13.Visible = true;
            Label13.Text = "Card Deleted";


        }

        public IEnumerable<CardEntity> GetCategories()
        {

            // Get Cloud Table object for Messages Table.
            CloudTable myPlayersCloudTable = GetTable("CardTable");


            // Create a Table Query object.
            TableQuery<CardEntity> myTableQuery = new TableQuery<CardEntity>();


            // Get list from Messages Table.
            IEnumerable<CardEntity> messagesList =
            myPlayersCloudTable.ExecuteQuery(myTableQuery);


            // Sort in reverse chronological order.
            messagesList = messagesList.OrderByDescending(msg => msg.Timestamp);

            // Output to data list on web form.
            return messagesList;

        }

    }


}
