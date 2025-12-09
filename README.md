ADVO-SYS – Case Management System

A Web-Based Arbitration & Legal Case Tracking Platform

📌 Overview

ADVO-SYS is a web-based case management system built using ASP.NET MVC, SQL Server, and Entity Framework (EDMX).
The system digitizes and automates the management of arbitration/legal cases by providing a unified platform for:

Case registration

Case assignment

Document uploading

User role management

Case tracking

Log monitoring

Designed for organizational use, the system replaces manual case-handling processes with a secure, scalable, and structured application.

🚀 Features
🔐 Role-Based Access

Super Admin – Full access to manage users, cases, clients, and reports.

Advocate – Can view assigned cases (restricted to max 10 cases).

Arbitrator – Manage hearings and case progress.

Client – View case status and uploaded documents.

📝 Case Management

Unique case number generation

Opposite party details

Financial year–wise case grouping

Dropdown-based dynamic assignment

📄 Document Management

Upload Agreement, Invoice, Contract, and other documents

Automatic folder creation per case

Stores metadata in documents_master

📊 Reports

Award Reports

Case Logs

Login Transaction Logs

📬 Email Notification (SMTP)

Auto email alerts on case creation & assignment

🛠️ Technology Stack
Layer	Technology
Frontend	HTML, CSS, Bootstrap, jQuery
Backend	ASP.NET MVC 5
ORM	Entity Framework (Database First – EDMX)
Database	Microsoft SQL Server
Architecture	MVC Pattern
Tools	Visual Studio 2019/2022
📂 Project Structure
/Controllers  
    CaseController.cs  
    HomeController.cs  
    MasterController.cs  

/Models  
    SAI_Entity_Model.edmx  
    Custom_Models/  

/Views  
    Case/  
    Home/  
    Master/  

/Content  
/Css  
/Js  
/Images  

⚙️ Setup & Installation
1️⃣ Clone the Repository
git clone https://github.com/your-username/ADVO-SYS.git

2️⃣ Configure Database

Import .bak or .mdf file in SQL Server

Update Web.config connection string:

<connectionStrings>
    <add name="SAI_UAT_Entities"
         connectionString="metadata=res://*/Models.SAI_Entity_Model.csdl|res://*/Models.SAI_Entity_Model.ssdl|res://*/Models.SAI_Entity_Model.msl;
         provider=System.Data.SqlClient;provider connection string=&quot;data source=localhost\SQLEXPRESS;
         initial catalog=SAI_UAT_LOCAL;user id=sa;password=XXXX;MultipleActiveResultSets=True;&quot;"
         providerName="System.Data.EntityClient" />
</connectionStrings>

3️⃣ Restore NuGet Packages
Right-click Solution → Restore NuGet Packages

4️⃣ Run the Application

Press F5 🚀

🔄 Key Modules
1️⃣ Add Case Module

Assign Advocates/Arbitrators

Restrict advocate to max 10 active cases

Upload documents (Agreement, Contract, Invoice)

2️⃣ Master Modules

User Master

Client Master

Document Type Master

State & City Master

Financial Year Master

🧠 Advocate Case Limit Logic

Advocate is restricted from having more than 10 active cases:

int count = db.case_assignments
              .Where(x => x.assigned_user_id == advocateId && x.is_active)
              .Count();

if(count >= 10)
{
    ModelState.AddModelError("", "This advocate already has 10 assigned cases.");
    return View(frm);
}

📸 Screenshots

(Add your project screenshots here)

📌 Future Enhancements

Cloud deployment (Azure/AWS)

Big Data analytics for case trend prediction

Notification dashboard

Real-time chat between client & advocate

👨‍💻 Author

Rahul Gupta
Developer – ASP.NET MVC | SQL Server
📧 Email: add-your-email
🌐 GitHub: your-github-url
