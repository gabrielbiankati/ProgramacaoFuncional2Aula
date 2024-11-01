using System;
using System.Threading;
using ProgramacaoFuncional2Aula;

namespace ProgramacaoFuncional2Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // **1. Criação das tarefas iniciais**
            var task1 = new TaskItem(1, "Aprender Programação", false);
            var task2 = new TaskItem(2, "caloooooooooooooooooooooor", false);


            // **2. Criação da lista inicial de tarefas
            var initialTaskList = new TaskList(new List<TaskItem> { task1, task2 });

            // **3. Criar o usuário
            var user = new User(1, "Joao", initialTaskList);

            // **4. Atualização do "concluido" de uma tarefa
            // Marca a primeira tarefa como concluída e o método vai me retornar um novo TaskItem
            var completedTask = task1.MarkAsCompleted();

            // **5. Atualização da lista de tarefas
            var updatedTaskList = user.TaskList.UpdateTask(completedTask);

            // **6. Atualização do usuario
            user = user.UpdateTaskList(updatedTaskList);

            // **7. Obtenção das tarefas pendentes
            var pendingTasks = TaskService.GetPendingTasks(user.TaskList);

            // **8. Definir uma ação (Action) de processamento
            // - Exibir uma mensagem indicando que a tarefa esta sendo processada
            // - Simular um tempo de processamento

            Action<TaskItem> processAction = task =>
            {
                // Exibir a descricao
                Console.WriteLine($"Processando tarefa: {task.Description}");

                // Simular a operação que leva 1 seg.
                Thread.Sleep(1000);
            };

            // **9 Processamento das tarefas em paralelo
            TaskService.ProcessTasksInParallel(pendingTasks, processAction);

            // **10. Composição função

        }
    }
}