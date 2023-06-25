using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Листинг_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Выводим информацию о диске
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"c:\");
            listBox1.Items.Clear();
            listBox1.Items.Add("Диск: " + drv.Name);

            if (drv.IsReady)
            {
                listBox1.Items.Add("Тип диска: " + drv.DriveType.ToString());
                listBox1.Items.Add("Файловая система: " +
                drv.DriveFormat.ToString());
                listBox1.Items.Add("Свободное место на диске: " +
                drv.AvailableFreeSpace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получим список папок на диске D:
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"c:\");
            foreach (string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получим список папок, где встречается буквосочетание pro
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"c:\");
            System.IO.DirectoryInfo[] folders = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folders)
                listBox1.Items.Add(maskdirs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                listBox1.Items.Add( "Папка " + @"C:\Windows" + " существует");
            else
                listBox1.Items.Add("Папка не существует");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Переименовываем папку MyFolder в папку NewFolder
            string oldPathString = @"C:\MyFolder";
            string newPathString = @"C:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Попытаемся удалить папку C:\WUTEMP
                System.IO.Directory.Delete(@"c:\wutemp");
                MessageBox.Show("Папка удалена.");
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить непустую папку.");
            }
            finally { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // задаем папку верхнего уровня
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            // Заголовок в диалоговом окне
            fbd.Description = "Выберите папку";
            // Не выводим кнопку Новая папка
            fbd.ShowNewFolderButton = false;
            // Получаем папку, выбранную пользователем
            if (fbd.ShowDialog() == DialogResult.OK)
                this.Text = fbd.SelectedPath;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Получим информацию о свойствах папки
            System.IO.DirectoryInfo dir = new
            System.IO.DirectoryInfo(@"c:\wutemp");
            listBox1.Items.Clear();
            listBox1.Items.Add("Проверка папки: " + dir.Name);
            listBox1.Items.Add("Родительская папка: " + dir.Parent.Name);
            listBox1.Items.Add("Папка существует: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("Папка создана: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("Папка изменена: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("Время последнего доступа: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("Атрибуты папки: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("Папка содержит: " +
                dir.GetFiles().Length.ToString() + " файла");
            }
        }

        static long GetDirectorySize(System.IO.DirectoryInfo directory,bool includeSubdir)
        {
            long totalSize = 0;
            // Считаем все файлы
            System.IO.FileInfo[] files = directory.GetFiles();
            foreach (System.IO.FileInfo file in files)
            {
                totalSize += file.Length;
            }
            // Считаем все подпапки
            if (includeSubdir)
            {
                System.IO.DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (System.IO.DirectoryInfo dir in dirs)
                {
                    totalSize += GetDirectorySize(dir, true);
                }
            }
            return totalSize;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.IO.DirectoryInfo dir = new
            System.IO.DirectoryInfo(@"c:\help");
            listBox1.Items.Add ("Общий размер: " +
            GetDirectorySize(dir, true).ToString() + " байт.");
            this.Cursor = Cursors.Default;
        }

        private void FillNodes(TreeNode dirNode)
        {
            DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
            foreach (DirectoryInfo dirItem in dir.GetDirectories())
            {
                // Добавляем узел для каждой папки
                TreeNode newNode = new TreeNode(dirItem.Name);
                dirNode.Nodes.Add(newNode);
                newNode.Nodes.Add("*");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Заполняем первый узел. Используем диск C:
            TreeNode rootNode = new TreeNode(@"C:\");
            treeDirectory.Nodes.Add(rootNode);
            // Заполнеяем первый уровень и раскрываем его
            FillNodes(rootNode);
            treeDirectory.Nodes[0].Expand();
        }

        private void treeDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Если найден узел со звездочкой *, то удаляем его
            // и получаем список подпапок.
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillNodes(e.Node);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] directoryEntries = System.IO.Directory.GetFileSystemEntries(@"c:\windows");
            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\", "*.in?");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\test.txt"))
                listBox1.Items.Add ("Файл test.txt существует");
            else
                listBox1.Items.Add("Файл test.txt не существует");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Имя файла с расширением
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            // Имя файла без расширения
            listBox1.Items.Add(
            System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Получим расширение файла
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // путь к тестовому файлу
            string path = @"c:\WUTEMP\test.txt";
            // если файлы имел атрибут Скрытый
            if ((System.IO.File.GetAttributes(path) & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
            {
                // то устанавливаем атрибут Normal
                System.IO.File.SetAttributes(path,
                System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);
            }
            else // если файл не был скрытым
            {
                // то устанавливаем у файла атрибут Скрытый
                System.IO.File.SetAttributes(path,
                System.IO.File.GetAttributes(path) |
                System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Выводим информацию о файле.
            System.IO.FileInfo file = new
            System.IO.FileInfo(@"c:\wutemp\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.FileVersionInfo info = System.Diagnostics.FileVersionInfo.GetVersionInfo(@"C:\windows\system32\mspaint.exe");
            // Выводим информацию о выбранном файле
            listBox1.Items.Add("Выбранный файл: " + info.FileName);
            listBox1.Items.Add("Product Name: " + info.ProductName);
            listBox1.Items.Add("Product Version: " + info.ProductVersion);
            listBox1.Items.Add("Company Name: " + info.CompanyName);
            listBox1.Items.Add("File Version: " + info.FileVersion);
            listBox1.Items.Add("File Description: " + info.FileDescription);
            listBox1.Items.Add("Original Filename: " + info.OriginalFilename);
            listBox1.Items.Add("Legal Copyright: " + info.LegalCopyright);
            listBox1.Items.Add("InternalName: " + info.InternalName);
            listBox1.Items.Add("IsDebug: " + info.IsDebug);
            listBox1.Items.Add("IsPatched: " + info.IsPatched);
            listBox1.Items.Add("IsPreRelease: " + info.IsPreRelease);
            listBox1.Items.Add("IsPrivateBuild: " + info.IsPrivateBuild);
            listBox1.Items.Add("IsSpecialBuild: " + info.IsSpecialBuild);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Создаем временный файл
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string randomFile = System.IO.Path.GetRandomFileName();
            MessageBox.Show(randomFile); // вернет что-то типа 5wvzx2n0.lby
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string tempText = System.IO.Path.ChangeExtension(System.IO.Path.GetRandomFileName(), ".txt");
            MessageBox.Show(tempText);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\text.txt";
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Указанный файл уже существует.", fileName);
                return;
            }
            System.IO.StreamWriter sr = System.IO.File.CreateText(fileName);
            sr.WriteLine("Раз, два, три, четыре, пять");
            sr.WriteLine("1, 2, 3. 9 1/2 и так далее");
            sr.WriteLine("Я изучаю {0} и {1}.", "C#", "Visual Basic");
            sr.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // Создадим экземпляр StreamReader для чтения из файла
            using (System.IO.StreamReader sr =
            new System.IO.StreamReader(@"c:\wutemp\text.txt"))
            {
                String line;
                // Читаем каждую строку, пока не достигнем конца файла
                while ((line = sr.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\text.txt";
            // Добавляем одну строчку в текстовый файл
            using (System.IO.StreamWriter sw =
            System.IO.File.AppendText(fileName))
            {
                sw.WriteLine("Добавили еще одну строчку");
            }
            // Прочитаем текст из файла
            using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    MessageBox.Show(s);
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int index = 2;
            //номер строки, с которой начинать
            string path = @"c:\wutemp\text.txt"; //путь к файлу
            string[] allLines = System.IO.File.ReadAllLines(path);
            for (int i = index; i < allLines.Length - 1; i++)
            {
                listBox1.Items.Add(allLines[i]);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(@"c:\wutemp\text.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    sb.AppendLine(sr.ReadLine());
                }
            }
            listBox1.Items.Add(sb.ToString());

        }

        private void button33_Click(object sender, EventArgs e)
        {
            // Получение данных из файла с использованием метода ReadAllText
            listBox1.Items.Add(File.ReadAllText(@"c:\wutemp\text.txt"));
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
        private struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)]
            public int wFunc;
            public string pFrom;
            public string pTo;
            public short fFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            public string lpszProgressTitle;
        }
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHFileOperation(ref SHFILEOPSTRUCT fileOp);
        // константы для SHFileOperation
        private const int FO_DELETE = 3;
        private const int FOF_ALLOWUNDO = 64;
        private const int FOF_NOCONFIRMATION = 16;
        public static int MoveToRecycleBin(string path)
        {
            SHFILEOPSTRUCT fop = new SHFILEOPSTRUCT();
            fop.wFunc = FO_DELETE;
            fop.pFrom = path + "\0"; // без дополнительного \0 не работает
            fop.fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMATION;
            return SHFileOperation(ref fop);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            // Удаляем файл в корзину
            MoveToRecycleBin(@"c:\wutemp\text.txt");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            FileSystem.DeleteFile("c:/temp.txt",UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
        }
    }
}
