﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sergey.UI.Extension.Views
{
    /// <summary>
    /// Логика взаимодействия для MessageBoxWindow.xaml
    /// </summary>
    public partial class MessageBoxWindow : Window
    {
        public MessageBoxResult Result { get; private set; }

        private bool isClose = false;

        public MessageBoxWindow(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            InitializeComponent();
            Title = caption;
            textBlock_Message.Text = messageBoxText;
            switch (button)
            {
                case MessageBoxButton.OK:
                    button_OK.Visibility = Visibility.Visible;
                    isClose = true;
                    break;
                case MessageBoxButton.OKCancel:
                    button_OK.Visibility = Visibility.Visible;
                    button_Cansel.Visibility = Visibility.Visible;
                    isClose = true;
                    Result = MessageBoxResult.Cancel;
                    break;
                case MessageBoxButton.YesNo:
                    button_Yes.Visibility = Visibility.Visible;
                    button_No.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNoCancel:
                    button_Yes.Visibility = Visibility.Visible;
                    button_No.Visibility = Visibility.Visible;
                    button_Cansel.Visibility = Visibility.Visible;
                    isClose = true;
                    Result = MessageBoxResult.Cancel;
                    break;
            }
            switch (icon)
            {
                case MessageBoxImage.Error:
                    image_Icon.Source = new BitmapImage(new Uri("/Sergey.UI.Extension;component/Resources/Images/dialog-error-64.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Information:
                    image_Icon.Source = new BitmapImage(new Uri("/Sergey.UI.Extension;component/Resources/Images/dialog-information-64.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Question:
                    image_Icon.Source = new BitmapImage(new Uri("/Sergey.UI.Extension;component/Resources/Images/dialog-question-64.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Warning:
                    image_Icon.Source = new BitmapImage(new Uri("/Sergey.UI.Extension;component/Resources/Images/dialog-warning-64.png", UriKind.Relative));
                    break;
            }
        }

        private void Button_MBR_Click(object sender, RoutedEventArgs e)
        {
            string button = ((Button)sender).Tag.ToString();
            Result = (MessageBoxResult)Convert.ToInt32(button);
            isClose = true;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !isClose;
        }
    }
}
