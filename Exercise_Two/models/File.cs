using Exercise_Two.views;
using System;
using System.IO;

namespace Exercise_Two.models
{
    class File : IFile
    {
        private FileInfo file { get; set; }
        private FileStream stream { get; set; }
        private StreamReader content { get; set; }
        private string pathApp { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string extension { get; set; }

        public File(string name, string extension)
        {
            this.name       = name;
            this.extension  = extension;
            this.pathApp = string.Format(
                @"{0}\files", 
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName
                ); 
            
            this.path = string.Format(
                @"{0}\{1}.{2}",
                this.pathApp,
                this.name, 
                this.extension
                );
            this.file = new FileInfo(this.path);
        }

        public void create()
        {
            this.stream = (FileStream)this.file.Create();
            this.stream.Close();
        }

        public bool delete()
        {
            if (!this.file.Exists) return false;

            this.file.Delete();

            return true;
        }

        public bool print()
        {
            if (!this.file.Exists) return false;

            string str;
            this.content = this.file.OpenText();

            while ((str = this.content.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }

            return true;
        }

        public bool write(string str)
        {
            if (!this.file.Exists) return false;

            this.stream = this.file.OpenWrite();
            byte[] arr = System.Text.Encoding.Default.GetBytes(str);
            this.stream.Write(arr, 0, arr.Length);
            this.stream.Close();

            return true;
        }
    }
}
