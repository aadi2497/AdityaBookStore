Author Name: Aditya Patel
Project: AdityaBookStore - Theme - Slate
ID:0751432
-----------------------------------------

Date: 2022/11/08

0902: Project Created
0902: Project Pushed to Git
0905: Project Slides Reviwed.

0915: Bootstrap Changes - New Theme Added.
0920: New Theme Testing.
0924: Test Scussuful.
0925: Push Files to GIt(New Theme)

0935: New Css links added from CSS_JS.txt file.
0940: DropDown Added.
0943: Testing New Ui.
0945: Dropdown Not Working.
Issue: Code Was Not complete - didn't see the link first.
Resolve: data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" Missing code Added.

0947: Dropdown Working Error Solved.
0958: New Class Project Added.

1019:
Issue: Wrong nuget Install
Resolve: Microsoft.AspNetCore.Identity.EntityFrameworkCore Install.

1024:

Issue: Namespace Not Found 'ErrorViewModel'.
Resolve: using AdityaBookStore.Models.ViewModels; line added in HomeController.cs file.

1032:

Customer Area Added
Moved files into Customer Controller folders.

1033:

New Customer Area Added
Files Moved Into Customer Folder

Project reference Added in AdityaBooks.Utility of 

1043:

New Admin Area Added
Controller Folder deleted from the main project.

--------------------------------------------------------------------------------------------------------------------------

Date: 2022/11/10

0959:

Repo.. Clone to new Terminal.

Starting Assignment 2 Part 2.

Checking appsettings.json connection string.

1011:

Creating Migration... Changed Database Connection name.

Adding Migration using NuGet Manager Console.

Command Used: add-migration AddDefaultIdentityMigration
Issue: Project Target to add-migration is wrong.
Resolve: Changing Default Project from AdityaBookStore > AdityaBooks.DataAccess

1016:

Migration Added Successfully in AdityaBooks.DataAcess. ( namespace AdityaBooks.DataAccess.Migrations ).

1019:

Updating Database.
Command: update-database

1020: Database Update Completed.

Database Reviewd Done.

1053:

New Category Class Added.
New feild Id and Name and their validation.

New Migration Added in Database
command Used: add-migration AddCategoryToDb
Migration Addded : 20221110151625_AddDefaultIdentityMigration.cs
				20221110162518_AddCategoryToDb.cs	

1105:

Issue: Category is inaccessible due to its proctection level.
Resolve: Public word missing in Category Class after namespace.

1108:

Issue: The name 'AddCategoryToDb' is used by an existing migration.

*** Possible Solution 1: Remove/Delete Existing Migration and  Re-run the the migration.

Resolve: First remove the old migration using Command remove migration. Then re-run the add-migration Command.

1127: 

Updated Databse to add Categories in tables.



----------------------------------------------------------------------------------------------------------------------------------

Date : 2022/11/14

0937:
Downloaded Application to new TT.

0952:

Add more code lines to use Methods for CRUD.

1002:

New Class file created in Repository Folder - Repository.cs
Updating Respository.cs File.


1105:

Issue: Error in startup.cs file - Beacuse I messed up for name of the files.
Resolve: Remove all the UnitofWork file and rebuild the application.

1205:

ISP_Call.cs and SP_Call.cs File created.

--------------------------------------------------------------------------------------------------------------------------------------

Date : 2022/11/15

0832: 

Cloned project to new TT.

Soleving last night problem of UnitofWork.cs file
Problem Solved Bu recreating both files.
Updated Startup.cs file.

 
0845:
Push to GitHUb

0900:

Creating New Controller - CategoryController......

1112:

Issue: Table Body content not visible.
Resolve: Changed Bootstrap css then it works.

--------------------------------------------------------------------------------------------------------------------------------------

Date : 2022/11/22

0729:

Cloned project from Git to new Terminal

Issue: Nuget Package Not Found
Solve: Restore Nuget Package as this is new TT.

------------------------------------------------------------------------------------------------------------------------------------------------

Date : 2022/11/23

0731:
Started Assignment 2 - Part III - Section 1.

Step 1 Create CoverType.cs Completed in Model folder.
step 2 Add CoverType Respository Completed.

0732:

Adding new migration.

0745:

Errors..........

0800:

Break......

1007:

Issue:Migration was not adding in app.
Solve: Find some solution on web but they were not working then after long search found that I need to add "services.AddTransient<IUnitOfWork, UnitOfWork>();" this line in my startup and then All the build was succeeded.

Migration Added: 20221124030400_AddCoverTypeToDb.

1051:

CoverType Working Perfectly.

1101:

Product Object Added to Database.

Migration Added: 20221124035814_AddProductToDb.

1111:
Validation Migration: 20221124041000_AddValidationToProductToDb

1117:

Product Added to Repository
IProductRepository Added.

1118:

UnitofWork and IUnitofWork Updated For product reference

1147:

Error On Part PPT Slide 3...... Start from here....


-----------------------------------------------------------------------------------------------------------------------------------------------

Date 2022/11/24

Will Start From Last night error PPT slide 3...........