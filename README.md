# Railway-System-Database-Project
The Railway Management System (RMS) is designed to automate and streamline the operations of a railway network. It aims to provide efficient ticketing, scheduling, and management services for both passengers and railway staff. The system will include features for ticket reservation, train scheduling, seat allocation, fare calculation, safety monitoring, and customer support.

1. User Authentication:
• Passenger can login and sign-up into the application .For Account creation Passenger receive an OTP Email to successfully sign up into the system. Sign Up Form includes email, password, phone-number and CNIC.
• Employees and Admin can login into the system. While Admin can Manage Employees (CRUD Operations)

2. Ticket Reservation:
• Passengers can search for train schedules, check seat availability, and book tickets for their desired journeys. They can also select their preferred class, seat type. After booking the seat system must calculate the fare and showed it to user.

3. Train Schedule Management:
• Admin can input and manage train schedules, including arrival and departure times, routes, and any changes or cancellations. With each schedule Management it must also be able to show the image of respective train with the respective schedule on the user side as well as on the admin side. Admin can delete, view, add or update.

4. Customer Support:
• Passengers can access customer support services, including inquiries, complaints, and feedback handling. The system allows passengers to report issues, request assistance, and provide feedback on their travel experience.

5. Previous Reservation :
• Each Passenger Must be able to view its previous reservation and can also sort by status i.e. cancelled, purchased.

6. Track Train :
• Passenger must be able to track train status after booking it i.e. cancelled, delay and on time etc.

7. Profile:
• Passenger: Can View and Update Profile.
• Admin: Can View and Update Profile including the image stored in data.
• Employees: Can View and Update Profile including the image stored in data.
8. Revenue: Calculate the revenue of User purchased ticket and generate pdf of the revenue.(Weekly and Monthly)
9. Manage Employees: Admin must be able to add or remove employees to add employees it must also store its image to data base. And can Assign respective task to respective Employees and can also view as well as update and add on each updation respective employee must be notified(Notifications must be within the system).Employees must be of different types i.e. drivers, customer support and cashier etc. Make sure to distinguish between each type of employee that customer support employees can view feedback and manage customer affairs also ,while cashier manage the selling of tickets etc.
10. Salary: Employee Must be able to view salary at the end of month when arrived and can also view its previous salary sorted by All or year or its status.
11. Tasks: Employees must be able to view task sorted by (all, completed and missed on which basis salary will be calculated of every month).
12. Manage Seats: Cashier must be able to sell ticket to passenger and mark its status purchased , and if it is sell to another passenger then it must delete that record and store it in the other passenger history .

Interface Functionality Rough View

Passenger 
• Check Profile
• Book Seat
• Previous Reservation
• Feedback
• Track Train

Admin 
• Check Profile
• Manage Employees
• Manage Train Schedule
• Revenue(pdf)
• View Trains
• Assign Task to Employees
• View Feedback
• Dashboard

Employees (distinguish interface of each type of employee)
• Check Profile
• Salary
• To-Do Task(View/Mark Complete)
• Customer Support (View Feedback, handle customer affairs)
• Selling of ticket
