using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskList : MonoBehaviour
{
    protected TaskInterface[] tasks = new TaskInterface[] {
        // STUDENTS
        // Instantiate your tasks here as decsribed in the documentation
        // new Debug_Task(),
        new GetCoordinates(),
        new GetLidar(),
        new GetCamera(),
        new ChangeMode(),
        new Steer(),
        new Move()
    };

    public TaskInterface[] GetTasks() {
        return this.tasks;
    }
}
