# ANGULAR TO-DO

## Objective
Angular Components, For Loops

## Task
Create an Angular application that displays to-dos and allows the user to add new ones.

## Build Specifications:
- Must include a Todo Interface, which consists of a “task” (string) and a “completed” (boolean).
- The component must add an array of sample todo objects to the view.
    - Each todo object should match the Todo interface. 
    - Include a mix of complete and incomplete items. (Pre-populate the array in the typescript)
- The ngFor directive must be used. 
- The ngIf directive must be used to remove the button “complete” button for completed todos. 
- Submitting the form calls a function named addTask that adds a new todo to the array with the task set to the contents of the input field and the complete property set to false.
- Clicking the “complete” button executes a function named completeTask that sets the task’s completed property to true.
- The text input at the top is for an extended challenge.
- CSS styling is optional for this lab. See style guide below.

## Extended Challenges
- Display a congratulations message if the list is empty or all items are complete.
- Allow the user to remove items from the list, by clicking the “x”. (Clicking the “x” on an item executes a function named removeTask that removes that item from the array.
- Add strikethrough styling to completed items.
- Allow the user to filter the list by typing in the top input. (Only items which include the text typed will be shown.)
- Allow the user to edit a to-do.

## Style guide:
- Font-family: Open Sans; 
- Font-weight: 300; 
- Body background: linear-gradient(to right, #f857a6, #ff5858) 
- Icons: Font Awesome or Material Icons 
- Box-shadow: box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75); 
- Colors: 
    - #bbb 
    - #eee 
    - #ff0000
    - #ff69b4 
    - #ff1493

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 15.1.5.

## Development server
Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding
Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build
Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests
Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests
Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help
To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.