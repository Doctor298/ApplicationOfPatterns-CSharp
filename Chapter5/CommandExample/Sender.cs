using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class Sender
    {
        private ICommand command;

        public Sender(ICommand command)
        {
            this.command = command;
        }

        public void DoCommand()
        {
            command.Execute();
        }
    }
}
