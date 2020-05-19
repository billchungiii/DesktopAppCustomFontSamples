# DesktopAppCustomFontSamples
use custom fonts in desktop application  
(1) WindowsForms_CustomFontSample001 :  
add font file to Properties.Resources.resx  
set UI contols' UseCompatibleTextRendering porperty to true  
then create PrivateFontCollection and use it (see WindowsForms_CustomFontSample001 FontsProxy.cs and Form1.cs)  

(2) Wpf_CustomFontSample001 :  
add Fonts folder in project  
add font file to Fonts folder, setting file build action to Resource  
add resource to App.xaml's ResourceDictionary  
Using fonts : see MainWindow.xaml  
