   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Policlinic.AdminPage.AcauntPatient"Policlinic.AdminPage.AcauntPatient  5      9    3Policlinic.AdminPage.AcauntPatient.ListPatientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Policlinic.AdminPage.AcauntPatient     5        N? Title$%  Список пациентов??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.5* ?6   ?? 5      $??3* ?6   ?? 5      $
??0.7* ?6   .+?5   
   ?? $
??auto??6   .??6   !Список пациентов6/   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PatientsList??5      $??1??5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   ?? *FIO+5   %     5      $ Дата рождение??6%   $ * 5   %    5   %   ?? *DateOfBirth+5   %   5      ? 5    
   $??2??6   $??Center=?6!   .+?5!      ?? -   5         ??Name$ BackBtn??5!      $
??20 0q?5"      $??
Назад??5#      5$      ?? 5%      -   5        $ 	RemoveBtn??5%      $
??20 0q?5&      $??Удалить??5'      5(      ?? 5)      -   5        $ MoreDetailsBtn??5)      $
??20 0q?5*      $??Подробнее??5+      5,      ?? 5.      -   5        $ 	ChangeBtn??5.      $
??20 0q?5/      $??Изменить??50      51      ?? 52      -   5        $ AddBtn??52      $
??20 0q?53      $??Довавить??54      55      56      57      58      