using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FD.Model
{
   public static class DirectoryStructure
    {

        public static List<DirectoryItem> getLogicalDrives()
        {
            return Directory.GetLogicalDrives().Select(drive => new DirectoryItem { FullPath = drive, type=DirectoryItemType.Drive}).ToList();
        }

        public static List<DirectoryItem> getDirectoryContents(string fullPath)
        {
            var items = new List<DirectoryItem>();


            // Updating Directories
            foreach (var item in Directory.GetDirectories(fullPath))
            {
                items.Add(new DirectoryItem() { FullPath = item, type = DirectoryItemType.Folder });

            }

            // Updating Files
            foreach (var item in Directory.GetFiles(fullPath))
            {
                items.Add(new DirectoryItem() { FullPath = item, type = DirectoryItemType.File});

            }
            return items;

        }

        public static string getFolderName(string path)
        {

            string name = path.Split('\\').Last();

            return name;
        }


    }
}
