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
            InitializeComponent();
        }//end of MainWindow


        //Part 1
        private void btnPart1_Click(object sender, RoutedEventArgs e)
        {
            
            
            
           
            
            
            //display Info
            lblDisplayInfo.Content = FullOrder();
        }

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

        public string PizzaSize()
        {
            string size = "";
            //Radio button
            if ((bool)rbSmall.IsChecked)//If small pizza is checked
            {
                size += "Size Small\n";
            }
            else if ((bool)rbMedium.IsChecked)//If medium pizza is checked
            {
                size += "Size Medium\n";
            }
            else//If larage pizza is checked
            {
                size += "Size Large\n";
            }
            return size;
        }

        public string FullOrder()
        {

            //Name of the pizza place
            
            
            string pizzaPlaceName = "Charles' Pizza Palace";

            string order = $"{pizzaPlaceName}\n\n";
            //the pizza size
            order += PizzaSize();
            //the toppings
            order += Toppings();

            return order;
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            List<RadioButton> themes = new List<RadioButton>();
            themes.Add(rbWhite);
            themes.Add(rbBlack);
            themes.Add(rbRed);
            themes.Add(rbBlue);

            foreach(RadioButton rb in themes)
            {
                if (rb != null)
                {
                    string chosenColor = rb.Content.ToString();
                    if (chosenColor == "White")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.White);
                    }
                    else if (chosenColor == "Black")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Black);
                    }
                    else if (chosenColor == "Bed")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Red);
                    }
                    else if (chosenColor == "Blue")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Blue);
                    }
                }
                
            }
        }
    }//end of partial class
}//end of namespace