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
using System.Windows.Shapes;
using AdminPresenterController.PointControl;

namespace AdminView.PointControl
{
    /// <summary>
    /// Interaction logic for PointControlView.xaml
    /// </summary>
    public partial class PointControlView : Window
    {
        public PointControlView()
        {
            InitializeComponent();
            DataContext = new PointControlViewModel();
        }

        private void icRefresh_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton != MouseButton.Left)
                return;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PointControlViewModel vm = DataContext as PointControlViewModel;
            vm.GetTeams();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PointControlViewModel vm = DataContext as PointControlViewModel;
            vm.SetPoint(dgTeam.SelectedItem as TeamViewModel);
        }
    }
}
