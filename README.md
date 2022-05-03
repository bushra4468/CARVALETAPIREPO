# CARVALETAPIREPO
 <p>Welcome to CarValet</p>
 <p>To gain access to this project you must download the following</p>
 
1. MYSQL WORKBENCH 
2. VISUAL STUDIO
3. Postman

## Instructions

<p>Download the .sql file and the project. Once downloaded you can open the program in Visual Studio. The database is created in the sql file which will create the tables Car & Customer. Go into the appsettings.json file and locate the DefaultConnectionString and adjust as necessary. Adjust the server, port, username and password but the database will remain the same. Once finished, you can hit run and it will open up to Swagger. You can use the try out buttons to create a new entry, update, get and delete. </p>

## Using Swagger

Using Swagger you can try and see that if the entry was successful it would let you know. If a CarId was not found then you would get
a 404 error. You can execute the commands to see how the methods workout. If you are using the delete method, you must delete the
CustomerId in the Customer delete section. Then you can delete the CarId. 

##MySQL Workbench
In addition you can just paste the .sql file into the workbench and it will generate the database. It will populate it with the given
values as well as creating a new user named Welcome with the Password12. In the appsettings.json you can adjust to your local user
and password. I had some difficulty on my end where it was not accepting user so I needed to create another user entirely.  You must
 match the database name to the mytestdb or else it will not link properly. 

## Different Endpoints

1. /api/car
2. /api/customer
3. /api/customer/1


## Sample Car request body that can be pasted in
<p>
 
    "carBrand": "Toyota",
    "carType": "Supra",
    "carColor": "Red",
    "ready": "yes"
 
</p>

## Sample Car reponse body that will show 

<p>
 
    "carId": 1,
    "carBrand": "Toyota",
    "carType": "Supra",
    "carColor": "Red",
    "ready": "yes"
 
</p>


The customer ID must match a listing from the CarId values. If there is CarId 1, then for CustomerId value can be 1. 

## Sample Customer request body that can be pasted in


<p>

    "customerId": 1,
    "firstName": "string",
    "lastName": "string",
    "customerPhone": "string",
    "email": "string"
 
</p>


## Sample Customer reponse body that will show 


<p>
 
    "customerId": 1,
    "firstName": "string",
    "lastName": "string",
    "customerPhone": "string",
    "email": "string"

</p>



## Changes Made
From my original project, I had to change a couple of things. 

1. Due to the complexity of locating a parking spot, I opted to just return back the customer information that is associated with the CarId. This made it simpler for me to focus on my project as I was already facing a lot of difficulties. I used a foreign key to link the Car and Customer table associated by the ID. I would have liked to implement the car parking spots but much to my dismay that involved a lot more than I was accustomed to. I really wanted to work but unfortunately I could not get it to.
 2. Using MacOS with the Entity Framework meant I had deprecate to .Net 5.0 with the NuGet packages as well. This was extremely difficult because I had to test which packages would work. Visual Studio 2019 for Mac was also very different than that of the new Visual Studio being used now on Windows. This limited my capabilites.
 3. Some NuGet packages had to be downloaded at a compatabile release which created problems because it would not work. 
 4. I ran into some issues with the foreign key which required a lot of more resources and time than I expected. It was very tedious as I was getting confused over and over. 
 



    
    



