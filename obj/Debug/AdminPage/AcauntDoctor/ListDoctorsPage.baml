   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Policlinic.AdminPage.AcauntDoctor!Policlinic.AdminPage.AcauntDoctor  5      7    1Policlinic.AdminPage.AcauntDoctor.ListDoctorsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Policlinic.AdminPage.AcauntDoctor     5        N? Title$  ListDoctorsPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.5* ?6   ?? 5      $??3* ?6   ?? 5      $
??0.7* ?6   .+?5   
   ?? $
??auto??6   .??6   Список докторов6.   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DoctorsList??5      $??1??5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   ?? *	AllNAme+5   %     5      $ Дата рождение??6%   $	 150 5   %    5   %   ?? *DataOfBirth+5   %     5      $  Специальность??6%   $	 250 5   %    5   %   ?? *Specialty.Specialty1+5   %   5!      ? 5#   
   $??2??6   $??Center=?6!   .+?5$      ?? -   5         ??Name$ BackBtn??5$      $
??20 0q?5%      $??
Назад??5&      5'      ?? 5(      -   5        $ 	RemoveBtn??5(      $
??20 0q?5)      $??Удалить??5*      5+      ?? 5,      -   5        $ MoreDetailsBtn??5,      $
??20 0q?5-      $??Подробнее??5.      5/      ?? 50      -   5        $ 	ChangeBtn??50      $
??20 0q?51      $??Изменить??52      53      ?? 54      -   5        $ AddBtn??54      $
??20 0q?55      $??Довавить??56      57      58      59      5:      