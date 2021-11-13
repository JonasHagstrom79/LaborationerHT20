using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labb2b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename = "HarryPotter.json";
        Hogwarts hogwarts = new Hogwarts();        
        Wizard members;
        public static Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            AddComboBox();
            LabelMascot();            

        }
        /*List<Wizard> Warlock = new List<Wizard>();*/ //DÖP OM DENNA

        /// <summary>
        /// sätter maskot på elevhemmen
        /// </summary>
        public void LabelMascot() //göra private om den bara används här i mainwindow
        {
            lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;
        }

        /// <summary>
        /// metod att rensa textboxarna vid lösenordsbyte
        /// </summary>
        public void ClearUI() 
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtNewWizardName.Clear();
        }

        /// <summary>
        /// lägger in elevhemmen i comboboxen
        /// </summary>
        public void AddComboBox()
        {
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Add(hogwarts.Ravenclaw);
        }

        /// <summary>
        /// sparar listorna i HarryPotter.json @ bin/Debug/netcoreapp3.1
        /// </summary>
        public void SaveFile() 
        {
            FileHandler.Save(hogwarts, filename);
        }

        /// <summary>
        /// öppnar de sparade listorna från HarryPotter.json
        /// </summary>
        public void OpenFile()
        {
            hogwarts = FileHandler.Open<Hogwarts>("HarryPotter.json");
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members;
        }

        /// <summary>
        /// byter lösenord med comboboxen
        /// </summary>
        public void CboHousePasswordChange()
        {
            string currentPassword = txtOldPassword.Text.ToString(); //Hämtar rätt lösenord direkt (Ska vara en metod som returnerar true eller false(är rätt tror jag))
            string newPassword = txtNewPassword.Text.ToString();

            if (cboHouses.SelectedIndex == 0)
            {
                if(hogwarts.Gryffindor.SetPassword(currentPassword, newPassword))                
                {
                    MessageBox.Show("Ditt lösenord är nu ändrat!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden varandra, eller så har det nya lösenordet felaktigt format");
                }
            }
            else if (cboHouses.SelectedIndex == 1)
            {
                if (hogwarts.Hufflepuff.SetPassword(currentPassword, newPassword)) 
                {
                    MessageBox.Show("Ditt lösenord är nu ändrat!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden varandra, eller så har det nya lösenordet felaktigt format");
                }

            }
            else if (cboHouses.SelectedIndex == 2)
            {
                if (hogwarts.Slytherin.SetPassword(currentPassword, newPassword)) 
                {
                    MessageBox.Show("Ditt lösenord är nu ändrat!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden varandra, eller så har det nya lösenordet felaktigt format");
                }
            }
            else if (cboHouses.SelectedIndex == 3)
            {
                if (hogwarts.Ravenclaw.SetPassword(currentPassword, newPassword)) 
                {
                    MessageBox.Show("Ditt lösenord är nu ändrat!");
                }
                else
                {
                    MessageBox.Show("Antingen matchar inte lösenorden varandra, eller så har det nya lösenordet felaktigt format");
                }
            }
            

        }
                
        private void cboHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //behövs nog inte
        }

        /// <summary>
        /// metod som uppdaterar listorna med trollkarlar
        /// </summary>
        private void UpdateLists() 
        {
            lstHufflepuff.ItemsSource = null;
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
            lstGryffindor.ItemsSource = null;
            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members;
            lstRavenclaw.ItemsSource = null;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;
            lstSlytherin.ItemsSource = null;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members;
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            CboHousePasswordChange();                        
            ClearUI();            
        }                    

        /// <summary>
        /// metod som visar informationen om en nyskapad trollkarl
        /// </summary>
        public void WizardInformation()
        {
            
            txtName.Text = members.Name;
            chkDeatheater.IsChecked = members.DeathEater;
            chkArmy.IsChecked = members.DumbledoresArmy;

            ClearUI();
        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
            members = new Wizard() 
            {
                Name = txtNewWizardName.Text
            };

            House house = hogwarts.SortingHat(members); // Gör att messageboxen fungerar genom att kalla på house två gånger

            /*Warlock.Add(members);*/ //lägger till en person till listan på varje knapptryck
            UpdateLists();
            WizardInformation();
                        
            MessageBox.Show($"{members.Name} är numera medlem nummer {house.Members.Count} i {house}. Spöket {house.HouseGhost} kommer att ta väl hand om dig");//länkad till houseHouse                       
        }
                
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {            
            Wizard huff = (Wizard)lstHufflepuff.SelectedItem;//Benjamin gav tips på studiegruppen
            txtName.Text = huff.Name;
            chkDeatheater.IsChecked = huff.DeathEater;
            chkArmy.IsChecked = huff.DumbledoresArmy;          
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard raven = (Wizard)lstRavenclaw.SelectedItem;
            txtName.Text = raven.Name;
            chkDeatheater.IsChecked = raven.DeathEater;
            chkArmy.IsChecked = raven.DumbledoresArmy;
        }

        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard gryff = (Wizard)lstGryffindor.SelectedItem;
            txtName.Text = gryff.Name;
            chkDeatheater.IsChecked = gryff.DeathEater;
            chkArmy.IsChecked = gryff.DumbledoresArmy;
        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Wizard slyth = (Wizard)lstSlytherin.SelectedItem;
            txtName.Text = slyth.Name;
            chkDeatheater.IsChecked = slyth.DeathEater;
            chkArmy.IsChecked = slyth.DumbledoresArmy;
        }
    }
}
