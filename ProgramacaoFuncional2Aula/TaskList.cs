using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    // Classe qie gerencia a lista de tarefas (TaskItem) de um usuario
    public class TaskList
    {
        public List<TaskItem> Tasks { get; }

        //private readonly List<TaskItem> _tasks;
        //public List<TaskItem> Tasks
        //{
        //    get { return new List<TaskItem>(_tasks); }
        //}

        public TaskList(List<TaskItem> tasks)
        {
            Tasks = new List<TaskItem>(tasks);
        }

        public TaskList AddTask(TaskItem task)
        {
            // Criamos uma nova lista copiando as tarefas ja existentes 
            var newTasks = new List<TaskItem>(Tasks);

            // Adicionei uma nova tarefa à lista
            newTasks.Add(task);

            // Retornar uma nova instancia de TaskList com a lista atualizada
            return new TaskList(newTasks);
        }

        public TaskList UpdateTask(TaskItem updatedTask)
        {
            // Nova lista copiando as tarefas existentes
            var newTasks = new List<TaskItem>(Tasks);

            for (int i = 0; i < newTasks.Count; i++)
            {
                if(newTasks[i].Id == updatedTask.Id)
                {
                    // Aqui encontramos a tarefa antiga
                    // Agora substituimos a antiga pela nova
                    newTasks[i] = updatedTask;
                }
            }

            return new TaskList(newTasks);
        }
    }
}
