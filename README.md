# .NET MVC Introduction Classwork

## Exercise 1: Create a new MVC Web Application

`dotnet new mvc -o mvcclasswork`

1. Launch the Web Application
2. Hit the web application from the browser
3. Open Postman
* Create a new Postman project
* Add a test case for `Home Page` as an HTTP GET request
* Verify your web application is running using your Postman test
* Export your Postman test project and add to your repo

## Exercise 2: Create a Controller
1. Create a new Controller called `GreetingController` 
2. Add a `Greet` method to the controller that returns the Content `Well Hello There`
3. Open Postman
* Open the Postman project create in Exercise 1
* Add a test case for `Greeting` as an HTTP GET request
* Verify your web application is running using your Postman test

## Exercise 3: Export Postman tests
* Export your Postman test project and add to your repo

## Challenge
- Modify your `Greeting` controller to accept a GET parameter called `name` and an int parameter called `visits`
- Modify the endpoint to return `Well Hello There [WHATEVERNAME_PASSED_IN]! You have visited the site [WHATEVERNUMBER] times!`


