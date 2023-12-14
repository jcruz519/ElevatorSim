using ElevatorSim.ViewModels;
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

namespace ElevatorSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextReader foo = new TextReader();
            foo.ReadInputFromFile(new System.IO.StreamReader("C:\\Users\\jerec\\Desktop\\Jeremy's Files (Windows)\\WorkSpace\\ElevatorSim\\ElevatorSim\\ElevatorSim\\bin\\Debug\\net8.0-windows7.0\\test.txt"));
        }
    }
}