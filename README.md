# Customer Rewards Program

A Sample application for the calulation of the rewards points for the customer for the trnsaction.

For every dollar spent over $50 on the transaction, the customer receives one point. In addition, for every dollar spent over $100, the customer receives another point.

Example: For a $120 purchase, the customer receives

(120 - 50) x 1 + (120 - 100) x 1 = 90 points


### CustomerRewards.Api

This is api expose to the world, it contains method for GettingAllRewards, GettingRewards for last 3 Month, Add a transaction, Calcaulte the Reward Point.

There is also health endpoint to check the servie health

### CustomerRewards.Core

This is Main proeject with the services to calcualate the rewards logic and communicate with repoistory

### CustomerRewards.UnitTests

This project contain all the unit test for the project


## Running the Application

To run the application, please use the VS 2022 or VS Code and Build the solution. 

Install the dotnet.exe from microsoft and Run the below commands to run the solution.

Run dotnet restore
Run dotnet build
Run dotnet


## ThirdPart Nuget

Newtonsoft
Moq
Xunit

## Exception Handling

There is global exception handling, which will handle the error and return the standard response to the user.

## DataSet

There is user transaction dataset in the application with file nam Data.Json, which contain the transaction from the last 3 months.

##Customer Transaction Screenshot

![image](https://user-images.githubusercontent.com/7678271/171291803-78eab765-52cf-4f1e-b6ad-25b553147474.png)

![image](https://user-images.githubusercontent.com/7678271/171292097-429738df-ec09-42c0-be64-cceac514a1f6.png)



