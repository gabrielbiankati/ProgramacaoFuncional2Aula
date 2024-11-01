using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    public class User
    {
        // User TEM TaskList que TEM TaskItems
        public int Id { get; }
        public string Name { get; }
        public TaskList TaskList { get; }

        public User(int id, string nome, TaskList taskList)
        {
            Id = id;
            Name = nome;
            TaskList = taskList;
        }

        public User UpdateTaskList(TaskList newTaskList)
        {
            return new User(Id, Name, newTaskList);
        }
    }
}
