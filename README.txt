This WinForms desktop project was created in VS 2015 (because that's what I have).
It includes an .mdf portable SQL Server database that should be populated and match the spreadsheet data.

I included a script that tears down (if necessary) and builds the entire database, including data, triggers and stored procedures
so should the database get lost or damaged, the script will rebuild it entirely.

The data, tables and fields in the script match exactly the requirements spreadsheet.

The trigger on the database (see DB script) automatically calculates GrossSalesAmount when the OrderDetail table is changed.

You should be able to run this to get the app to run:
\CarlisleProject\CarlisleMiniProject\CarlisleMiniProject\bin\Release\CarlisleMiniProject.exe

Source is located here:
\CarlisleProject\CarlisleMiniProject\CarlisleMiniProject.sln

Some improvements to make:
Further testing beyond the developer testing.
Better filtering, maybe some tools to make it easier to sort the grid by common sorts.
Paging of the grid, if necessary.
The calendar control for Req Ship Date is formatted and looks like, 20200602, It could have dashes in it for display, but it works.
Maybe the colors are bland, could be prettier.
Maybe a way to hide columns, or make them bigger.  I'm sure not all of the columns are necessary.
I question whether the database should have a calculated field (GrossSalesAmount).  That could be removed and only calculated when necessary.
a