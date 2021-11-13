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

namespace föreläsning11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Exercise exercise; //skapar en exercise
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            exercise = new Exercise() //ordet new är viktigt, man skapar något nytt
            {
                Name = "22b"
            };
            shape shape = shapeFactory.CreateShape("Rectangle", 7, 8);  //tydligen detta med harrypottter lösenordet
            if (shape == null)
            {
                MessageBox.Show("Kunde inte skapa figuren");
            }
            exercise.shapes.Add(shape);
            
            //uppgift 22b
            Rectangle rectangle = new Rectangle
            {
                Heighth = 7,
                Width = 8
            };

            exercise.shapes.Add(rectangle); //tar nåt från exercise, osäker på vad
            Triangle triangle = new Triangle
            {
                Heighth = 8,
                Width =6
            };
            exercise.shapes.Add(rectangle);
            //här skapar jag ett objekt från föräldern
            shape shape = new shape()
            {
                Type = "Rectangle",
                Heighth = 23,
                Width = 33
            };

            Square square = new Square
            {
                Heighth = 3,
                Width = 3
            };

            /*double totalArea = rectangle.CalculateArea() + triangle.CalculateArea();*//* + square.CalculateArea();*/
            double toatalArea = exercise.CalculateTotalArea();
            Test(exercise);
        }
        private void Test(Exercise exercise) 
        { 
        
        }

    }
}
