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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Поделить на цвета(красный, зеленый....)
        //Найти тупые названия кнопок

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeKeyBackground(e.Key, Brushes.LightGreen);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeKeyBackground(e.Key, Brushes.White);
        }

        private void ChangeKeyBackground(Key key, Brush color)
        {
            var keyLabels = new Dictionary<Key, Border>
            {
                { Key.OemMinus, borderTire },
                { Key.OemTilde, borderOemTilde },
                { Key.D0, border0 },
                { Key.D1, border1 },
                { Key.D2, border2 },
                { Key.D3, border3 },
                { Key.D4, border4 },
                { Key.D5, border5 },
                { Key.D6, border6 },
                { Key.D7, border7 },
                { Key.D8, border8 },
                { Key.D9, border9 },
                { Key.Q, borderQ },
                { Key.W, borderW },
                { Key.E, borderE },
                { Key.R, borderR },
                { Key.T, borderT },
                { Key.Y, borderY },
                { Key.U, borderU },
                { Key.I, borderI },
                { Key.O, borderO },
                { Key.P, borderP },
                { Key.A, borderA },
                { Key.S, borderS },
                { Key.D, borderD },
                { Key.F, borderF },
                { Key.G, borderG },
                { Key.H, borderH },
                { Key.J, borderJ },
                { Key.K, borderK },
                { Key.L, borderL },
                { Key.Z, borderZ },
                { Key.X, borderX },
                { Key.C, borderC },
                { Key.V, borderV },
                { Key.B, borderB },
                { Key.N, borderN },
                { Key.M, borderM },
                { Key.Space, borderSpace },
                { Key.Enter, borderEnter },
                { Key.Back, borderBack },
                { Key.Tab, borderTab },
                { Key.CapsLock, borderCaps },
                { Key.LeftShift, borderShift },
                { Key.RightShift, borderShift2 },
                { Key.LeftCtrl, borderCrtl },
                { Key.RightCtrl, borderCrtl2 },
                { Key.LeftAlt, borderAlt },
                { Key.RightAlt, borderAlt2 },
                { Key.LWin, borderWin },
                { Key.RWin, borderWin2 },
            };

            if (keyLabels.TryGetValue(key, out var label))
            {
                label.Background = color;
            }







        }
    }
}
