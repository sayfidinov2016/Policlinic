   M S B A M L   `   `   `  ????E  APoliclinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Policlinic.Patient.MenuPatientPoliclinic.Patient.MenuPatient  5   	   4    .Policlinic.Patient.MenuPatient.menuPatientForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Policlinic.Patient.MenuPatient     5   	     ? Title$  Пациент??5   	   $	??450??6   $	??800??6&   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $??5* ?6   .+?5   
   ? .+?5      ?? -   5         ??Name$ LastnameTxt??5      $
??auto??5      
???????$??10q?5       ?? 
IsReadOnly . 5      ?? 5      -   5        $ NameTxt??5      $
??auto??5      
???????$??10q?5       . 5      ?? 5      -   5        $ PatronymicTxt??5      $
??auto??5      
???????$??10q?5       . 5      ?? 5      -   5        $ DateOfBirthTxt??5      $
??auto??5       
???????$??
30 10 5 10q?5"      ?? 5#      $??Normal"?6   $??15(?6(   .??66   
года6<   5$      ?? 5%   
   -   5         ??Name$ ExitForm??5%      $??Right=?5&      $??5q?5'      $
??auto??5(      $
??auto??6   $??
Выйти??5)      5*       ? 5,   
   -   5          ?Name$ PatientFrame??5,      $??2??5-      $??5q?5.        ? NavigationUIVisibility$ Hidden=?5/      50      51      