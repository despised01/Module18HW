using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Module18HW.Commands
{
    class GetInfoCommand : ICommand
    {
        Video video;

        public GetInfoCommand(Video video)
        {
            this.video = video;
        }

        public async Task Execute()
        {
            video.GetInfo();
        }
    }
}
