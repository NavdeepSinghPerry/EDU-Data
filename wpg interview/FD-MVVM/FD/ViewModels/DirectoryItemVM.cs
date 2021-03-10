using FD.Command;
using FD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FD.ViewModels
{
   public class DirectoryItemVM: DirectoryBaseVM
    {
        public DirectoryItemType type { get; set; }
        public string FullPath { get; set; }

        public ICommand expandCommand { get; set; }

        public string Name
        {
            get
            {
                return this.type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.getFolderName(FullPath);
            }
        }

        public DirectoryItemVM(string fullPath, DirectoryItemType type)
        {
            expandCommand = new RelayCommand(expand);
            this.FullPath = fullPath;
            this.type = type;
            this.ClearChild();
        }

        public ObservableCollection<DirectoryItemVM> children { get; set; }
        public bool canExpand { get { return this.type != DirectoryItemType.File; } }

        public bool IsExpanded
        {
            get
            {
                return children?.Count(f => f != null) > 0;
            }
            set
            {
                if (value == true)
                {
                    expand();
                }
                else
                {
                    ClearChild();
                }
            }
        }

        private void ClearChild()
        {
            this.children = new ObservableCollection<DirectoryItemVM>();

            if (this.type != DirectoryItemType.File)
            {
                this.children.Add(null);
            }
        }
        private void expand()
        {
            if(this.type == DirectoryItemType.File) { return; }

            this.children =new ObservableCollection<DirectoryItemVM>(DirectoryStructure.getDirectoryContents(FullPath).Select(content=>new DirectoryItemVM(content.FullPath,content.type)));
        }
    }
}
