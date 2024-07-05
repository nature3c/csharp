using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader inFp;
            //StreamWriter outFp;

            //inFp = new StreamReader("C:\\Windows\\win.ini"); //what should be read
            //outFp = new StreamWriter("C:\\Users\\Administrator\\Desktop\\data2.txt"); //where the output going to go

            //while(true)
            //{ 
            //    string inStr = inFp.ReadLine(); //read what is there
            //    if (inStr == null) break; //copy evverything and break if theres nothing left
            //    outFp.WriteLine(inStr); //paste the contents into the specified file
            //}

            //inFp.Close();
            //outFp.Close();
            //Console.WriteLine("---- Copy Completes ----");

            //command line exercise
            //while (true)
            //{
            //    Console.Write("C:\\Users\\Administrator> ");
            //    string[] command = Console.ReadLine().Split(' ');
            //    if (command[0].CompareTo("type") == 0) // 콘솔 창에 내용 출력
            //    {
            //        if (File.Exists(command[1]))
            //        {
            //            StreamReader inFp = new StreamReader(command[1]);
            //            while (true)
            //            {
            //                string inStr = inFp.ReadLine();
            //                if (inStr == null) break;
            //                Console.WriteLine(inStr);
            //            }
            //            inFp.Close();
            //        }
            //        else
            //        {
            //            Console.WriteLine("File does not exist");
            //        }
            //    }
            //    else if (command[0].CompareTo("copy") == 0) // 파일1을 파일2에 내용 복사
            //    {
            //        if (File.Exists(command[1]))
            //        {
            //            StreamReader inFp = new StreamReader(command[1]);
            //            StreamWriter outFp = new StreamWriter(command[2]);
            //            while (true)
            //            {
            //                string inStr = inFp.ReadLine();
            //                if (inStr == null) break;
            //                outFp.WriteLine(inStr);
            //            }
            //            inFp.Close();
            //            outFp.Close();
            //            Console.WriteLine("1 file copied");
            //        }
            //        else
            //        {
            //            Console.WriteLine("File does not exist");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a valid command");
            //    }
            //}


            //encrypt decrypt exercise
            //Console.Write("File Path: ");
            //string file = Console.ReadLine();

            //Console.Write("Output File: ");
            //string output = Console.ReadLine();

            //Console.Write("Mode selection (1 encryption, 2 decryption): ");
            //int mode = int.Parse(Console.ReadLine());

            //Console.Write("Key input (number): ");
            //int key = int.Parse(Console.ReadLine());

            //StreamReader inFp = new StreamReader(file);
            //StreamWriter outFp = new StreamWriter(output);

            //if (mode == 1)
            //{
            //    while (true)
            //    {
            //        string inStr = inFp.ReadLine();
            //        if (inStr == null) break;
            //        string outStr = "";
            //        foreach(char ch in inStr)
            //        {
            //            int code = (int)ch + key;
            //            outStr += (char)code;
            //        }

            //        outFp.WriteLine(outStr);
            //    }
            //}
            //else if(mode == 2)
            //{
            //    while (true)
            //    {
            //        string inStr = inFp.ReadLine();
            //        if (inStr == null) break;
            //        string outStr = "";
            //        foreach (char ch in inStr)
            //        {
            //            int code = (int)ch - key;
            //            outStr += (char)code;
            //        }

            //        outFp.WriteLine(outStr);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            //inFp.Close();
            //outFp.Close();

            //images using binarywriter
            //BinaryReader inFp;
            //BinaryWriter outFp;

            //String inFname = "D:\\andrew_C#\\images\\bird1.png";
            //String outFname = "C:\\Users\\Administrator\\Desktop\\example.png";

            //inFp = new BinaryReader(File.Open(inFname, FileMode.Open));
            //outFp = new BinaryWriter(File.Open(outFname, FileMode.Create));

            //long len = new FileInfo(inFname).Length;
            //for(long i = 0; i < len; i++)
            //{
            //    byte data = inFp.ReadByte();
            //    outFp.Write(data);
            //}

            //inFp.Close();
            //outFp.Close();
            //Console.WriteLine("--- Binary file copied ---");

            //folder manipulation
            //string folder1 = "C:\\Temp\\";
            //if(!Directory.Exists(folder1))
            //{
            //    Directory.CreateDirectory(folder1);
            //    Console.WriteLine(folder1  + "did not exist and was created.");
            //}

            //string file1 = "C:\\Windows\\write.exe";
            //string file2 = "C:\\Users\\Administrator\\Desktop\\write.exe";
            //if(!File.Exists(file2))
            //{
            //    File.Copy(file1, file2);
            //    Console.WriteLine(file1 + " was copied to " + file2);
            //}

            //string folder2 = "C:\\Users\\Administrator\\Dekstop\\TempFolder\\";
            //if (!Directory.Exists(folder2))
            //{
            //    Directory.CreateDirectory(folder2);
            //    Console.WriteLine(folder2 + " did not exist and was created.");
            //}

            //string file3 = folder2 + "write.exe"; //desktop --> TempFolder --> write.exe
            //if (File.Exists(file2) && !File.Exists(file3))
            //{
            //    File.Move(file2, file3);
            //    Console.WriteLine(file2 + " was moved to " + file3);
            //}

            //string folder3 = "C:\\Users\\Administrator\\Dekstop\\TempFolder2\\";
            //if(Directory.Exists(folder2)  && !Directory.Exists(folder3))
            //{
            //    Directory.Move(folder2, folder3);
            //    Console.WriteLine(folder2 + " was moved to " + folder3);
            //}

            //if (File.Exists(file2)) //desktop write.exe
            //{
            //    File.Delete(file2);
            //    Console.WriteLine(file2 + " was deleted");
            //}

            //if(Directory.Exists(folder3)) //desktop tempfolder2
            //{
            //    File.Delete(folder3);
            //    Console.WriteLine(file2 + " was deleted");
            //}

            //directories and file name retrieval
            //string folder = "C:\\Windows\\Help";
            //string[] fileAry = new string[] { };
            //string[] dirAry = new string[] { };

            //DirectoryInfo dInfo = new DirectoryInfo(folder);
            //DirectoryInfo[] dirs = dInfo.GetDirectories("*.*", SearchOption.AllDirectories);

            //foreach(DirectoryInfo d in dirs)
            //{
            //    Array.Resize(ref dirAry, dirAry.Length + 1);
            //    dirAry[dirAry.Length - 1] = d.Name;

            //    foreach(FileInfo f in d.GetFiles())
            //    {
            //        Array.Resize(ref fileAry, fileAry.Length + 1);
            //        fileAry[fileAry.Length - 1] += f.FullName;
            //    }
            //}

            //Console.WriteLine("------ Directories found : {0} -------", dirAry.Length);
            //foreach(string dName in dirAry)
            //{
            //    Console.WriteLine(dName);
            //}
            //Console.WriteLine("\n------ Files found : {0} ------", fileAry.Length);
            //foreach(string fName in fileAry)
            //{
            //    Console.WriteLine(fName);
            //}



            //file information
            //string fileName = "C:\\Users\\Administrator\\Desktop\\data1.txt";
            //FileInfo fileInfo = new FileInfo(fileName);

            //string onlyName = fileInfo.Name;
            //Console.WriteLine("File name\t: " + onlyName);

            //string fullName = fileInfo.FullName;
            //Console.WriteLine("File  full name\t: " + fullName);

            //string extn = fileInfo.Extension;
            //Console.WriteLine("Extension\t: " + extn);

            //string dirName = fileInfo.DirectoryName;
            //Console.WriteLine("Directory name\t: " + dirName);

            //bool exists = fileInfo.Exists;
            //Console.WriteLine("File exists\t: " + exists);

            //long size = fileInfo.Length;
            //Console.WriteLine("File size\t: " + size + " bytes");

            //bool isreadonly = fileInfo.IsReadOnly;
            //Console.WriteLine("Read only\t: " +  isreadonly);

            //DateTime creationTime  = fileInfo.CreationTime;
            //Console.WriteLine("Creation Time\t: " + creationTime);

            //DateTime updateTime = fileInfo.LastWriteTime;
            //Console.WriteLine("Last edited\t: " + updateTime);

            //DateTime accessTime = fileInfo.LastAccessTime;
            //Console.WriteLine("Last accessed\t: " +  accessTime);



            //cmd dir command exercise
            string folderName = "C:\\Users\\Administrator\\Desktop";
            DirectoryInfo dInfo = new DirectoryInfo(folderName);
            long sum = 0;
            int fileCount = 0;
            int dirCount = 0;

            foreach(FileInfo f in dInfo.GetFiles())
            {
                DateTime lastWriteTime = f.LastWriteTime;
                long size = f.Length;
                string name = f.Name;
                Console.WriteLine("{0:G}\t{1,16:##,##}\t{2}", lastWriteTime, size, name);
            }

            foreach (FileInfo f in dInfo.GetFiles())
            {
                long size = f.Length;
                sum += size;
                fileCount++;
            }

            DirectoryInfo[] dirs = dInfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
            foreach (DirectoryInfo dir in dirs)
            {
                DateTime lastWriteTime = dir.LastWriteTime;
                Console.WriteLine("{0:G}\t<DIR>\t\t\t{1}", lastWriteTime, dir.Name);
                dirCount++;
            }

            Console.WriteLine("\t\t{0} files\t {1} bytes", fileCount, sum);
            Console.WriteLine("\t\t{0} directories", dirCount);



            //different date time displays
            //FileInfo fileInfo = new FileInfo("C:\\Users\\Administrators\\Desktop\\data1.txt");
            //DateTime updateTime = fileInfo.LastWriteTime;
            //Console.WriteLine("T {0:T}", updateTime);
            //Console.WriteLine("t {0:t}", updateTime);
            //Console.WriteLine("G {0:G}", updateTime);
            //Console.WriteLine("g {0:g}", updateTime);
            //Console.WriteLine("F {0:F}", updateTime);
            //Console.WriteLine("f {0:f}", updateTime);
            //Console.WriteLine("D {0:D}", updateTime);
            //Console.WriteLine("d {0:d}", updateTime);
            //Console.WriteLine("s {0:s}", updateTime);
            //Console.WriteLine("o {0:o}", updateTime);
            //Console.WriteLine("u {0:u}", updateTime);
        }
    }
}
