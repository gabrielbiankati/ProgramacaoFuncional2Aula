using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    // Classe que representa uma tarefa individual
    public class TaskItem
    {
        // Propriedades "somente leitura" para
        // garantir imutabilidade
        public int Id { get; }
        public string Description { get; }
        public bool IsCompleted { get; }

        public TaskItem(int id, string description, bool isCompleted)
        {
            Id = id;
            Description = description;
            IsCompleted = isCompleted;
        }

        // Método que retorna uma nova instância da tarefa
        // com o status atualizado
        // Isso demonstra imutabilidade, a
        public TaskItem MarkAsCompleted()
        {
            return new TaskItem(Id, Description, true);
        }
    }
}
