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

namespace MauiÜbung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid grid;
        Label label;
        Button button;
        WorkItem workItem;

        public MainWindow()
        {
            InitializeComponent();

            workItem = new WorkItem();
            BindingContext = workItem;

            grid = new Grid();
            {
                BackgroundColor = Colors.BlanchedAlmond,
                RowDefinitions =
                    {
                    new RowDefinition(),
                    new RowDefinition()
                    }
            };

            label = new Label();
            label.SetBinding(Label.TextProperty, "LabelText");

            grid.AddHandler(label, 0, 0);

            button = new Button();
            button.SetBinding(Button.TextProperty, "ButtonText");

            grid.Add(button, 0, 1);

            this.Content = grid;

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tabGestureRecognizer.Tapped += Button_Tap;
            button.GestureRecognizer.Add(tapGestureRecognizer);

        }
            private void Button_Tap(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                DisplayAlert("Achtung: Geschafft!", "Ich habe eine Funktion!", "Ok");
            }
        }


        }
    }
}
