using FD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FD.ViewModels
{
   public class DirectoryStructureVM: DirectoryBaseVM
    {
        public ObservableCollection<DirectoryItemVM> items { get; set; }

        public DirectoryStructureVM()
        {
            items = new ObservableCollection<DirectoryItemVM>(DirectoryStructure.getLogicalDrives().Select(drive => new DirectoryItemVM(drive.FullPath, drive.type)));
        }
    }
}
