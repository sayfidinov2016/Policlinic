   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Policlinic.AdminPage.FilialPoliclinic.AdminPage.Filial  5      ,    &Policlinic.AdminPage.Filial.FilialPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Policlinic.AdminPage.Filial     5        N? Title$  Фелиалы??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.5* ?6   ?? 5      $??3* ?6   ?? 5      $
??0.7* ?6   .+?5   
   ?? $
??auto??6   .??6   Фелиалы6&   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
FilialList??5      $??1??5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   ?? *Polyclinic_id+5   %     5      $ Название??6%   $	 10* 5   %    5   %   ?? *Name+5   %     5      $ 
Адрес??6%   $	 10* 5   %    5   %   ?? *	Address+5   %   5!      ? 5#   
   $??2??6   $??Center=?6!   .+?5$      ?? -   5         ??Name$ BackBtn??5$      $
??20 0q?5%      $??
Назад??5&      6%   ?? 5'      -   5        $ 	RemoveBtn??5'      $
??20 0q?6(   $??Удалить??66   6H   ?? 5(      -   5        $ 	ChangeBtn??5(      $
??20 0q?6(   $??Изменить??66   6I   ?? 5)      -   5        $ AddBtn??5)      $
??20 0q?6%   $??Довавить??63   6F   5*      5+      5,      