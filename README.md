# _Pierre's Pastries_

#### By _Mo Byrne_

#### _Brief description of application_

---
## Table of Contents
[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

---
## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have._

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>  

1. Copy the git repository url: https://github.com/MoseyByrne/SweetSavory  
2. Open a shell program and navigate to your desktop.
3. Clone the repository for this project using the `git clone` command and including the copied URL.
4. While still in the shell program, navigate to the root directory of the newly created file named `SweetSavory.Solution`.
5. From the root directory, navigate to the `SweetSavory` directory.
6. Move onto SQL Workbench instructions below to re-create database necessary to run this project.
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>

1. Create an <font color="green">`appsettings.json`</font> file in the `SweetSavory` directory of the project  
   <pre>SweetSavory.Solution
   └── SweetSavory
    └── <strong><font color="yellow">appsetting.json</font></strong></pre>
2. Insert the following code [^1]  
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=sweet_savory;uid=root;pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

3. Once <font color="green">`appsettings.json`</font> file has been created, navigate back to SQL Workbench.
</details>

<details>
<summary><strong>To Run</strong></summary>

1. Navigate to:  
   <pre>SweetSavory.Solution
   └── <strong><font color="yellow">SweetSavory</font></strong></pre>

2. Run `$ dotnet restore` in the console.  
3. Run `$ dotnet database update` in the console.  
4. Run `$ dotnet run` in the console
</details>


---
## Known Bugs

* No known bugs

---
## [License](/LICENSE)

_Feel free to reach out via [Github](https://github.com/MoseyByrne) to provide feedback on this project or to view my other projects._

[Copyright](/LICENSE) © 2022 Mo Byrne

---
### Footnotes

[^1]: You must include your password in the code block section labeled `YOUR-PASSWORD-HERE`.