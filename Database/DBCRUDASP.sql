/*
    File Name: DBCRUDASP.sql
    Description: Script for creating a database and CRUD stored procedures for managing contacts.
    Author: [Your Name]
    Date: [Date]
*/

-- Create the DBCRUDASP database if it doesn't exist
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'DBCRUDASP')
BEGIN
    CREATE DATABASE DBCRUDASP;
END

-- Switch to the DBCRUDASP database context
USE DBCRUDASP;

-- Create the Contact table to store contact information
CREATE TABLE Contact(
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(45),
    Phone VARCHAR(45),
    Mail VARCHAR(45)
);

/*
    Stored Procedure: GetListOfContact
    Description: Retrieves a list of all contacts stored in the Contact table.
*/
CREATE PROCEDURE GetListOfContact 
AS
BEGIN
    SELECT * FROM Contact;
END;

/*
    Stored Procedure: GetOneContact
    Description: Retrieves a specific contact from the Contact table based on its ID.
    Parameters:
        - @Id: The ID of the contact to retrieve.
*/
CREATE PROCEDURE GetOneContact(
    @Id INT
) AS
BEGIN
    SELECT * FROM Contact WHERE Id = @Id;
END;

/*
    Stored Procedure: CreateNewContact
    Description: Creates a new contact in the Contact table with the provided information.
    Parameters:
        - @Name: Name of the contact.
        - @Phone: Phone number of the contact.
        - @Mail: Email of the contact.
*/
CREATE PROCEDURE CreateNewContact(
    @Name VARCHAR(100),
    @Phone VARCHAR(100),
    @Mail VARCHAR(100)
) AS
BEGIN
    INSERT INTO Contact(Name, Phone, Mail) VALUES (@Name, @Phone, @Mail);
END;

/*
    Stored Procedure: UpdateContact
    Description: Updates the information of an existing contact in the Contact table.
    Parameters:
        - @Id: The ID of the contact to update.
        - @Name: New name of the contact.
        - @Phone: New phone number of the contact.
        - @Mail: New email of the contact.
*/
CREATE PROCEDURE UpdateContact (
    @Id INT,
    @Name VARCHAR(100),
    @Phone VARCHAR(100),
    @Mail VARCHAR(100)
) AS
BEGIN
    UPDATE Contact 
    SET Name = @Name, Phone = @Phone, Mail = @Mail 
    WHERE Id = @Id;
END;

/*
    Stored Procedure: DeleteContact
    Description: Deletes a contact from the Contact table based on its ID.
    Parameters:
        - @Id: The ID of the contact to delete.
*/
CREATE PROCEDURE DeleteContact (
    @Id INT
) AS
BEGIN
    DELETE FROM Contact 
    WHERE Id = @Id;
END;


SELECT * 
FROM sys.procedures;