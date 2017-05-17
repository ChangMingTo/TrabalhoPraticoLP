using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Scrum.Models;

namespace Scrum.Controllers.ProcessController
{
    public class TasksController
    {
        public TasksController()
        {
            
        }

        /// <summary>
        /// da tasks aos utilizadores 
        /// </summary>
        /// <param name="developer"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool Distribuicao(Developer developer, Task task)
        {
            developer.Tasks.Add(task);
            return true;
        }

        /// <summary>
        /// Retorna a tasks que ja estao feitas
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public List<Task> TasksDone(Product produto)
        {
            List<Task> a = new List<Task>(); ;
            foreach(Project projecto in produto.Projects)
            { 
               foreach(Task task in projecto.Tasks)
                {
                    if (task.Progress==State.Done)
                    {
                        a.Add(task);
                    }
                }
            }
            return a;
        }
  
        /// <summary>
        /// Retorna a tasks que nao estao feitas
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public List<Task> TasksWorking(Product produto)
        {
            List<Task> a = new List<Task>(); ;
            foreach (Project projecto in produto.Projects)
            {
                foreach (Task task in projecto.Tasks)
                {
                    if (task.Progress == State.Working)
                    {
                        a.Add(task);
                    }
                }
            }
            return a;
        }

        /// <summary>
        /// Retorna a tasks em teste
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public List<Task> TasksTesting(Product produto)
        {
            List<Task> a = new List<Task>(); ;
            foreach (Project projecto in produto.Projects)
            {
                foreach (Task task in projecto.Tasks)
                {
                    if (task.Progress == State.Testing)
                    {
                        a.Add(task);
                    }
                }
            }
            return a;
        }

        /// <summary>
        /// Retorna a tasks que ainda nao foram começadas
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public List<Task> TasksStarting(Product produto)
        {
            List<Task> a = new List<Task>(); ;
            foreach (Project projecto in produto.Projects)
            {
                foreach (Task task in projecto.Tasks)
                {
                    if (task.Progress == State.Starting)
                    {
                        a.Add(task);
                    }
                }
            }
            return a;
        }

        public int TaskToTest(Task task)
        {
            Random randNum = new Random();
            int a=randNum.Next(0,10);
            if (a == 0)
            {
                task.Progress = State.Done;
            }
            else
            {
                task.Progress = State.Testing;
            }
            return a;
        }
    }
}