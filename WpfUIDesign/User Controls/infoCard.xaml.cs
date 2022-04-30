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

namespace WpfUIDesign.User_Controls
{
    /// <summary>
    /// Interaction logic for infoCard.xaml
    /// </summary>
    public partial class infoCard : UserControl
    {
        public infoCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(infoCard));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(infoCard));

        public FontAwesome.Sharp.IconChar Icon
        {
            get { return (FontAwesome.Sharp.IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesome.Sharp.IconChar), typeof(infoCard));

        public Color Background1
        {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }

        public static readonly DependencyProperty Background1Property = DependencyProperty.Register("Background1", typeof(Color), typeof(infoCard));

        public Color Background2
        {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }

        public static readonly DependencyProperty Background2Property = DependencyProperty.Register("Background2", typeof(Color), typeof(infoCard));

        public Color ElipseBackground1
        {
            get { return (Color)GetValue(ElipseBackground1Property); }
            set { SetValue(ElipseBackground1Property, value); }
        }

        public static readonly DependencyProperty ElipseBackground1Property = DependencyProperty.Register("ElipseBackground1", typeof(Color), typeof(infoCard));
        public Color ElipseBackground2
        {
            get { return (Color)GetValue(ElipseBackground2Property); }
            set { SetValue(ElipseBackground2Property, value); }
        }

        public static readonly DependencyProperty ElipseBackground2Property = DependencyProperty.Register("ElipseBackground2", typeof(Color), typeof(infoCard));

    }
}
