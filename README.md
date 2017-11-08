# CarsDB2
Windows form for a Car Hire that connects to a SQL Database.

Scenario
You work as a programmer for Omega Solutions who develop software for clients. You have been
asked to design, create and test the software to access an external database. The interface to the
database must enable the user to do the following:
- display individual records
- add a new record
- delete a record
- edit a record
- update a record
- cancel amendments for a record
- search records.

A database already exists named Hire containing a table tblCar which contains car details. The table
tblCar contains the following fields:
Field Name Data Type Field Length
VehicleRegNo (Primary Key) Text 10
Make Text 50
EngineSize Text 10
DateRegistered Date dd/mm/yyyy
RentalPerDay Currency, 2 decimal places
Available Logical (Yes/No) 1
The VehicleRegNo field is a primary key and there cannot be duplicate entries in this field and a
zero-length entry is not allowed.

Task A
In this task you are required to design and create software to access an external database (Hire)
with a single table via a database connection and a data form.
Copy the database file(s) that you have been given into the same directory as your project. Make a
backup copy of the file(s) in another directory.
Using the Integrated Development Environment:
1 Save the project at regular intervals as you work through the task. Save the form
files as frmCars and frmSearch and the Project as CarsDatabase.

2 Create a data form that shows a single record to appear similar to the form shown above and
includes:
- a label for the heading 'Bowman Car Hire' in bold with a different font and a larger
font size
- six controls and associated labels to display the data for the record
- controls to move to the first, previous, next and last record
- a control to hold a record count in the form n of nn
- six buttons for Update, Add, Delete, Search, Cancel and Exit adding the shortcuts as
shown
- setting the background to a suitable colour
- the data input controls receiving focus in an appropriate order.
3 Set the Text property of the form frmCars to:
Task A your name and today's date

4 Make a connection to the database Hire using suitable parameters.

5 Make sure that the formats of the displayed fields are as shown in frmCars.

6 Set up the program so that when the form frmCars is loaded the dataset is loaded
automatically and the data for the first record is displayed in the controls.

7 Write code for the Update, Add, Delete and Cancel buttons.

8 Write code for the controls to move to the first, previous, next and last records.

9 Write code in a function to display the total record count and current record number each
time one of the navigation buttons Is used. This will be displayed in the control associated
with the navigation buttons as shown on the form frmCars.

10 Insert the code required to handle errors for database access which prevents run-time errors.

11 Write code for the Exit button to terminate the program.

12 Add a ToolTip control to the form frmCars.

13 Set the ToolTip property of THREE of the data entry controls on frmCars to an appropriate
text value to assist the user when entering data eg for the Make data entry control 'Enter the
make of the vehicle'.

14 Write code for the Search button to open a second form named frmSearch.

15 This following form is to be used to allow the user to specify a search criteria and display the
matching records from the database table.
Create a new form frmSearch to appear similar to the form shown above and includes:
- a group box on the form to contain the following:

  - two combo boxes named cboField and cboOperator with associated labels
  
  - a text box for data entry with an associated label
  
- a DataGridView control to display the results of the search
- two buttons named btnRun and btnClose with the text Run and Close
- make sure that the formats of the displayed fields are as shown in frmSearch.

16 Save the form as frmSearch.

17 Set the Text property of form frmSearch to:
Task A Search your name and today's date.

18 Write code in the Load function for the form to
- populate cboField with the field names Make, EngineSize, RentalPerDay and Available
- populate cboOperator with the following operator symbols, each one as a single list
item: =, <, >, <=, >=

19 Write code for the Run button that will match the search criteria entered using the combo
boxes and the value in the data entry text box. The fields VehicleRegNo, Make, EngineSize,
DateRegistered, RentalPerDay and Available, for all the records which match the criteria,
should be displayed in the data grid. The search should be run only if data exists in all three
query criteria controls. A criteria string that is not matched by any record must return
nothing.

20 Write code for the Close button to hide the form and return to the form frmCars.
