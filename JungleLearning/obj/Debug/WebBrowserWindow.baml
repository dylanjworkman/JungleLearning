   M S B A M L   `   `   `  ����I  EJungleLearning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JungleLearningJungleLearning  5   	   %    JungleLearning.WebBrowserWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JungleLearning     5   	     � Title$  WebBrowserWindow��5   	   $	��720��6"   $
��1280��6/    � 
ResizeMode$ NoResize=�6<   ���	#FF882FF6.��5	      � .+�5
   
   (  "System.Windows.Controls.WebBrowser  -   5        $��	MyBrowser��5
         Source$ https://www.google.com/?�6&   $
��Left=�6G   $	��644��6b   $	��Top=�6o   $
��1252��6�   $��	10,35,0,0q�6�   �� 5   
   -   5         ��Name$ backBtn��5      $��<<��6"   $
��Left=�65   $��10,5,0,0q�6P   $	��Top=�6b   $��35��6z   $��25��6�   6�   �� 5   
   -   5        $ fwdBtn��5      $��>>��6!   $
��Left=�64   $��50,5,0,0q�6O   $	��Top=�6a   $��35��6y   $��25��6�   6�   �� 5   
   -   5        $ 
refreshBTN��5      $��Refresh��6%   $
��Left=�67   $��90,5,0,0q�6R   $	��Top=�6d   $��42��6|   $��25��6�   6�   �� 5   
   -   5        $ btnHome��5      $
��Home��6"   $
��Left=�61   $��	137,5,0,0q�6L   $	��Top=�6_   $��40��6w   $��25��6�   6�   �� 5   
   -   5         ��Name$ boxSearchBar��5      $
��Left=�6(   $��25��6C   $��	269,5,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��938��6�   �� 5   
   -   5        $ btnGO��5      $��Search��6    $
��Left=�61   $��
1212,5,0,0q�6L   $	��Top=�6`   $��52��6x   $��25��6�   6�   �� 5   
   -   5         ��Name$ urlLabel��5      $
��URL:��6"   $
��Left=�61   $��	231,5,0,0q�6L   $	��Top=�6_   �� 5   
   -	   5        $ btnBBC��5      $��Bitesize��6!   $
��Left=�64   $��	182,5,0,0q�6O   $	��Top=�6b   $��49��6z   $��25��6�   6�   5      5      