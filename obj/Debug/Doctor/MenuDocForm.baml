   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Policlinic.DoctorPoliclinic.Doctor  5   	   #    Policlinic.Doctor.MenuDocForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Policlinic.Doctor     5   	     ? Title$  Врач??5   	   $	??450??6   $	??800??6#   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $??5* ?6   .+?5      ?? $??1??6   .+?5      ? .+?5      ?? -   5         ??Name$ LastnameTxt??5      $
??auto??5      $??10q?5       ?? 
IsReadOnly . 
???????5      ?? 5      -   5        $ NameTxt??5      $
??auto??5      $??10q?5       . 
???????5      ?? 5      -   5        $ PatronymicTxt??5      $
??auto??5      $??10q?5       . 
???????5       ?? 5!      -   5        $ SpecialtyTxt??5!      $
??auto??5"      $??	20 0 0 0 q?5#      $??15(?5$      
???????$
??Left=?5&      
??????? . 5(      5)      5+      ?? 5-   
   -   5         ??Name$ ExitForm??5-      $
??auto??5.      $
??auto??6"   $??Right=?5/      $??5q?50      $??
Выйти??51      52       ? 54   
   -   5          ?Name$ DoctorFrame??55      $??1??54      $??5q?56        ? NavigationUIVisibility$ Hidden=?57      58      59      