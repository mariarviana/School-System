   M S B A M L   `   `   `  ����I  ECadastroEscola, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CadastroEscola.ViewsCadastroEscola.Views  5   	   &     CadastroEscola.Views.ListarCurso   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CadastroEscola.Views     5   	     � Title$  ListarCurso��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��4 �6   �� 5      $��37 �6   �� 5      .+�5   
   �� $��1��6   .+�5      �� ���#8febab �� Padding$ 10q�5      $��18(�6%   �� 64    � Language$ pt-br�68   $�
Consultar ��6I   �� 6]   $�Curso��6a   6q   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   1   $��2��6   $��5,5,5,5q�6       
IsReadOnly .    AutoGenerateColumns .     AlternatingRowBackground �	#FFE5E5E5 �� AlternationCount$ 2��5   X   ���	#FFEBEBEB.@�5      0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6!   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6-   �� *Id+  5      $
	 Nome��6!   
 6/   �� *Nome+  5      $	 	Descricao��6!   
 64   �� *	Descricao+  5      $	 CargaHoraria��6!   
 67   �� *CargaHoraria+  5      $	 Turno��6!   
 60   �� *Turno+4  .System.Windows.Controls.DataGridTemplateColumn  5       $	 Ações��6%      CellTemplate 5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6%   .+�5$      �� -   5         � ToolTip$ Excluir Registro��5$   %   6@   5%      5&      5(      5)      5+      5,      