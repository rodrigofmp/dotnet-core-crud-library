# LibraryAPI

## Instructions

1. Open solution with Microsoft Visual Studio community 2017 - Version 15.6.3.

2. Review database connection

*appsettings.json*

    "ConnectionStrings": {
        "DefaultConnection": "Server=.\\SQLEXPRESS;Database=librarydb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }

3. Review application URL

*launchSettings.json*

    "iisExpress": {
        "applicationUrl": "http://localhost:55729/",
        "sslPort": 0
    }
