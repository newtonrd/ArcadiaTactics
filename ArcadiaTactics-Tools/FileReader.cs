using System;
using System.IO;

namespace ArcadiaTactics_Tools
{
    public class FileReader
    {
        public enum FileType
        {
            STORY
        }

        private const string STATIC_FILE_LOCATION = @"../../../../ArcadiaTactics-Static/";
        private const string STORY_LOCATION = @"Text/Stories/";

        public FileReader()
        {
        }

        public static void PrintAllFiles_DEBUG()
        {

            var stories = Directory.GetParent(STATIC_FILE_LOCATION + STORY_LOCATION).EnumerateFiles();
            foreach (var story in stories)
            {
                Console.WriteLine(story);
            }
        }

        /// <summary>
        /// Read the provided file 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReadFile(FileType fileType, string fileName)
        {
            string fileString;
            try
            {
                var path = GetPathFromFileType(fileType);
                using StreamReader sr = new StreamReader(path + fileName);
                fileString = sr.ReadToEnd();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The provided fileName could not be found: {fileName}");
                Console.WriteLine(ex.Message);

                fileString = string.Empty;
            }

            return fileString;
        }

        /// <summary>
        /// Get string path for the provided fileType
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static string GetPathFromFileType(FileType type)
        {
            switch (type)
            {
                case FileType.STORY:
                    return STATIC_FILE_LOCATION + STORY_LOCATION;

                default:
                    return string.Empty;
            }
        }
    }
}
