using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Module18HW.Commands
{
    public interface ICommand
    {
        public Task Execute();
    }
}
