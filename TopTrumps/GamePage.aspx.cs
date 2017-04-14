using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TopTrumps


{


    public partial class GamePage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//This is needed to stop this code being called every time a button is clicked
            {
                Button3.Visible = false;
                Button1.Text = "well hello there";
                //viewstates and sessions appear to be a way of saving variables so they can be used once an event handler is clicked!!!
                //so would be created once a login has taken place as a way of recalling the user.

                //creates an instance of the class DealCards
                DealCards myCards = new DealCards();
                //calls the method GenerateCards to create the random pack of 20
                List<int> cards = myCards.GenerateCards();
                //creates two lists for each player's cards
                List<int> playerOneDeal = new List<int> { };
                List<int> playerTwoDeal = new List<int> { };
                //Then distributes the cards between Player1 and Player2
                int loopNo = cards.Count - 1;
                while (loopNo > -1)
                {
                    playerOneDeal.Add(cards[loopNo]);
                    loopNo = loopNo - 1;
                    playerTwoDeal.Add(cards[loopNo]);
                    loopNo = loopNo - 1;
                }

                //Creates session variables playerOneHand that are populated by the lists of the same name
                Session.Add("playerOneHand", playerOneDeal);
                Session.Add("playerTwoHand", playerTwoDeal);
               
                


                ListBox1.Items.Clear();
                ListBox2.Items.Clear();

                //string trumpGame;

                //Player Info
                //string player1Name;
                //string player2Name;
                //int player1CardsLeft;
                //int player2CardsLeft;

                //create an array to hold the cards

                //Do we have a list of topics 

                //This is the application data, and would in fact be in our azure tables.
                List<string> category = new List<string> { "Animals", "Top Speed(mph)", "Length(cm)", "Weight(kg)", "Food(kg/day)", "Lifespan" };
                List<string> cardOne = new List<string> { "1", "Monkey", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/monkey.jpg" };
                List<string> cardTwo = new List<string> { "2", "Kangaroo", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/kangaroo.jpg" };
                List<string> cardThree = new List<string> { "3", "Goat", "Picture", "1", "3", "5", "2", "4", "c:/Users/ashle/Pictures/goat.jpg" };
                List<string> cardFour = new List<string> { "4", "Elephant", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/elephant.jpg" };
                List<string> cardFive = new List<string> { "5", "Rabbit", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/rabbit.jpg" };
                List<string> cardSix = new List<string> { "6", "Giraffe", "Picture", "4", "5", "3", "2", "1", "c:/Users/ashle/Pictures/giraffe.jpg" };
                List<string> cardSeven = new List<string> { "7", "Hippo", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/hippo.jpg" };
                List<string> cardEight = new List<string> { "8", "Dog", "Picture", "5", "2", "4", "1", "3", "c:/Users/ashle/Pictures/dog.jpg" };
                List<string> cardNine = new List<string> { "9", "Sheep", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/sheep.jpg" };
                List<string> cardTen = new List<string> { "10", "Cow", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/cow.jpg" };
                List<string> cardEleven = new List<string> { "11", "Rhino", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/rhino.jpg" };
                List<string> cardTwelve = new List<string> { "12", "Shark", "Picture", "2", "3", "5", "1", "4", "c:/Users/ashle/Pictures/shark.jpg" };
                List<string> cardThirteen = new List<string> { "13", "Lion", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/lion.jpg" };
                List<string> cardFourteen = new List<string> { "14", "Horse", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/horse.jpg" };
                List<string> cardFifteen = new List<string> { "15", "Cat", "Picture", "4", "5", "1", "2", "3", "c:/Users/ashle/Pictures/cat.jpg" };
                List<string> cardSixteen = new List<string> { "16", "Mouse", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/mouse.jpg" };
                List<string> cardSeventeen = new List<string> { "17", "Crocodile", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/crocodile.jpg" };
                List<string> cardEighteen = new List<string> { "18", "Zebra", "Picture", "2", "3", "5", "4", "1", "c:/Users/ashle/Pictures/zebra.jpg" };
                List<string> cardNineteen = new List<string> { "19", "Penguin", "Picture", "1", "2", "3", "4", "5", "c:/Users/ashle/Pictures/penguin.jpg" };
                List<string> cardTwenty = new List<string> { "20", "Snake", "Picture", "5", "4", "3", "2", "1", "c:/Users/ashle/Pictures/snake.jpg" };

                //Then have a list of all the lists. So it is a list where each entry is itself a list
                List<List<string>> allTheCards = new List<List<string>> { cardOne, cardTwo, cardThree, cardFour, cardFive, cardSix, cardSeven, cardEight, cardNine, cardTen, cardEleven, cardTwelve, cardThirteen, cardFourteen, cardFifteen, cardSixteen, cardSeventeen, cardEighteen, cardNineteen, cardTwenty };
                Session.Add("allCards", allTheCards);
                Session.Add("gameCategory", category);

                List<string> theCategory = Session["gameCategory"] as List<string>;


                //This populates the names and categories based on the chosen topic      
                gameName.Text = theCategory[0];



                //attributeOneNamePlayerOne.Text = theCategory[1];
                //attributeTwoNamePlayerOne.Text = theCategory[2];
                //attributeThreeNamePlayerOne.Text = theCategory[3];
                //attributeFourNamePlayerOne.Text = theCategory[4];
                //attributeFiveNamePlayerOne.Text = theCategory[5];

                attributeOneNamePlayerTwo.Text = theCategory[1];
                attributeTwoNamePlayerTwo.Text = theCategory[2];
                attributeThreeNamePlayerTwo.Text = theCategory[3];
                attributeFourNamePlayerTwo.Text = theCategory[4];
                attributeFiveNamePlayerTwo.Text = theCategory[5];



                //This compares the identity number at the start of each card with the number in the Player's Hand 
                //and then if there is a match it then takes the data needed.
                List<int> playerOneHand = Session["playerOneHand"] as List<int>;
                List<int> playerTwoHand = Session["playerTwoHand"] as List<int>;
                List<List<string>> allCards = Session["allCards"] as List<List<string>>;

                foreach (List<string> subList in allCards)
                {

                    int checker = Convert.ToInt16(subList[0]);
                    if (checker == playerOneHand[0])
                    {
                        Image1.ImageUrl = Convert.ToString(subList[8]);
                        cardNamePlayerOne.Text = subList[1];
                        playerOneButtonOne.Text = theCategory[1] + "  |  " + Convert.ToString(subList[3]);
                        playerOneButtonTwo.Text = theCategory[2] + "  |  " + Convert.ToString(subList[4]);
                        playerOneButtonThree.Text = theCategory[3] + "  |  " + Convert.ToString(subList[5]);
                        playerOneButtonFour.Text =  theCategory[4] + "  |  " + Convert.ToString(subList[6]);
                        playerOneButtonFive.Text = theCategory[5] + "  |  " + Convert.ToString(subList[7]);
          

                    }
                    else { }
                }


                //Then does the same for player two
                foreach (List<string> subList in allCards)
                {
                    int checker = Convert.ToInt16(subList[0]);
                    if (checker == playerTwoHand[0])
                    {
                        Image2.ImageUrl = Convert.ToString(subList[8]);
                        cardNamePlayerTwo.Text = subList[1];
                        attributeOneValuePlayerTwo.Text = Convert.ToString(subList[3]);
                        attributeTwoValuePlayerTwo.Text = Convert.ToString(subList[4]);
                        attributeThreeValuePlayerTwo.Text = Convert.ToString(subList[5]);
                        attributeFourValuePlayerTwo.Text = Convert.ToString(subList[6]);
                        attributeFiveValuePlayerTwo.Text = Convert.ToString(subList[7]);
                    }
                    else { }
                }


                //This puts the 'cards' in each players hand into the listboxes, so we can check it is working
                foreach (int t in playerOneHand)
                {
                    ListBox1.Items.Add(Convert.ToString(t));
                }

                foreach (int t in playerTwoHand)
                {
                    ListBox2.Items.Add(Convert.ToString(t));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //PlayerOneWins
            Label1.Text = "PLAYER 1 WINS";
            //First declare new lists playerOne and playerTwo updates and assign them to the session values for the hands
            List<int> playerOneUpdate = Session["playerOneHand"] as List<int>;
            List<int> playerTwoUpdate = Session["playerTwoHand"] as List<int>;
            //Take the first card for both playerOne and playerTwo
            int firstCard = playerOneUpdate[0];
            int secondCard = playerTwoUpdate[0];
            //Remove the first card from the list of playerOne and playerTwo
            playerOneUpdate.RemoveAt(0);
            playerTwoUpdate.RemoveAt(0);
            //Add each card to the back of playerOne's deck
            playerOneUpdate.Add(firstCard);
            playerOneUpdate.Add(secondCard);
            //Cleans the playerOneHand and playerTwoHand sessions
            Session.Remove("playerOneHand");
            Session.Remove("playerTwoHand");
            //Updates the sessions with the new decks.
            Session.Add("playerOneHand", playerOneUpdate);
            Session.Add("playerTwoHand", playerTwoUpdate);
            //It clears then updates the output box
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            foreach (int t in playerOneUpdate)
            {
                ListBox1.Items.Add(Convert.ToString(t));
            }

            foreach (int t in playerTwoUpdate)
            {
                ListBox2.Items.Add(Convert.ToString(t));
            }

            List<List<string>> allCards = Session["allCards"] as List<List<string>>;
            //Finally repopulates the textboxes with the next cards
            foreach (List<string> subList in allCards)
            {
                List<int> playerOneHand = Session["playerOneHand"] as List<int>;
                int checker = Convert.ToInt16(subList[0]);
                if (checker == playerOneHand[0])
                {
                    cardNamePlayerOne.Text = subList[1];
                    Image1.ImageUrl = Convert.ToString(subList[8]);
                    //attributeOneValuePlayerOne.Text = Convert.ToString(subList[3]);
                    //attributeTwoValuePlayerOne.Text = Convert.ToString(subList[4]);
                    //attributeThreeValuePlayerOne.Text = Convert.ToString(subList[5]);
                    //attributeFourValuePlayerOne.Text = Convert.ToString(subList[6]);
                    //attributeFiveValuePlayerOne.Text = Convert.ToString(subList[7]);
                }
                else { }
            }
            //Then does the same for player two
            foreach (List<string> subList in allCards)
            {
                List<int> playerTwoHand = Session["playerTwoHand"] as List<int>;
                int checker = Convert.ToInt16(subList[0]);
                if (checker == playerTwoHand[0])
                {
                    cardNamePlayerTwo.Text = subList[1];
                    Image2.ImageUrl = Convert.ToString(subList[8]);
                    attributeOneValuePlayerTwo.Text = Convert.ToString(subList[3]);
                    attributeTwoValuePlayerTwo.Text = Convert.ToString(subList[4]);
                    attributeThreeValuePlayerTwo.Text = Convert.ToString(subList[5]);
                    attributeFourValuePlayerTwo.Text = Convert.ToString(subList[6]);
                    attributeFiveValuePlayerTwo.Text = Convert.ToString(subList[7]);
                }
                else { }
            }

            Button3.Visible = true;


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Visible = false;

        }
    }


}

