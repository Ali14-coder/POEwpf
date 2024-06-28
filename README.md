# Sanele's Recipe Application 🍽️

- **Student Number**: ST10382076
- **Name**: Aliziwe Qeqe
- **Module Code**: PROG6221

## Project Overview

Welcome to Sanele's Recipe Application! This project is a C# application built as part of a programming module (PROG6221) at Varsity College. Below you will find a detailed description of the project, including instructions for cloning the repository, building the project, and running tests. Additionally, you will find an overview of the application's features and a summary of changes made during different parts of the project.

## Table of Contents

- [Project Overview](#project-overview)
- [Cloning the Repository](#cloning-the-repository)
- [Building the Project](#building-the-project)
- [Running Tests](#running-tests)
- [Running the Application](#running-the-application)
- [Part 2 Changes](#part-2-changes)
- [Part 3 Changes](#part-3-changes)
- [Screenshots](#screenshots)
- [Video Demonstration](#video-demonstration)

## Cloning the Repository

To clone the repository, follow these steps:

I copied the repo link that my tertiary institution (Varsity College) created for our module POE branch. I then went into my Visual Studios and opened the IDE. I selected "Clone repository" option. I pasted the POE link into the space provided and clicked on "create." I right-clicked in the empty space and selected 'copy path.' I then went into my file explorer and copied my POE.sln file folder into the repo space, using the file path I copied. My repo was successfully cloned.

## Building the Project

### Key Features

- **GUI**: The application uses a graphical user interface (GUI) built with forms and panels.
- **User Input**: Textboxes are used for user input, and buttons are used for navigation.
- **Aesthetic**: Culinary-themed background, customized font styles, and sizes for a user-friendly experience.

### Steps

- I decided upon building a GUI as opposed to a console because I wanted to challenge myself with a GUI application.
- I used forms to convey my GUI information.
- I made use of panels to communicate larger pieces of information with the user.
- To show headings, I used labels with the appropriate information, and I used textboxes to allow for user input.
- I made use of buttons to navigate from one panel or group box to another panel or group box.
- I made sure to name these toolbox features with the appropriate names that correlate to their function.

To incorporate a more user-friendly application, I set the background image to a culinary aesthetic. I also added a welcome panel and an information panel to store the name of the user and their recipe title. I also changed the font style, type, and sizes accordingly.

First, I set the location (position) of the panels to (0,0) and the group boxes to (32,130) so that the panels and group boxes all appeared at the same position. Next, I worked on my welcome panel and welcomed the user to the application and used a slogan to make the application seem more inviting. The user selects a button "Let's get started" to access the information panel. On the button click, I set the visibility of the welcome panel to false and set the visibility of the information page to true.

In the information panel, the user is able to input their chef name and the title/name of the recipe they will be creating. The page displays "Welcome Chef + the user's inputted name." The user has the option to clear their inputted details (through the clicking of the 'clear' button) or go to the next page (through the clicking of the 'next' button). The visibility of the information panel is set to false and the visibility of the ingredients panel and number of ingredients group box is set to true.

The user is prompted to enter the number of ingredients they would like to input via the group box. Once they click 'next' they are prompted to enter the name of the ingredient they would like to add as well as the quantity of that ingredient, and the unit of measurement. Once they are satisfied, they select the "Add ingredient" button. On click, this button stores the information - inputted in the textboxes - into an ingredients array. A message box is displayed that confirms the storage of the user's ingredient. The user is able to add as many ingredients, provided they select the "Add ingredients" button. Once the user is satisfied, they select the "done" button and it displays a group box that prompts them for the number of steps they would like to add. Once they select "next," an area where they are able to input their steps is displayed. Similarly to the ingredients, once the user inputs their first step, they must select the "Add step" button. This button stores the step into a step array. The user is also presented with a message box stating that their input has been successfully added.

> Please note that both the ingredient and step arrays are object arrays. The ingredient array is declared in an "IngredientsDB" class - which stands for ingredients database.

The methods that are included within this class include:

| Method | Description |
| ------ | ------ |
| `public IngredientsDB()` | A constructor that sets stores default information inside the list if there is no information stored. |
| `public void AddIngredients(Ingredients newIngr)` | This method adds a new ingredient to the ingredientsList while using the class "Ingredients" as an object. |
| `public String ingredientsPrint()` | This method displays all the ingredients stored inside the ingredients array. It uses a foreach loop through all the elements and appends them with a space between them. This method returns the final displayed array. |

Another class named "Ingredients" includes the following methods:

| Method | Description |
| ------ | ------ |
| An empty constructor class. | An empty constructor class. |
| `public Ingredients(string ingreName, string ingreQuantity, string UoM)` | An overloaded constructor class that includes the objects that will be used. |
| `public override String ToString()` | This is an overridden `ToString` method that returns the items most currently stored. |

Similarly, the step array is also declared in "StepDB" class.

The methods that are included within this class include:

| Method | Description |
| ------ | ------ |
| `public StepsDB()` | A constructor that sets stores default information inside the list if there is no information stored. |
| `public void AddStep(Steps newStep)` | This method adds a new step to the stepsList while using the class "Steps" as an object. |
| `public String stepsPrint()` | This method displays all the steps stored inside the steps array. It uses a foreach loop through all the elements and appends them with a space between them. This method returns the final displayed array.|

Another class named "Steps" includes the following methods:

| Method | Description |
| ------ | ------ |
| `public Steps()` | An empty constructor class. |
| `public Steps(string step)` | An overloaded constructor class that includes the objects that will be used. |
| `public override String ToString()` | This is an overridden `ToString` method that returns the steps most currently stored. |

The user is then directed to a display panel which displays the ingredients and steps they inputted. Once the user clicks the next button they are prompted with the option of scaling their ingredient quantity. They can either select "no" or "yes". The "no" selection exits the application and displays a message showing that they've exited the application. The "no" option displays another group box and prompts the user to select a scaling option. They can scale by a factor of 0.5, 2 or 3. In other words, they are able to half their ingredients, double them, or triple them. Once the user selects the button option, their ingredients and step are displayed on another panel with the relevant changes made to their measurements. They are also given the option to reset their scale options which displays the measurements that they stored originally at the beginning of the application.

## Running Tests

To run tests for your methods, use NUnit. This testing framework allows you to ensure the functionality of your methods through automated tests.

## Running the Application

To run the application:

To execute the application, simply run the application by clicking on the green right-facing arrow. This will start the program. The application is user-friendly so the user should be able to easily navigate through the application.

## Part 2 Changes

### Summary

- Removed `StepsDB`, `RecipeDB`, and `IngredientsDB` classes.
- Added getters and setters with constructors.
- Implemented a `SortedList<TKey,TValue>` to store recipes alphabetically.
- Included total calorie calculation and notification for recipes exceeding 300 calories.

### Detailed Changes

I removed the StepsDB, RecipeDB, and IngredientsDB classes. I instead used getters and setters and made constructors within the respective classes. I also made use of an additional list known as a ‘SortedList<TKey,TValue>’ (which I called SortedRecipeList) to store all the recipes the user makes, in alphabetical order.

Here is a summary of the changes I made:
1. The user can now view all the recipes names they made (stored in alphabetical order) and select which recipe they would like to view. This allows them to see all the details of the selected recipe.
2. If the user’s recipe exceeds 300 calories, a notification pops up warning them that they have exceeded 300kcal.
    - A delegate was used to check the total calories and the event was invoked to display in the form.
    ```csharp
    public delegate void ExceededCalories(string recipeName, double totalCalories);
    ```
3. In the recipe class I added the following:
    - Getters and setters for `RecipeName`, `Calories`, `FoodGroup`.
    - A total calorie calculation method.
4. In the ingredients class I added the following:
    - Getters and setters for `Quantity` and `OldQuantity`.
    - Methods `ResetScale`, `DoubleScale`, `HalfScale`, and `TripleScale`.
5. In the steps class, I made no changes, apart from adding using a getter and setter for my `stepDescription`.
6. Lastly, I included a unit testing class that tests the total calorie calculation method.

## Part 3 Changes

### Summary

- Converted the application from Forms to WPF.
- Made GUI elements larger for better readability.
- Changed the food group input to a combo box.
- Added filtering options for recipes by ingredient name, food group, or maximum calories.

### Detailed Changes

1. I updated my scaling page to display the appropriate scaling calories.
2. I created new windows for each panel from my forms application.
3. I made the GUI larger for better readability.
4. I added a menu page to make navigating through the application easier.
5. I changed my food group input from a textbox to a combo box for better practice and readability.
6. I included a filter option for the user to filter through their recipes. They could filter by ingredient name, food group, or maximum calories.

## Screenshots

![Adding a recipe](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/2e0f53dc-3eb2-450d-93c0-363a0803a585)
![Displayed recipe](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/f1af47a0-88e2-49ef-8e95-ffd0617b4ee5)
![Menu page](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/70d9c03e-a5fe-47ad-a882-c54df833a3f1)

## Video Demonstration

For more information on how the program operates, here is a video walkthrough of the GUI application and the code:

[Link to video demonstration]([#](https://youtu.be/quHgH2b5SkM))

---

Enjoy using Sanele's Recipe Application! 🍲✨
