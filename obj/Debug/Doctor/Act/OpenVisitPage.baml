   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Policlinic.Doctor.ActPoliclinic.Doctor.Act  5      )    #Policlinic.Doctor.Act.OpenVisitPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Policlinic.Doctor.Act     5        N? Title$  OpenVisitPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??3* ?6   ?? 5      $??1* ?6   .+?5   
   ?  ? ColumnDefinitions 5      ?? 5      $??2* ?6#   ?? 5      $??1* ?6#   .+?5      ?? $??Запись??6   $	??Top=?5      ? 5      $??
10 30 10 0q?6   .+?5      ?? -   5         ??Name$ NameTxt??5      $
??auto??5      $	??5 0q?5      ?? 5      -   5        $ LastnameTxt??5      $
??auto??5       $	??5 0q?5!      ?? 5"      -   5        $ PatronymicTxt??5"      $
??auto??5#      $	??5 0q?5$      ?? 5%      -   5        $ DateOfBirthTxt??5%      $
??auto??5&      $	??5 0q?5'      5(      ?? 5*      $??0??6   $??1??5+      $??Right=?5,      $	??Top=?5-      $??10q?5.      .+?5/      ?? $??
Полис??6   
????  ?$??Right=?51      ?? 52      -   5        $ Polis??52      
????  ?$
??auto??54      $	??0 5q?55      $??Right=?56      57      58      ?? 5:   
   $??1??6   $??10q?5;      .+?5<      ?? $??Комментарий??6   $	??0 5q?5=      ?? 5>      -   5        $ 	ComentTxt??5>      $	??762??5?      $	??125??6"   5@      ? 5B   
   $??2??6   $??Center=?5C      .+?5D      ?? -   5         ??Name$ WriteBtn??5D      $??10q?5E      $??Больничный??5F      5G      ?? 5H      -   5        $ Exitbtn??5H      $??10q?5I      $??
Назад??5J      5K      ?? 5L      -	   5        $ DirectionBtn??5L      $??10q?5M      $??Направление??5N      5O      5P      5Q      5R      