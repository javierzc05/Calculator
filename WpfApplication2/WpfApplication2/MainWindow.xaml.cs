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

namespace WpfApplication2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller control;  

        public MainWindow()
        {
            InitializeComponent();
            control = new Controller(this);
        }

        void numberButtonClick(object sender, EventArgs e)
        {
            control.numberButtonClick(sender, e);
        }

        void operationButtonClick(object sender, EventArgs e)
        {
            control.operationButtonClick(sender, e);
        }

        void equalButtonClick(object sender, EventArgs e)
        {
            control.equalButtonClick();
        }

        void clearEntryButtonClick(object sender, EventArgs e)
        {
            control.clearEntryButtonClick();
        }

        void clearButtonClick(object sender, EventArgs e)
        {
            control.clearButtonClick();
        }

        void backspaceButtonClick(object sender, EventArgs e)
        {
            control.backspaceButtonClick();
        }

        void positiveNegativeButtonClick(object sender, EventArgs e)
        {
            control.positiveNegativeButtonClick();
        }

     
    }
}
