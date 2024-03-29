﻿using Sergey.UI.Extension.Views;
using System.Windows;

namespace Sergey.UI.Extension.Dialogs
{
    /// <summary>
    /// Displays a message window, also known as a dialog box, which presents a message to the user
    /// </summary>
    public sealed class MessageBox
    {
        /// <summary>
        /// Displays a message box with the given text, title, buttons, and icon
        /// </summary>
        /// <param name="text">The text to display in the message box</param>
        /// <param name="caption">The text to display in the title bar of the message box</param>
        /// <param name="button">One of the <see cref="T:System.Windows.MessageBoxButtons"/> values that specifies which buttons to display in the message box</param>
        /// <param name="icon">One of the <see cref="T:System.Windows.MessageBoxIcon"/> values that specifies which icon to display in the message box</param>
        /// <returns>One of the <see cref="T:System.Windows.DialogResult"/> values</returns>
        public static MessageBoxResult Show(string text, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            MessageBoxWindow messageBox = new MessageBoxWindow(text, caption, button, icon);
            messageBox.ShowDialog();
            return messageBox.Result;
        }
    }
}
