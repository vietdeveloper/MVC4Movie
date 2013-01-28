This is my exercise based on Rick Andeson's tutorial at http://www.asp.net/mvc/tutorials/mvc-4/getting-started-with-aspnet-mvc4/intro-to-aspnet-mvc-4.

“Example isn't another way to teach, it is the only way to teach” - Albert Einstein.

Problem: Unable to complete operation. The supplied SqlConnection does not specify an initial catalog.
Solution: Add Initial Catalog="Movie" in connection string as
<add name ="MovieDBContext" connectionString="Data Source=(LocalDB)\v11.0;AttachDbFileName=|DataDirectory|\Movies.mdf;Initial Catalog=Movies;Integrated Security=True" providerName="System.Data.SqlClient"/>
