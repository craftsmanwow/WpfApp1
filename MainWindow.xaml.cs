using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // void TextBox_MouseLeave(object sender, MouseEventArgs e)
            //{
            //    float Number_teeth = int.Parse(TextBox_Number_teeth.Text);
            //}

            


        }

        //public void M_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Modular = float.Parse(M.Text);


        //}

        //private void X_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float x1, x2, x3;
        //    x1 = float.Parse(M.Text);
        //    x2 = float.Parse(X.Text);
        //    ////x3 = float.Parse(TextBox3.Text);

        //    x3 = x1 * x2;
        //    Beta.Text = x3.ToString();           //x3.ToString(); //
        //}

        private void X_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            float x1, x2, x3, x4, x5;
            x1 = float.Parse(Mn.Text);
            x2 = float.Parse(X.Text);
            ////x3 = float.Parse(TextBox3.Text);

            x3 = x1 * x2;
            Beta.Text = x3.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x1, x2, x3, x4, x5;
            x1 = float.Parse(Mn.Text);
            x2 = float.Parse(X.Text);
            x3 = x1 * x2;
            x5 = double.Parse(Beta.Text);
            x4 = x1 / Math.Cos(x5 * Math.PI / 180.0);

            Mt.Text = Convert.ToString(x4);
            D.Text = x3.ToString();
            Da.Text = Convert.ToString(x4 * float.Parse(Z.Text) + 2 * x1 * (float.Parse(Ha.Text)));
            Df.Text = Convert.ToString(x4 * float.Parse(Z.Text) - 2 * x1 * (float.Parse(Ha.Text) + float.Parse(C.Text)));
            Db.Text = Convert.ToString(x4 * float.Parse(Z.Text) * Math.Cos(float.Parse(Alpha.Text) * Math.PI / 180.0));
            Ld.Text = Convert.ToString(x4 * float.Parse(Z.Text) * Math.PI / Math.Tan(x5 *Math.PI / 180.0));

        }

        //private void TextBox_Number_teeth_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    int Number_teeth = int .Parse(TextBox_Number_teeth.Text);
        //}

        //private void TextBox_Pressure_angle_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Pressure_angle = float.Parse(TextBox_Pressure_angle.Text);
        //}

        //private void TextBox_Helix_angle_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Helix_angle = float.Parse(TextBox_Helix_angle.Text);
        //}

        //private void TextBox_Coefficient_addendum_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Coefficient_addendum = float.Parse(TextBox_Coefficient_addendum.Text);
        //}

        //private void TextBox_Coefficient_clearance_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Coefficient_clearance = float.Parse(TextBox_Coefficient_clearance.Text);
        //}

        //public void TextBox_Modification_coefficient_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    float Modification_coefficient = float.Parse(Modification_coefficient.Text);
        //    double m = float.Parse(TextBox_Modular.Text);
        //    double m1 = Modification_coefficient * m;
        //    //this.TextBox_Modification_distance.Text = Convert.ToString(m1);
        //    string MZ = Convert.ToString(m1);
        //}
    }

    //public class CylindricalGear
    //{
    //    public Double Modular{ get; set; }
    //    public int    Number_teeth { get; set; }
    //    public Double Pressure_angle { get; set; }
    //    public Double Helix_angle { get; set; }
    //    public Double Coefficient_addendum { get; set; }
    //    public Double Coefficient_clearance { get; set; }
    //    public Double Modification_coefficient { get; set; }
    //    public Double Modification_distance { get; set; }
    //    public Double Tip_circle { get; set; }
    //    public Double Root_circle { get; set; }
    //    public Double Basic_circle { get; set; }
    //    public Double Lead { get; set; }

    // }

}
