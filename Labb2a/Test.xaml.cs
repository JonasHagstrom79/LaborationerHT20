using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Labb2a
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        Hogwarts hogwarts = new Hogwarts();
        public Test()
        {
            InitializeComponent();

            AddComboBox();



        }

        public void AddComboBox()
        {
            cboTest.Items.Add(hogwarts.Gryffindor);
            cboTest.Items.Add(hogwarts.Hufflepuff);
            cboTest.Items.Add(hogwarts.Slytherin);
            cboTest.Items.Add(hogwarts.Ravenclaw);


        }

    }

}
