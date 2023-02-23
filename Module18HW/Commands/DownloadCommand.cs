using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Module18HW.Commands
{

    class DownloadCommand : ICommand
    {
        Video video;

        public DownloadCommand(Video video)
        {
            this.video = video;
        }

        public async Task Execute()
        {
            video.Download();
        }
    }
}
