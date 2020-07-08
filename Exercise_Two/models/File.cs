using Exercise_Two.views;
using System;
using System.IO;

namespace Exercise_Two.models
{
    class File : IFile
    {
        private FileInfo file { get; set; }
        private FileStream stream { get; set; }
        private StreamReader content{ get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string extension { get; set; }

        public File(string name, string extension)
        {
            this.name       = name;
            this.extension  = extension;

            this.path = string.Format(
                @"{0}.{1}",
                this.name, this.extension
                );
            this.file = new FileInfo(this.path);
        }
        public void create()
        {
            this.stream = (FileStream)this.file.Create();
            this.stream.Close();
        }

        public void delete()
        {
            if (this.file.Exists)
            {
                this.file.Delete();
            }
        }

        public void print()
        {
            string str;

            if (this.file.Exists)
            {

                this.content = this.file.OpenText();

                while ((str = this.content.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }

            }
        }
    }
}
