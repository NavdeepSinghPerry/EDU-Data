using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FD.Model
{
    public class DirectoryItem
    {
        public DirectoryItemType type { get; set; }
        public string FullPath { get; set; }

        public string Name
        {
            get
            {
                return this.type == DirectoryItemType.Drive ? FullPath: DirectoryStructure.getFolderName(FullPath);
            }
        }
    }
}
