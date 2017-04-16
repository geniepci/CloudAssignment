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
    
                string callMethod = RunGame();

            }
        }





        private string CheckWhoHasWon(int selection)
        {
            List<int> playerOneCard= Session["playerOneCard"] as List<int>;
            int playerOneValue = playerOneCard[selection];
            List<int> playerTwoCard = Session["playerTwoCard"] as List<int>;
            int playerTwoValue = playerTwoCard[selection];
            //Runs three checks - firstly that Player One is the winner
            if (playerOneValue > playerTwoValue)
            {
                string callMethodP1Wins = PlayerOneWins();
                Label1.Visible = true;
                Label1.Text = "Player 1 Wins";
                if (callMethodP1Wins == "playerOne")
                {
                    return "playerOne";
                }
                else
                {
                    return string.Empty;
                }

            }
          
            //Then checks if Player Two is the winner
            if (playerOneValue < playerTwoValue)
            {
                string callMethodP2Wins = PlayerTwoWins();
                Label1.Visible = true;
                Label1.Text = "Player 2 Wins";
                if (callMethodP2Wins == "playerTwo")
                {
                    return "playerTwo";
                }
                else
                {
                    return string.Empty;
                }
            }
            //Finally it checks if there has been a draw
            if (playerOneValue == playerTwoValue)
            {
                Label1.Text = "Draw";
                Label1.Visible = true;
                string callMethodDraw = Draw();
                return string.Empty;
            }
            else
            {
                return string.Empty;
            }            
        }


        private string PlayerOneWins()
        {
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
            //Then makes it Player One's turn
            Session.Remove("whoseTurn");
            Session.Add("whoseTurn", "playerOne");
            //This checks to see if Player Two has run out of cards and therefore Player One is the game winner as well
            if (playerTwoUpdate.Count == 0)
            {
                return "playerOne";
            }
            else
            {
                return string.Empty;
            }                     
        }

        private string PlayerTwoWins()
        {
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
            playerTwoUpdate.Add(secondCard);
            playerTwoUpdate.Add(firstCard);
            //Cleans the playerOneHand and playerTwoHand sessions
            Session.Remove("playerOneHand");
            Session.Remove("playerTwoHand");
            //Updates the sessions with the new decks.
            Session.Add("playerOneHand", playerOneUpdate);
            Session.Add("playerTwoHand", playerTwoUpdate);
            //Then makes it Player Two's turn
            Session.Remove("whoseTurn");
            Session.Add("whoseTurn", "playerTwo");
            //This checks to see if Player One has run out of cards and therefore Player Two is the game winner as well
            if (playerOneUpdate.Count == 0)
            {
                return "playerTwo";
            }
            else
            {
                return string.Empty;
            }
        }

        private string Draw()
        {
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
            playerTwoUpdate.Add(secondCard);
            //Cleans the playerOneHand and playerTwoHand sessions
            Session.Remove("playerOneHand");
            Session.Remove("playerTwoHand");
            //Updates the sessions with the new decks.
            Session.Add("playerOneHand", playerOneUpdate);
            Session.Add("playerTwoHand", playerTwoUpdate);

            return string.Empty;
        }

        private string DisableButtons()
        {
            //This simply stops the buttons being clicked again once selected
            playerOneButtonOne.Enabled = false;
            playerOneButtonTwo.Enabled = false;
            playerOneButtonThree.Enabled = false;
            playerOneButtonFour.Enabled = false;
            playerOneButtonFive.Enabled = false;
            playerTwoButtonOne.Enabled = false;
            playerTwoButtonTwo.Enabled = false;
            playerTwoButtonThree.Enabled = false;
            playerTwoButtonFour.Enabled = false;
            playerTwoButtonFive.Enabled = false;
            return string.Empty;
        }

        private string EnableButtons()
        {
            //This enables the buttons once again
            playerOneButtonOne.Enabled = true;
            playerOneButtonOne.BackColor = System.Drawing.Color.Empty;
            playerOneButtonOne.ForeColor = System.Drawing.Color.Empty;
            playerOneButtonTwo.Enabled = true;
            playerOneButtonTwo.BackColor = System.Drawing.Color.Empty;
            playerOneButtonTwo.ForeColor = System.Drawing.Color.Empty;
            playerOneButtonThree.Enabled = true;
            playerOneButtonThree.BackColor = System.Drawing.Color.Empty;
            playerOneButtonThree.ForeColor = System.Drawing.Color.Empty;
            playerOneButtonFour.Enabled = true;
            playerOneButtonFour.BackColor = System.Drawing.Color.Empty;
            playerOneButtonFour.ForeColor = System.Drawing.Color.Empty;
            playerOneButtonFive.Enabled = true;
            playerOneButtonFive.BackColor = System.Drawing.Color.Empty;
            playerOneButtonFive.ForeColor = System.Drawing.Color.Empty;
            playerTwoButtonOne.Enabled = true;
            playerTwoButtonOne.BackColor = System.Drawing.Color.Empty;
            playerTwoButtonOne.ForeColor = System.Drawing.Color.Empty;
            playerTwoButtonTwo.Enabled = true;
            playerTwoButtonTwo.BackColor = System.Drawing.Color.Empty;
            playerTwoButtonTwo.ForeColor = System.Drawing.Color.Empty;
            playerTwoButtonThree.Enabled = true;
            playerTwoButtonThree.BackColor = System.Drawing.Color.Empty;
            playerTwoButtonThree.ForeColor = System.Drawing.Color.Empty;
            playerTwoButtonFour.Enabled = true;
            playerTwoButtonFour.BackColor = System.Drawing.Color.Empty;
            playerTwoButtonFour.ForeColor = System.Drawing.Color.Empty;
            playerTwoButtonFive.Enabled = true;
            playerTwoButtonFive.BackColor = System.Drawing.Color.Empty;
            playerTwoButtonFive.ForeColor = System.Drawing.Color.Empty;
            return string.Empty;
        }

        private string EverythingVisible()
        {
            //This puts all images and buttons visible again
            Image1.Visible = true;
            Image2.Visible = true;
            cardNamePlayerOne.Visible = true;
            cardNamePlayerTwo.Visible = true;
            playerOneButtonOne.Visible = true;
            playerOneButtonTwo.Visible = true;
            playerOneButtonThree.Visible = true;
            playerOneButtonFour.Visible = true;
            playerOneButtonFive.Visible = true;
            playerTwoButtonOne.Visible = true;
            playerTwoButtonTwo.Visible = true;
            playerTwoButtonThree.Visible = true;
            playerTwoButtonFour.Visible = true;
            playerTwoButtonFive.Visible = true;
            return string.Empty;
        }

        private string PopulateTheScreeen()
        {
            //This compares the identity number at the start of each card with the number in the Player's Hand 
            //and then if there is a match it then takes the data needed.
            List<string> theCategory = Session["gameCategory"] as List<string>;
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
                    playerOneButtonFour.Text = theCategory[4] + "  |  " + Convert.ToString(subList[6]);
                    playerOneButtonFive.Text = theCategory[5] + "  |  " + Convert.ToString(subList[7]);
                    List<int> playerOneCard = new List<int> { Convert.ToInt16(subList[3]), Convert.ToInt16(subList[4]), Convert.ToInt16(subList[5]), Convert.ToInt16(subList[6]), Convert.ToInt16(subList[7]), };
                    Session.Add("playerOneCard", playerOneCard);


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
                    playerTwoButtonOne.Text = theCategory[1] + "  |  " + Convert.ToString(subList[3]);
                    playerTwoButtonTwo.Text = theCategory[2] + "  |  " + Convert.ToString(subList[4]);
                    playerTwoButtonThree.Text = theCategory[3] + "  |  " + Convert.ToString(subList[5]);
                    playerTwoButtonFour.Text = theCategory[4] + "  |  " + Convert.ToString(subList[6]);
                    playerTwoButtonFive.Text = theCategory[5] + "  |  " + Convert.ToString(subList[7]);
                    List<int> playerTwoCard = new List<int> { Convert.ToInt16(subList[3]), Convert.ToInt16(subList[4]), Convert.ToInt16(subList[5]), Convert.ToInt16(subList[6]), Convert.ToInt16(subList[7]), };
                    Session.Add("playerTwoCard", playerTwoCard);
                }
                else { }
            }


            //It then makes the non-player's cards invisible
            //First checking Player One
            string turn = Session["whoseTurn"] as string;
            if (turn == "playerOne")
            {
                Image2.Visible = false;
                cardNamePlayerTwo.Visible = false;
                playerTwoButtonOne.Visible = false;
                playerTwoButtonTwo.Visible = false;
                playerTwoButtonThree.Visible = false;
                playerTwoButtonFour.Visible = false;
                playerTwoButtonFive.Visible = false;
            }
            else { }
            //Then checking if it is Player Two
            if (turn == "playerTwo")
            {
                Image1.Visible = false;
                cardNamePlayerOne.Visible = false;
                playerOneButtonOne.Visible = false;
                playerOneButtonTwo.Visible = false;
                playerOneButtonThree.Visible = false;
                playerOneButtonFour.Visible = false;
                playerOneButtonFive.Visible = false;
            }
            else { }


            //It clears then updates the output box
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            //This puts the 'cards' in each players hand into the listboxes, so we can check it is working
            foreach (int t in playerOneHand)
            {
                ListBox1.Items.Add(Convert.ToString(t));
            }

            foreach (int t in playerTwoHand)
            {
                ListBox2.Items.Add(Convert.ToString(t));
            }
            return string.Empty;
        }

        protected void nextCard_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            nextCard.Visible = false;
            string callMethod = EnableButtons();
            string callMethod1 = PopulateTheScreeen();
        }

        protected void playerOneButtonOne_Click(object sender, EventArgs e)
        {

            //Calls the mether CheckWHoHasWon
            //This also checks if Player One is the overall winner
            //NB It is not possible to be the active player and lose in Top Trumps
            string theWinner = CheckWhoHasWon(0);
            if (theWinner == "playerOne")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER ONE IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonOne.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonOne.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonOne.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonOne.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }

        }

        protected void playerOneButtonTwo_Click(object sender, EventArgs e)
        {

            string theWinner = CheckWhoHasWon(1);
            if (theWinner == "playerOne")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER ONE IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonTwo.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonTwo.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonTwo.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonTwo.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }
            
        }

        protected void playerOneButtonThree_Click(object sender, EventArgs e)
        {

            string theWinner = CheckWhoHasWon(2);
            if (theWinner == "playerOne")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER ONE IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonThree.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonThree.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonThree.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonThree.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }

        }

        protected void playerOneButtonFour_Click(object sender, EventArgs e)
        {

            string theWinner = CheckWhoHasWon(3);
            if (theWinner == "playerOne")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER ONE IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonFour.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonFour.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonFour.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonFour.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }

        }

        protected void playerOneButtonFive_Click(object sender, EventArgs e)
        {

            string theWinner = CheckWhoHasWon(4);
            if (theWinner == "playerOne")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER ONE IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonFive.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonFive.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonFive.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonFive.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }

        }

        protected void playerTwoButtonOne_Click(object sender, EventArgs e)
        {
            //Calls the mether CheckWHoHasWon
            //This also checks if Player One is the overall winner
            //NB It is not possible to be the active player and lose in Top Trumps
            string theWinner = CheckWhoHasWon(0);
            if (theWinner == "playerTwo")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER TWO IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonOne.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonOne.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonOne.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonOne.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }
        }

        protected void playerTwoButtonTwo_Click(object sender, EventArgs e)
        {
            string theWinner = CheckWhoHasWon(1);
            if (theWinner == "playerTwo")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER TWO IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonTwo.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonTwo.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonTwo.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonTwo.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }
        }

        protected void playerTwoButtonThree_Click(object sender, EventArgs e)
        {
            string theWinner = CheckWhoHasWon(2);
            if (theWinner == "playerTwo")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER TWO IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonThree.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonThree.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonThree.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonThree.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }
        }

        protected void playerTwoButtonFour_Click(object sender, EventArgs e)
        {
            string theWinner = CheckWhoHasWon(3);
            if (theWinner == "playerTwo")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER TWO IS VICTORIOUS!!!!";
                playAgain.Visible = true;
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonFour.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonFour.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonFour.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonFour.ForeColor = System.Drawing.Color.Black;
                string callMethod3 = GameOver();
            }
        }

        protected void playerTwoButtonFive_Click(object sender, EventArgs e)
        {
            string theWinner = CheckWhoHasWon(4);
            if (theWinner == "playerTwo")
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                Label2.Text = "& PLAYER TWO IS VICTORIOUS!!!!";
                string callMethod3 = GameOver();
            }
            else
            {
                string callMethod1 = DisableButtons();
                string callMethod2 = EverythingVisible();
                playerOneButtonFive.BackColor = System.Drawing.Color.Yellow;
                playerOneButtonFive.ForeColor = System.Drawing.Color.Black;
                playerTwoButtonFive.BackColor = System.Drawing.Color.Yellow;
                playerTwoButtonFive.ForeColor = System.Drawing.Color.Black;
                nextCard.Visible = true;
            }
        }
        private string GameOver()
        {
            playAgain.Visible = true;
            return string.Empty;
        }

        private string RunGame()
        {
            //Hides next card as it only pops up when a card is selected
            nextCard.Visible = false;
            //Hides play again button as it only pops up when the game is over
            playAgain.Visible = false;
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
            Session.Add("whoseTurn", "playerOne");

            //This is the application data, and would in fact be in our azure tables.
            List<string> category = new List<string> { "Animals", "Top Speed(mph)", "Length(cm)", "Weight(kg)", "Food(kg/day)", "Lifespan" };
            List<string> cardOne = new List<string> { "1", "Monkey", "Picture", "1", "2", "3", "4", "5", "monkey.jpg" };
            List<string> cardTwo = new List<string> { "2", "Kangaroo", "Picture", "5", "4", "3", "2", "1", "kangaroo.jpg" };
            List<string> cardThree = new List<string> { "3", "Goat", "Picture", "1", "3", "5", "2", "4", "goat.jpg" };
            List<string> cardFour = new List<string> { "4", "Elephant", "Picture", "1", "2", "3", "4", "5", "elephant.jpg" };
            List<string> cardFive = new List<string> { "5", "Rabbit", "Picture", "5", "4", "3", "2", "1", "rabbit.jpg" };
            List<string> cardSix = new List<string> { "6", "Giraffe", "Picture", "4", "5", "3", "2", "1", "giraffe.jpg" };
            List<string> cardSeven = new List<string> { "7", "Hippo", "Picture", "1", "2", "3", "4", "5", "hippo.jpg" };
            List<string> cardEight = new List<string> { "8", "Dog", "Picture", "5", "2", "4", "1", "3", "dog.jpg" };
            List<string> cardNine = new List<string> { "9", "Sheep", "Picture", "5", "4", "3", "2", "1", "sheep.jpg" };
            List<string> cardTen = new List<string> { "10", "Cow", "Picture", "1", "2", "3", "4", "5", "cow.jpg" };
            List<string> cardEleven = new List<string> { "11", "Rhino", "Picture", "5", "4", "3", "2", "1", "rhino.jpg" };
            List<string> cardTwelve = new List<string> { "12", "Shark", "Picture", "2", "3", "5", "1", "4", "shark.jpg" };
            List<string> cardThirteen = new List<string> { "13", "Lion", "Picture", "1", "2", "3", "4", "5", "lion.jpg" };
            List<string> cardFourteen = new List<string> { "14", "Horse", "Picture", "5", "4", "3", "2", "1", "horse.jpg" };
            List<string> cardFifteen = new List<string> { "15", "Cat", "Picture", "4", "5", "1", "2", "3", "cat.jpg" };
            List<string> cardSixteen = new List<string> { "16", "Mouse", "Picture", "1", "2", "3", "4", "5", "mouse.jpg" };
            List<string> cardSeventeen = new List<string> { "17", "Crocodile", "Picture", "5", "4", "3", "2", "1", "crocodile.jpg" };
            List<string> cardEighteen = new List<string> { "18", "Zebra", "Picture", "2", "3", "5", "4", "1", "zebra.jpg" };
            List<string> cardNineteen = new List<string> { "19", "Penguin", "Picture", "1", "2", "3", "4", "5", "penguin.jpg" };
            List<string> cardTwenty = new List<string> { "20", "Snake", "Picture", "5", "4", "3", "2", "1", "snake.jpg" };

            //Then have a list of all the lists. So it is a list where each entry is itself a list
            List<List<string>> allTheCards = new List<List<string>> { cardOne, cardTwo, cardThree, cardFour, cardFive, cardSix, cardSeven, cardEight, cardNine, cardTen, cardEleven, cardTwelve, cardThirteen, cardFourteen, cardFifteen, cardSixteen, cardSeventeen, cardEighteen, cardNineteen, cardTwenty };
            Session.Add("allCards", allTheCards);
            Session.Add("gameCategory", category);
            gameName.Text = category[0];
            //This calls the PopulateTheScreen method    
            string callMethod = PopulateTheScreeen();
            return string.Empty;
        }

        protected void playAgain_Click(object sender, EventArgs e)
        {
            playAgain.Visible = false;
            Session.Remove("playerOneCard");
            Session.Remove("playerTwoCard");
            Session.Remove("playerOneHand");
            Session.Remove("playerTwoHand");
            Session.Remove("whoseTurn");
            Session.Remove("allCards");
            Session.Remove("gameCategory");
            Label1.Visible = false;
            Label2.Visible = false;
            string method = EnableButtons();
            string method1 = RunGame();
        }
    }
}

