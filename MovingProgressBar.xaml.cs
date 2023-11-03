using System;
using System.Windows;
using System.Windows.Controls;

namespace ProgressBarUCL
{
    /// <summary>
    /// Interaction logic for MovingProgressBar.xaml
    /// </summary>
    public partial class MovingProgressBar : UserControl
    {
        public MovingProgressBar()
        {
            InitializeComponent();
            ProgressBarValue = 0;
        }
        public double ProgressBarValue
        {
            get => (double)GetValue(ProgressBarValueProperty);
            set => SetValue(ProgressBarValueProperty, value);
        }

        public static readonly DependencyProperty ProgressBarValueProperty =
            DependencyProperty.Register(nameof(ProgressBarValue), typeof(double), typeof(MovingProgressBar));
    }
}
