using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BattletechModInfo.UI.WPF.Models;

namespace BattletechModInfo.UI.WPF.ViewModels
{

    public class FileViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<FileInfo> fileList;

        public ObservableCollection<FileInfo> FileList
        {
            get { return fileList; }
            set
            {
                fileList = value;
                OnPropertyChanged(nameof(FileList));
            }
        }

        public FileViewModel()
        {
            // Initialize the FileList with some sample data (replace with your own data)
            FileList = new ObservableCollection<FileInfo>
            {
                new FileInfo
                {
                    FileName = "File1.txt", FileSize = "10 KB",
                    BaseFilePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH\\Mods",
                    FullFilePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH\\Mods\\FileFolder1\\File1.txt"
                },
                new FileInfo
                {
                    FileName = "File2.docx", FileSize = "56 KB",
                    BaseFilePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH\\Mods",
                    FullFilePath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\BATTLETECH\\Mods\\FileFolder1\\File2.docx"
                },
                // Add more files as per your requirements
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
