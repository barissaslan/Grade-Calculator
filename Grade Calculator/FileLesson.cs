using System;
using System.IO;

namespace Grade_Calculator
{
    class FileLesson
    {
        static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static string filePath = documentsPath + @"\Grade Calculator\Lessons";
        static string namePath = filePath + @"\names";
        static string gradePath = filePath + @"\grades";
        static string letterPath = filePath + @"\letters";
        static string datePath = filePath + @"\dates";
        static string indexPath = filePath + @"\index";

        public static int Index
        {
            get
            {
                StreamReader reader = new StreamReader(indexPath);
                int index = int.Parse(reader.ReadLine());
                reader.Close();
                return index;
            }
            private set
            {
                StreamWriter writer = new StreamWriter(indexPath);
                writer.WriteLine(value);
                writer.Close();
            }
        }

        public static void checkFiles()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            if (!File.Exists(indexPath))
            {
                Index = 0;
            }
        }

        public static void writeLesson(string name, double grade, string letter)
        {
            StreamWriter writer = new StreamWriter(namePath, true);
            writer.WriteLine(name);
            writer.Close();

            writer = new StreamWriter(gradePath, true);
            writer.WriteLine(grade);
            writer.Close();

            writer = new StreamWriter(letterPath, true);
            writer.WriteLine(letter);
            writer.Close();

            writer = new StreamWriter(datePath, true);
            writer.WriteLine(DateTime.Now.ToShortDateString());
            writer.Close();

            Index++;
        }

        public static string[] getLine(int lineIndex)
        {
            StreamReader nameReader = new StreamReader(namePath);
            StreamReader gradeReader = new StreamReader(gradePath);
            StreamReader letterReader = new StreamReader(letterPath);
            StreamReader dateReader = new StreamReader(datePath);
            string[] line = new string[4];
            for (int i = 0; i < lineIndex + 1; i++)
            {
                line[0] = nameReader.ReadLine();
                line[1] = double.Parse(gradeReader.ReadLine()).ToString("00.00");
                line[2] = letterReader.ReadLine();
                line[3] = dateReader.ReadLine();
            }
            nameReader.Close();
            gradeReader.Close();
            letterReader.Close();
            dateReader.Close();
            return line;
        }

        public static void removeLesson(int index)
        {
            removeItem(namePath, index);
            removeItem(gradePath, index);
            removeItem(letterPath, index);
            removeItem(datePath, index);

            Index--;
        }

        private static void removeItem(string filePath, int index)
        {
            StreamReader reader = new StreamReader(filePath);
            StreamWriter writer = new StreamWriter(filePath + "Temp");

            for (int i = 0; i < Index; i++)
            {
                string item = reader.ReadLine();
                if (i == index) continue;
                writer.WriteLine(item);
            }

            reader.Close();
            writer.Close();
            File.Delete(filePath);
            File.Move(filePath + "Temp", filePath);
        }

    }
}
