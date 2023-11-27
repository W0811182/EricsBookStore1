Program Name: EricsBookStore
Program author: Eric Workman
Program Purpose: An ASP.NET MVC template project assignment using the .NET5.0 SDK about a fictional book store
Date: 2023-11-05

--2237--
Freshly created mvc project created now doing a first test run with IIS Express
First test run successful

--2241--
Now Creating a repository for my project and doing my initial commit and push

--2245--
Created my repository 'EricsBookStore1' and pushed to github
put debug breakpoints at lines 22 and 27 in 'HomeController.cs' and test ran

Now downloading a theme from bootswatch

--2249--
Selected the "slate" theme from bootsswatch.com and replaced the bootstrap.css file in wwwroot
swapping out the 'site.css' file with the one provided in the assignment2 files
changing the file name in (Views/shared/_Layout.cshtml(line 7))
changed 'navbar-light' to 'navbar-dark' and 'bg-white' to 'bg-primary'
Removed 'text-dark' from lines 22 and 25 
Adding additional properties to footer class ->"text-white-50 bg-primary"

--0012--
removing references to 'text-dark' in the 'loginPartial.cshtml' file
now running a test on IIS Express again
styling appropriately applied and 'text-dark' removed from the login/account buttons

--0022--
now adding 3rd party tools to the '-Layout.cshtml page(additional scripts and stylesheets)
CSS
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
SCRIPTS
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>

--0026--
now adding Dropdown with bootstrap in (Views\Shared\Layout.cshtml)
added dropdown onto navbar, testing with IIS Express to review this
changing 'dropdown' to 'Content management' on the navbar

--0046--
Creating new projects in the solution
EricsBooks.DataAccess
EricsBooks.Models
EricsBooks.Utility

Copying data folder and pasting into the dataAccess project- deleting original
Installing Microsoft.EntityFrameworkCore.Relational
				Microsoft.EntityFrameworkCore.sqlServer

packages installed, now deleting Migrations folder

--0052--
downloading Identity.EntityFrameworkCore to the project
modified namespace in ApplicationDbContext
deleting class1.cs files from all extra projects
building project 
3 succeeded 1 failed
moving the models folder into the Models Project

--0101--
Added references for the main project to DataAccess and Models Projects
renamed models folder to ViewModels
appended ViewModels to the end of EricsBookStore.Models in ErrorViewModel
building project

project still not building properly - error in Startup.cs
added use of EricsBooks.DataAccess.Data to the Startup.cs

--0107--
removed using statement in Startup.cs
corrected the @model in error.cshtml
corrected path in Error.cshtml.g.cs the same as in error.cshtml

--0114--
Created SD.cs a static details class in the Utility Project
modifying properties to make it static
adding project reference in the main project to the utility project
adding references to Models and Utility from the dataAccess project

--0118--
adding a Customers Area
changing startuo.cs routing "pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}""
moving the HomeController.cs to the Customers area and deleting the model and data folder out of the area
adding explicit definition that the controller is in the customer area
moved the Home folder into the Views folder
running application

runs without errors - styling gone

--0140--
copying _viewimport and _viewstart to the customer area
modifying viewstart to reflect the new path
running app once again

--0200--
Adding new admin area


PART 2
2023-11-06
--1815--
preparing for next set of instructions by building the solution
all builds successful (4/4) moving on to first instructions
Reviewing appsettings.json 
aspnet-EricsBookStore1-9B12F544-14AC-40F2-9816-F0C978BA99A3 <- default db in apsetting.json-
changing db to = EricsBookStore

adding migration with PMC with the name "AddDefaultIdentityMigration"
target proj doesnt match migration assembly error - must hange migration assembly in Startup.cs
Changed default project in the PMC to .DataAccess proj and added migration again successfully

--1926--
updated database successfully in the PMC 'update-database'
checked the sql server object explorer to verify the correct fies were added 
checking for errors and running project
successful test run

--1935--
created a new category model and migrated with db in the PMC console migration name: "AddCategoryToDb"

--1943--
updating new context file from category.cs Migration 'AddCategoryToDb'
Adding a new migration with the added part to the applicationdbcontext
deleted previous AddCategoryToDb and updated database - regenerating migration

--2002--
regenerated migration file AddCategoryToDb and updated database
confirming Category table in sql SOE and commiting to github

--2014--
added folder to DataAccess proj "Repository" and to Repository I added an "IRepository" folder
added an interface called "IRepository" to the folder of the same name
changed projc files of DataAccess to include new Folders added
altering IRepository.cs to do CRUD ops for Category class

--2020--
altered IRepository.cs and now implementing 
creating file Repository.cs to Repository folder
Implemented interface in Repository.cs
modifying code to create constructs and dependency Injection

--2050--
created two new files ICategoryRepository.cs and CategoryRepository in their respective folders
created interface within ICategoryRepository
modifying CategoryRepository file
modifiying ICategoryRepository interface

--2059--
Finished modifying CategoryRepository now going to build, fix any errors and push to github
2 succeeded build 2 up to date
test run successful - no errors - uploading to github

--2115--
created ISP_Call and SP_Call interface and class and put them in their respective folders
implemented interface
gave SP_Call methods functionality

--2135--
Created IUnitOfWork and UnitOfWork in their respective folders
edited both files
adding register in UnitOfWork to Startup.cs in the ConfigureServices methods

2023-11-13
--1801--
starting part 2.3
closing all open tabs
adding new 'CategoryController.cs' to Areas>Admin>Controllers
altering CategoryController.cs to use IUnitOfWork
adding Category folder to Areas>Views
adding new Razor view to the Category folder
replacing contents with assignment files
saving and running application

--2053--
moved Category link into example dropdown created in part 1
modifying index.cshtml in category to add the icons from font awesome
cutting added lines from last step and adding to javascript file provided
placed javascript file in wwwroot/js
added section to call and run javascript file in index.cshtml

--2109--
added IActionResult to Category Controller
Created Upsert View and added provided lines to it
created partial view _CreateAndBackToListButtons.cshtml in shared under views
modifying Upsert.cshtml to add model
adding asp-action to index.cshtml
Modifying Upsert.cshtml to include title var as title
added ssection call at the bottom of Upsert to validate input

--0103--
creating Upsert POST action method in categoryController.cs
adding void Save method to IUnitOfWork
removing _db.SaveChanges() method from CategoryRepository.cs

--0130--
After Test running I can successfully create and update category names
now adding API call for HTTPDelete in categoryController
implementing HTTPDelete with delete method inside category.js
added onclick event
now creating delete(url) function at the bottom of category.js

--0200--
Test running and checking for delete functionality working properly
Test run successful deleting categories functional

2023-11-19
--2343--
cleaning, building and test running solution before moving on with adding the cover type CRUD
adding CoverType.cs Model to Models folder with an id and name getter and setter (copy paste category.cs code and change to fit)

--2347--
created CoverTypeRepository.cs and ICoverTypeRepository.cs
added CoverType references to ApplicationDbContext and UnitOfWork files
now creating database migration for CoverType in PMC
added db migration: Add-Migration AddCoverTypeDb
migration timestamp = 20231120052611
Updating database and checking viewer to see if populated with new CoverType
CoverType present in SOE Viewer

--0031--
now adding CoverType to NavBar inside of dropdown
adding and creating CoverTypeController (identical to CategoryController in structure)

--0055-- 
Created covertype.js javascript file (Identical to Category js file)
created Index and Upsert views in newly created CoverType Folder in Views (identical to Category views)
test running

--0121--
created Product.cs in models project and populated with provided code
adding reference to product in applicationDbContext
adding migration for new Product db in PMC
"Add-Migration addProductToDb"
migration timestamp = "20231120062429"
updating database and reviewing SOE for product
Products table present in SOE

--2035--
Adding Product to Repository
Forgot Description field in Produt model, adding and migrating now
new migration "AddDescFieldToProductDb"
migration timestamp = "20231121014831"
adding Product Interface now
adding reference to Product in IUnitOfWork and UnitOfWork
test running
test run successful
commiting to github

--2100--
adding Controller for new Product model
creating viewmodel in viewmodels folder ProductVM
downloading Microsoft.AspNetCore.Mvc.ViewFeatures package
modifying ProductController (IActionResult calls to ProductVM)

--2139--
commenting out Upsert POST method and modifying API call to include the Category and CoverType Props
adding index view from the controller
Copying code from Category View and modified
Copying code for Category.js and modifying for Product.js 
changed references from category to product and altered the columns and column width.

--2218--
modifying _Layout.cshtml to add link to product
creating Upsert file under Product and grabbing files from assignment folder
adding new folder images/products in wwwroot


2023-11-26
-2038-
cleaning, building, test running Solution
searching for bug related to navigating to Product Page

--2149--
Potentially found the reason for bug

had public Category category { get; set; }

switched to --> public Category Category { get; set; }

creating migration for Product model update

--2225-
PMC: Add-Migration ProductModelUpdate
20231127032741_ProductModelUpdate

Runtime exception error on toList() methods seems to be fixed, Migration doesnt state any difference.
new errors upon product creation

DataTables warning: table id=tblData - 
	Requested unknown parameter 'price' for row 0, column 2. 
		For more information about this error, please see http://datatables.net/tn/4

2023-11-27
--1157--
Found source of table get "bug" - Browser cache not updating with changes to js file.
Now Moving on to displaying movies on my index page.
adding this line to my HomeController to display listed products on the home page.

--1200--
Commiting to github.
IEnumerable<Product> productlist = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
adding using statements in the home controller for access to IRepository file and models project
added private readonly to use _unitOfWork
instantiated unitOfWork in the public HomeController

Going to alter my home index and see if my changes to the controller display my products
products display minus the image going to investigate this.
Can't figure out why images won't load, tried looking at the table to see if it was atleast populating with URLs but I don't know where to look for this
SOE did not have what I needed seemingly

Commiting and pushing to github