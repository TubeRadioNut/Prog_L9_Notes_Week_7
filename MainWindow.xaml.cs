using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_L9_Notes_Week_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this and keep it at the top of MainWindow()
        }//end of MainWindow


        //Part 1
        private void btnPart1_Click(object sender, RoutedEventArgs e)
        {
            //display the return of FullOrder() method to the label
            lblDisplayInfo.Content = FullOrder();
        }
        //Create the Toppings() method that returns a string
        public string Toppings()
        {
            //check box
            string toppings = "";
            CheckBox sausage = chkSausage;
            bool isSausage = (bool)sausage.IsChecked;

            if (isSausage)
            {
                //adding this line to our order string
                toppings += $"Pizza Has Sausage\n";
            }
            else
            {
                //Adding this line to our order string
                toppings += $"Pizza does not have Sausage\n";
            }

            //Ternary
            bool isPepperoni = (bool)chkPepperoni.IsChecked;
            //vaiable = condition ? if true : if fasle
            toppings += (isPepperoni) ? "Pizza has Pepperoni\n" : "Pizza does Not have Pepperoni\n";
            return toppings;
        }
        //Create the PizzaSize() method that returns a string
        public string PizzaSize()
        {
            //create a string variable to be displayed in the label
            string size = "";
            //Testing what Radio button is checked with if/else statements
            if ((bool)rbSmall.IsChecked)//If small pizza is checked
            {
                //Add to string
                size += "Size Small\n";
            }
            else if ((bool)rbMedium.IsChecked)//If medium pizza is checked
            {
                //Add to string
                size += "Size Medium\n";
            }
            else//If larage pizza is checked
            {
                //Add to string
                size += "Size Large\n";
            }
            //return the string varaible
            return size;
        }
        //Create the FullOrder() method that returns a string
        public string FullOrder()
        {

            //Craate string variable for Name of the pizza place
            string pizzaPlaceName = "Charles' Pizza Palace";
            //Create string variable to be displayed in the label
            string order = $"{pizzaPlaceName}\n\n";
            //Add the pizza size by calling PizzaSize method and add the retrurn to the string variable
            order += PizzaSize();
            //Add the pizza topping by calling Topping method and add the return to the string variable
            order += Toppings();
            //return string variable
            return order;
        }
        //Create the ChangeTheme() click event method
        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            //Create List of RadioButtons, name it themes and add the radio buttons to the list
            List<RadioButton> themes = new List<RadioButton>();
            themes.Add(rbWhite);
            themes.Add(rbBlack);
            themes.Add(rbRed);
            themes.Add(rbBlue);
            //Loop through List of radio buttons
            foreach(RadioButton rb in themes)
            {
                //Testing if a radio button is selected
                if (rb != null)
                {
                    //create string variable to hold content of selected radio button
                    string chosenColor = "";
                    //testing which radio button is selected and assigning the content of selected radio button to the string variable
                    if ((bool)rb.IsChecked)
                    {
                        chosenColor = rb.Content.ToString();
                    }
                    //testing what content of string variable matches color
                    if (chosenColor == "White")
                    {
                        //setting background color to selected content of radio button
                        canvasParent.Background = new SolidColorBrush(Colors.White);
                    }
                    else if (chosenColor == "Black")
                    {
                        //setting background color to selected content of radio button
                        canvasParent.Background = new SolidColorBrush(Colors.Black);
                    }
                    else if (chosenColor == "Red")
                    {
                        //setting background color to selected content of radio button
                        canvasParent.Background = new SolidColorBrush(Colors.Red);
                    }
                    else if (chosenColor == "Blue")
                    {
                        //setting background color to selected content of radio button
                        canvasParent.Background = new SolidColorBrush(Colors.Blue);
                    }
                }
                
            }
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            string orderName = txbOrderName.Text;
            bool isOvernight = cbIsOvernight.IsChecked == true;
            bool isPerishable = cbIsPerishable.IsChecked == true;

            Order newOrder = new Order(orderName, isOvernight, isPerishable);
            lblOrderlabel.Content = newOrder.ToString();
        }
    }//end of partial class
}//end of namespace