;#DropDB WebExample2EasyTest

#Application WebExample2.Win
#Application WebExample2.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef WebExample2.Win

*Action About...
 
*Action OK

#EndIf

#IfDef WebExample2.Web
*Action Navigation(My Details)
#EndIf
