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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float baserec = float.Parse(txtbaserec.Text);
            float alturarec = float.Parse(txtalturarec.Text);
            float arearec = baserec * alturarec;
            lblarearec.Text = arearec.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float basetri = float.Parse(txtbasetri.Text);
            float alturatri = float.Parse(txtalturatri.Text);
            float areatri = basetri * alturatri;
            lblareatri.Text = areatri.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float radiocric = float.Parse(txtradiocirc.Text);
            float areacirc = (3.14f*radiocric)*radiocric;
            lblareacirc.Text = areacirc.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float basemayortrp = float.Parse(txtbasemayortrp.Text);
            float basemenortrp = float.Parse(txtbasemenortrp.Text);
            float alturatrp = float.Parse(txtalturatrp.Text);
            float arearec = (basemayortrp + basemenortrp)*alturatrp/2;
            lblarearec.Text = arearec.ToString();
        }
    }
}
