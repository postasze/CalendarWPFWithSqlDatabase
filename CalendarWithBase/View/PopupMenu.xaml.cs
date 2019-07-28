using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalendarWithBase.View
{
    /// <summary>
    /// Interaction logic for popupMenu.xaml
    /// </summary>
    public partial class PopupMenu : Window
    {
        public static bool active = false;
        private static int currentFontComboBoxSelectedIndex = 0;
        private static int currentColorComboBoxSelectedIndex = 0;

        public PopupMenu()
        {
            active = true;
            InitializeComponent();

            colorComboBox.Items.Add("Uklad kolorystyczny 1");
            colorComboBox.Items.Add("Uklad kolorystyczny 2");
            colorComboBox.Items.Add("Uklad kolorystyczny 3");

            colorComboBox.SelectedIndex = currentColorComboBoxSelectedIndex;

            fontComboBox.Items.Add("Seqoe UI");
            fontComboBox.Items.Add("Arial");
            fontComboBox.Items.Add("Times New Roman");
            fontComboBox.Items.Add("Calibri");

            fontComboBox.SelectedIndex = currentFontComboBoxSelectedIndex;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            active = false;
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (colorComboBox.SelectedIndex)
            { 
                case 0:
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().WindowColor = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().GeneralLabelColor = new SolidColorBrush(Color.FromRgb(198, 179, 255));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ButtonColor = new SolidColorBrush(Color.FromRgb(152, 230, 230));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DayLabelColor = new SolidColorBrush(Color.FromRgb(173, 235, 173));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().MarkedDayLabelColor = new SolidColorBrush(Color.FromRgb(255, 153, 153));
                    break;
                case 1:
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().WindowColor = new SolidColorBrush(Color.FromRgb(153, 0, 153));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().GeneralLabelColor = new SolidColorBrush(Color.FromRgb(255, 0, 255));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ButtonColor = new SolidColorBrush(Color.FromRgb(102, 153, 255));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DayLabelColor = new SolidColorBrush(Color.FromRgb(255, 153, 51));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().MarkedDayLabelColor = new SolidColorBrush(Color.FromRgb(153, 255, 204));
                    break;
                case 2:
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().WindowColor = new SolidColorBrush(Color.FromRgb(153, 204, 0));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().GeneralLabelColor = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ButtonColor = new SolidColorBrush(Color.FromRgb(204, 153, 0));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DayLabelColor = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().MarkedDayLabelColor = new SolidColorBrush(Color.FromRgb(204, 51, 255));
                    break;
            }
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().UpdateControlColors();
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().UpdateDayLabelBackgrounds();
            currentColorComboBoxSelectedIndex = colorComboBox.SelectedIndex;
        }

        private void fontComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().FontType = new FontFamily((String)fontComboBox.SelectedValue);
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().UpdateFontType();
            currentFontComboBoxSelectedIndex = fontComboBox.SelectedIndex;
        }
    }
}
