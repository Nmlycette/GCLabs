import { Component } from '@angular/core';
import { ITodo } from './todointerface';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'AngularToDo';

  todoList: ITodo[] = [
    {task: "Launder clothes", completed: false},
    {task: "Vaccuum", completed: false},
    {task: "Pay bills", completed: true},
    {task: "Grocery shop", completed: true},
    {task: "Schedule appointment", completed: false},
  ];
  
  getTasks(): ITodo[] {
    return this.todoList
  };

  newTask: string = "";
  addTask() {
    const newTodo: ITodo = {
      task: this.newTask,
      completed: false
    };
    this.todoList.push(newTodo);
    this.newTask = ""
  };

  completeTask(task: ITodo) {
    task.completed = true;
  };

}
