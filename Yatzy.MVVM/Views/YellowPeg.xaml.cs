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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yatzy.MVVM
{
    /// <summary>
    /// Interaction logic for YellowPeg.xaml
    /// </summary>
    public partial class YellowPeg : MasterPeg
    {

        public YellowPeg()
        {
            InitializeComponent();
            CreatePeg();
        }

        private void CreatePeg()
        {
            Ellipse ellipse = new Ellipse
            {
                Fill = Brushes.Yellow,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            ColorIndex = 2;
            master.Children.Add(ellipse);
        }
    }
}
