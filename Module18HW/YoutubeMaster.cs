using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module18HW.Commands;

namespace Module18HW
{
    public class YoutubeMaster
    {
        ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void Execute()
        {
            _command.Execute();
        }
    }
}
