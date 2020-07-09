using System.IO;

namespace Exercise_Two.views
{
    interface IFile
    {
        private FileInfo file 
        {
            get 
            {
                return this.file;
            }
            set => this.file = value as FileInfo;
        }
        private FileStream stream {
            get 
            {
                return this.stream;
            }
            set => this.stream = value as FileStream;
        }
        private StreamReader content {
            get 
            {
                return this.content;
            }
            set => this.content = value as StreamReader;
        }      
        private string pathApp
        {
            get 
            {
                return this.pathApp;
            }
            set => this.pathApp = value;
        }
        public string name {
            get 
            {
                return this.name;            
            }
            set => this.name = value;
        }
        public string path
        {
            get
            {
                return this.path;
            }
            set => this.path = value;
        }
        public string extension
        {
            get
            {
                return this.extension;
            }
            set => this.extension = value;
        }
        public void create();
        public bool delete();
        public bool write(string str);
        public bool print();
    }
}
