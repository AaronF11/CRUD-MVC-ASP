# CRUD Contact App

## Overview
CRUD Contact App is a simple and efficient application designed for managing contacts. It offers basic CRUD (Create, Read, Update, Delete) functionalities to add, view, edit, and remove contacts. With a clean and intuitive user interface, managing your contacts has never been easier.

## Features
- **Create Contact**: Add new contacts with name, phone, and email details.
- **View Contact**: Display a list of existing contacts with their details.
- **Update Contact**: Modify existing contact details such as name, phone, and email.
- **Delete Contact**: Remove contacts from the database.
- **Validation**: Input fields are validated to ensure data integrity.
- **Error Handling**: Appropriate error handling for database operations.

## Requirements
- Visual Studio with ASP.NET MVC framework installed.
- SQL Server Management Studio or equivalent for database management.
- Modern web browser.

## Installation
1. Clone this repository to your local machine.
2. Open the solution file (.sln) in Visual Studio.
3. Ensure that the necessary dependencies are installed via NuGet Package Manager.
4. Configure the database connection string in the `appsettings.json` file located in the project directory. 
5. Run the `DBCRUDASP.sql` script located in the `Database` directory to create the database.
6. Build and run the application.

## Usage
1. Upon opening the application, you'll see a list of existing contacts if any.
2. To add a new contact, click on the "Add Contact" button and fill in the required details.
3. To view details of a contact, click on the contact's name from the list.
4. To edit a contact, click on the "Edit" button next to the contact's details and update as needed.
5. To delete a contact, click on the "Delete" button next to the contact's details.

## Example Usage
Creating a new contact:
- Click on "Add Contact".
- Fill in the required fields: Name, Phone, and Email.
- Click on "Save" to add the contact.

Viewing contact details:
- Click on the contact's name from the list to view details.

Editing contact details:
- Click on the "Edit" button next to the contact's details.
- Update the contact's information.
- Click on "Save" to apply changes.

Deleting a contact:
- Click on the "Delete" button next to the contact's details.

## Screenshots
![Screenshot 1](/Images/Captura-1.png)
*Description: CRUD Contact App initial view*

![Screenshot 2](/Images/Captura-2.png)
*Description: CRUD Contact App adding contact details*

![Screenshot 3](/Images/Captura-3.png)
*Description: CRUD Contact App editing contact details*

![Screenshot 4](/Images/Captura-4.png)
*Description: CRUD Contact App removing contact*

## Contribution
If you encounter any issues or have suggestions to improve the CRUD Contact App, feel free to open an issue or submit a pull request. Your contribution is highly appreciated!

## License
This project is licensed under the [MIT License](/LICENSE.md).
