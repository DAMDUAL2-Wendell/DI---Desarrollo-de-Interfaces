   M S B A M L   `   `   `  ����a  ]ejercicio1.4_formularioConNavegadorWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:ejercicio1._4_formularioConNavegadorWeb'ejercicio1._4_formularioConNavegadorWeb  5   	   8    2ejercicio1._4_formularioConNavegadorWeb.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:ejercicio1._4_formularioConNavegadorWeb     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         estiloBoton �� 
TargetType �� Property �� Value �� 	Resources��%�  &	        �� 5
   
   " ��6$   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 1q�6'   �� 5       � ��$ 78��6&   �� 5       � ��$ 42��6'   �� 5       � ��$ 10q�6(   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�64    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 5��65   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��56* �6   �� 5      $
��283* �6   �� 5      $	��47* �6   �� 5      $	��18* �6    � ColumnDefinitions 5!   
   �� 5"      $	��45* �6   �� 5#      $
��555* �6   �� 5$      $	��88* �6   �� 5%      $	��83* �6   �� 5&      $	��29* �6   .+�5(   
   �� -   5         ��Name$	 url��5(      $��1��6   $��Center=�6/   $��1��6L   	 �� TextWrapping$
	 Wrap=�6Y   $��Center=�6m   $	��480��6�   $��18��6�   ���	#FF9A9A9A
���   �
�������6�   (  "System.Windows.Controls.WebBrowser  5)   
   -   5        
  Name$
 
webBrowser��5)      $��1��6)   $��2��69   $��3��6F   $��11,11,11,11q�6Z    J� OpacityMask
 �   �6o   �� 5*   
   -   5         ��Name$ 	btnCargar��5*      #��[  6$   $��2��6I   $��Cargar��6Y   $��1��6j   $��42��6�   $��4,0,6,0q�6�   �� 5+   
   -   5        $ btnRefrescar��5+      #��[  6'   $��3��6L   $��Refescar��6\   $��1��6o   $��42��6�   $��6,0,28,0q�6�   $��2��6�   $��Center=�6�   $��Center=�6�   �� 5,   
   -   5        $ btnAtras��5,      #��[  6#   $��2��6H   $��Atras��6X   $��3��6h   $��42��6�   $��4,0,6,0q�6�   �� 5-   
   -   5        $ btnAdelante��5-      #��[  6&   $��3��6K   $��Adelante��6[   $��3��6n   $��42��6�   $��6,0,28,0q�6�   $��2��6�   �� 5.   
   $��1��6   $
��URL:��6    $
��Left=�6/   $��26��6J   $��1��6V   $��Center=�6c   $��44��6~   �� 5/   
   -   5         ��Name$ 
rectangulo��5/      $��1��6(   $��Center=�68   
���   �$��	0,10,0,10q�6d   $��2��6w   $��2��6�   51      52      