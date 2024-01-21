# Freelancers

Freelancers is the Web App for demo purposes for interview session 

## Features

Users can view, create, edit and delete of freelancers 

## Tools

Software and Programming Language :
1. Visual Studio 2019
2. C# (ASP.Net MVC Core 2.0)
3. Microsoft SQL Server 2017
4. DataTable for table design view

## How it works

This web app use 2 ports and each port was assigned by following projects :

1. Project for Web Api  

   Web APIs are very useful in implementation of RESTFUL web services using .NET framework. When the client request the data, it will communicate through RESTFUL web services with **Get,Post,Put and Delete** request to Web API. Web API will send back the data to the client with **JSON** format.

2. Project for client-side  
It is used for present to show the result through web design. The user interaction in client-side will be sent to Web API for processing and return back the result with JSON format. The **JSON** format should be decrypt first before show it to the end user.

## Usage

1. **Entity Framework (EF)**  

I am using **Entity Framewwork (EF)** for accessing and alter the data in the database. 

For example:

  ```csharp
// For listing view of freelancers
public List<Employee> SelectAll()
{
	List<Employee> data = (from e in db.Employees
						   orderby e.UsernameID
						   select e).ToList();
	return data;


}
```

2. **Web API**

Web API is used for accessing and altering the data in the database. To accessing the data, the client should use with **Get,Post,Put** and **Delete** request.

For example :

  ```csharp
// get the Employee object
[HttpGet("{id}")]
public Employee Get(int id)
{
	return employeeRepository.SelectByID(id);
}

// add new Employee 
[HttpPost]
public void Post([FromBody] Employee emp)
{
	if (ModelState.IsValid)
	{
		employeeRepository.Insert(emp);
	}
}
```
3. **HTML with Razor**  

Following below is **HTML** code for represent the table layout for listing the freelancers and **Razor** code for represent the data.


```csharp
@foreach (var item in Model)
{
<tr>
	<td>@item.UsernameID</td>
	<td>@item.Username</td>
	<td>@item.Email</td>
	<td>@item.PhoneNumber</td>
	<td>@item.Skillsets</td>


	<td>
		@Html.ActionLink("Update", "Update", "EmployeeManager", new { id = item.UsernameID }, new { @class = "linkbutton" })
	</td>

	<td>
		@Html.ActionLink("Delete", "Delete", "EmployeeManager", new { id = item.UsernameID }, new { @class = "linkbutton" })
	</td>
</tr>
}
```
