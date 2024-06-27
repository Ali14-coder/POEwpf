# Sanele's Recipe Application
## _This application is coded in C#_

### How I cloned the repository:
I copied the repo link that my tertiary institution (Varsity College) created for our module POE branch. I then went into my Visual Studios and opened the IDE. I selected "Clone repository" option. I pasted the POE link into the space provided and clicked on "create." I right clicked in the empty space and selected 'copy path.'
I then went into my file explorer and copied my POE.sln file folder into the repo space, suing the file path I copied.
My repo was succesfully cloned.

### How I built the project in Visual Studio:
-   I decided upon building a GUI as opposed to a console because I wanted to challenge myself with a GUI application.
-   I used forms to convey my GUI information. 
-   I made use of panels to communicate larger pieces of information with the user. 
-  To show headings, I used lables with the appropriate information, and I used textboxes to allow for user input. 
-   I made use of buttons to navigate from one panel or group box to another panel or group box. 
-   I made sure to name these toolbox features with the appropriate names that correlate to their function.

To incorporate a more user-friendly applcation, I set the background image to a culinary aesthetic. I also added a welcome panel, and an information panel to store the name of the user and their recipe title. I aslo changed the font style, type and sizes accordingly.

First, I set the location (poistion) of the panels  to (0,0) and the group boxes to (32,130) so that the panels and group boxes all appeared at the same position. 
Next, I worked on my welcome panel and welcomed the user to the applicaiton and used a slogan to make the application seem more inviting. The user selects a button "Let's get started" to access the information panel. On the button click, I set the visiblity of the welcome panel to false and set the visibility of the information page to true. 
In the information panel, the user is able to input their chef name and the title/name of the recipe they will be creating.
The page displays "Welcome Chef+ the user's inputted name." The user has the option to clear their inputted details (through the clicking of the 'clear' button) or go to the next page (through the clicking of the 'next' button). 
The visibility of the information panel is set to false and the visibilty of the ingredients panel and number of ingredients group box is set to true.

The user is prompted to enter the number of ingreidents they would like to input via the group box. Once they click 'next' they are prompted to enter the name of the ingredient they would like to add as well as the quantity of that ingredient, and the unit of measurement. Once they are satisifed, they select the "Add ingredient" button. On click, this button stores the information - inputted in the textboxes - into an ingredients array. A message box is displayed that confirms the storage of the user's ingredient. The user is able to add as many ingredients, provided they select the "Add ingredients" button. Once the user is satisfied, they select the "done" button and it displays a group box the prompts them fro the number of steps they would like to add. Once they select "next," an area where they are able to input their steps is displayed. Similarily to the ingredients, once the user inputs their first step, they must select the "Add step" button. This button stores the step into step array. The user is also presented with a message box stating that their input has been successfully added.

>Please note that both the ingredient and step arrays are object arrays. The ingredient array is declared in an "IngredientsDB" class - which stands for ingredients database. 

The methods that are included within this class include:
| Method | Description |
| ------ | ------ |
| public IngredientsDB() | A constructor that sets stores default information inside the list if there is no information stored. |
| public void AddIngredients(Ingredients newIngr) | This method adds a new ingredient to the ingredientsList while using the class "Ingredients" as an object. |
| public  String ingredientsPrint() | This method displays all the ingredients stored inside the ingredients array. It uses a foreach 	which loops through all the elements and appends them with a space between them. This method returns the final displayed array. |

Another class named "Ingredients" incluldes the following methods:

| Method | Description |
| ------ | ------ |
| An empty constructor class. | An empty constructor class. |
| public Ingredients(string ingreName, string ingreQuantity, string UoM) | An overloaded contructor class that includes the objects that will be used. |
| public override String ToString() | This is an overrided ToString method that returns the items most currently stored. |

Similarily, the step array is also declared in "StepDB" class. 
The methods that are included within this class include:

| Method | Description |
| ------ | ------ |
| public StepsDB() | A constructor that sets stores default information inside the list if there is no information stored. |
| public void AddStep(Steps newStep) | This method adds a new step to the stepsList while using the class "Steps" as an object |
| public String stepsPrint() | This method displays all the steps stored inside the steps array. It uses a foreach which loops through all the elements and appends them with a space between them. This method returns the final displayed array.|

Another class named "Steps" incluldes the following methods:

| Method | Description |
| ------ | ------ |
| public Steps() | An empty constructor class. |
| public Steps(string step) | An overloaded contructor class that includes the objects that will be used.|
| public override String ToString() | This is an overrided ToString method that returns the steps most currently stored. |


The user is then directed to a display panel which displays the ingredients and steps they inputted. 
Once the user clicks the next button they are prompted with the the option of scaling their ingredient quantity. They can either select "no" or "yes". The "no" selection exits the applciation and displays a message showing that they've exitted the aplciation. The "no" option displays another group box and prompts the user to select a scaling option. They can scale by a factor of 0.5, 2 or 3. In other words, they are able to half their ingredients, double them or triple them.
Once the user selects the button option, their ingredients and step are displayed on another panel with the relevant changes made to their measurements. They are also given the option to reset thier scale options which displays the measurements that they stored originally at the beginning of the applciaition.  
 
### How I would run tests for my methods:
I would use an NUnit to conduct my tests.

### How you as the user can run the application from within the IDE:
To execute the applciaition, simply run the appciation by clicking on the green right-facing arrow. This will start the program. The application is user-friendly so the user should be able to easily navigate through the application.

### PART2:
I removed the StepsDB, RecipeDB and IngredientsDB classes. I instead used getters and setters and made constructors within the respective classes.
I also made use of an additional list known as a ‘SortedList<TKey,TValue>’ (which I called SortedRecipeList) to store all the recipes the user makes, in alphabetical order.

Here is a summary of the changes I made:
1.	The user can now view all the recipes names they made (stored in alphabetical order) and select which recipe they would like to view. This allows them to see all the details of the selected recipe.
2.	If the user’s recipe exceeds 300 calories, a notification pops up warning them that they have exceeded 300kcal.
    - A delegate was used to check the total calories and the event was invoked to display in the form. 
    ```
    public delegate void ExceededCalories(string recipeName, double totalCalories);
    ```
3.	In the recipe class I added the following:
	-   Getters and setters for ‘RecipeName’, ‘Calories’, ‘FoodGroup’.
    -   A total calorie calculation method.
4.	In the ingredients class I corrected the following:
    -   Getters and setters for ‘Quantity’ and ‘OldQuantity.’.
    -   Methods ‘ResestScale’; ‘DoubleScale’; ‘HalfScale’ and ‘TripleScale’.
5.	In the steps class, I made no changes, apart from adding using a getter and setter for my stepDescription.
6.	Lastly, I included a unit testing class that tests the total calorie calculation method.

## PART3:
Based on the lectuer's feedback, I had to change the view on the scaling page to include the calories being appropriately scaled.

I converted my application from a Form to a WPF.

Challenges that arose was figuring out how to alter code that worked on Forms to work on WPF.
Another challenge I faced was operating between XAML and C# simultanesously when I needed to implement an ItemTemplate or ItemsSource for my Listboxes.

I had also decide to make a new window for each of my 'panels' that I previously had on Forms. 


Upon my lecturers instructions, I also made my GUI window, textboxes, labels and listboxes larger so that they are now easier to read; and no information is cut off. I also changed the textbox for the food group input, into a combo box. This also aided in making the filtering code easier to accomplish.

![Adding a recipe](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/2e0f53dc-3eb2-450d-93c0-363a0803a585)
![Displayed recipe](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/f1af47a0-88e2-49ef-8e95-ffd0617b4ee5)


I tried to make the GUI application as user friendly as possible by including a menu page after the 'Welcome' page.
 ![Menu page](https://github.com/VCNMB/VCNMB-PROG6221-2024-POE--Ali14-coder/assets/126757351/70d9c03e-a5fe-47ad-a882-c54df833a3f1) 

This menu page is to aid the user in easy naivagtion throughout the application.
 
I kept my orginal classes that had my Ingredients, Recipes and Steps.
In part 3, I added a page where the user was able to filter through all the recipes that were stored in the SortedLists. They have the option to filter these recipes by the ingredient name, food group or maximum number of calories. 

For more information on how my program operates, here is a video on myself running through the GUI applciation and the code:
