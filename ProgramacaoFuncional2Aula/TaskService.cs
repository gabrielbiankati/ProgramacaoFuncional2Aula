using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    // Classe que contem funções para manipular tarefas
    public class TaskService
    {
        // Função pura que filtra tarefas incompletas
        public static List<TaskItem> GetPendingTasks(TaskList taskList)
        {
            var pendingTasks = new List<TaskItem>();

            foreach(var task in taskList.Tasks)
            {
                if (!task.IsCompleted)
                {
                    pendingTasks.Add(task);
                }
            }

            return pendingTasks;
        }

        // Função de alto nível que recebe outra função como parâmetro (delegate)

        public static void ProcessTasks(List<TaskItem> tasks, Action<TaskItem> processAction)
        {
            foreach (var task in tasks)
            {
                processAction(task);
            }
        }

        // Action<T1>: representa um método que aceita um parametro do tipo "T1", e não retorna valor.

        //Func<TInput1, TInput2, TResult>
        public static void ProcessTasksInParallel(List<TaskItem> tasks, Action<TaskItem> processAction)
        {
            // Criar uma lista para armazenar as threads.
            var threads = new List<Thread>();
            // Thread é uma tarefa que o programa pode executar de forma independente
            // Um programa pode ter várias threads executando SIMULTANEAMENTE cada uma realizando uma tarefa diferente.

            foreach (var task in tasks)
            {
                var currentTask = task;

                // Criar uma nova thread que execute a ação do processamento
                var thread = new Thread(() => processAction(currentTask));

                threads.Add(thread);

                // Iniciar a thread assegurando que a execução vai começar assim que possível
                thread.Start(); 
            }

            // Aguardar todas as threads terminarem sua execução.
            foreach (var thread in threads)
            {
                // O método Join bloqueia a execução do programa até que a thread específica termine sua operação
                thread.Join();
            }
        }
    }
}
