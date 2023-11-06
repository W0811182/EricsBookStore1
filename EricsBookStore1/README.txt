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