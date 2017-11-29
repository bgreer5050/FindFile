class Program
    {
        static void Main(string[] args)
        {
            var fileList = new DirectoryInfo(@"c:\Repos").GetFiles("*.csproj", SearchOption.AllDirectories);


            fileList = fileList.OrderByDescending(c => c.CreationTime).ToArray();

            foreach (FileInfo file in fileList)
            {
                Console.WriteLine(file.FullName);
                Console.ReadLine();

            }


        }
    }
