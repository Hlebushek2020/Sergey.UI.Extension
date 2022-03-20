# Sergey.UI.Extension
## Contents
- [Dialogs](#dialogs)
  - [Classes](#classes)
- [Themes](#themes)
  - [Classes](#classes-1)
  - [Enums](#enums)
  - [Structures](#structures)
- [UIStyle.xaml](#uistylexaml)
  - [ControlTemplate with keys](#controltemplate-with-keys)
  - [Style with keys](#style-with-keys)
  - [Styles without keys](#styles-without-keys)
- [Other Resources](#other-resources)
  - [Themes](#themes-1)
## Dialogs
### Classes
Name|Description
-|-
MessageBox|Analogue of MessageBox from the standard library
## Themes
### Classes
Name|Description
-|-
ThemeUri|Contains constants for uniform theme resource identifiers and a method for obtaining such an identifier for a theme
### Enums
Name|Description
-|-
Theme|Contains the constants of all available themes
### Structures
Name|Description
-|-
DisplayTheme|Used to display the theme title in Russian
## UIStyle.xaml
Location: Resources/UIStyle.xaml  
Uri: /Sergey.UI.Extension;component/Resources/UIStyle.xaml
### ControlTemplate with keys
- MenuItem.SeparatorStyleKey
- MenuItem.TopLevelHeaderTemplateKey
- MenuItem.TopLevelItemTemplateKey
- MenuItem.SubmenuItemTemplateKey
- ComboBoxTextBox
- VerticalScrollBar
- HorizontalScrollBar
### Style with keys
- ComboBoxToggleButton
- OptionMarkFocusVisual
- FocusVisualRadius3
- FocusVisualRadius4
- FocusVisual
- ScrollBarThumb
- ScrollBarPageButton
- ButtonStyle
- IconButtonStyle
- MenuIconButtonStyle
- TextBlockStyle
- GridView.GridViewScrollViewerStyleKey
- GridViewColumnHeaderGripper
- GridViewColumnHeader
### Styles without keys
- Menu
- ContextMenu
- ComboBox
- ComboBoxItem
- ListBox
- ListBoxItem
- ScrollViewer
- GridSplitter
- TextBox
- PasswordBox
- CheckBox
- ProgressBar
- RichTextBox
- ListView
- ListViewItem
- GroupBox
## Other Resources
### Themes
- Light (Resources/Light.xaml)
- Dark (Resources/Dark.xaml)
