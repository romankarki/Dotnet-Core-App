using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id = 1,HowTo="Task to do",Line = "Something",Platform = "just do it"},
                new Command{Id = 2,HowTo="Task to ",Line = "Do Something",Platform = "just do it"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0,HowTo="Task to do",Line = "Something",Platform = "just do it"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}