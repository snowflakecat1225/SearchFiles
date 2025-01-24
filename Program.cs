namespace SearchFiles
{
    class Program
    {
        private static readonly List<string> _searchResults = new();

        /*private static void SearchFile(string directory, string fileName)
        {
            var fullPath = Path.Combine(directory, fileName);
            
            if (File.Exists(fullPath))
                _searchResults.Add(fullPath);
            else
            {
                try
                {
                    var dirs = Directory.GetDirectories(directory);

                    if (dirs.Length != 0)
                        foreach (var dir in dirs)
                            SearchFile(dir, fileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }*/

        public static void Main()
        {
            /*SearchFile("/home/" + Environment.UserName, "Full_of_cookies.png"); //to check results of the program

            foreach (var result in _searchResults)
                Console.WriteLine(result);*/
            
            string directory = "/";
            try
            {
                foreach (var file in Directory.EnumerateFiles(directory, "ffmpeg", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file);
                }
            }
            catch
            {
                //to be honest i don't care :P
            }
        }
    }
}