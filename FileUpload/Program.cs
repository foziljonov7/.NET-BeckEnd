//using System.Text;

//string filePath = "D:/test.txt";

////var file = new FileInfo(filePath);

////Console.WriteLine(file.Name);
////Console.WriteLine(file.Length);
////Console.WriteLine(file.LastWriteTime);


////if(File.Exists(filePath)) // fayl mavjudmi yoqmi tekshiradi
////{
////    File.Delete(filePath);
////}

//using(FileStream sw2 = new FileStream(filePath, FileMode.Create))
//{
//    Console.WriteLine("Fayl yaratildi");
//}


//using (FileStream sw1 = new FileStream(filePath, FileMode.Open))
//{
//    byte[] bytes = new byte[1024];
//    int read = sw1.Read(bytes, 0, bytes.Length);

//    string readFile = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
//    Console.WriteLine(readFile);
//}
//using (FileStream sw = new FileStream(filePath, FileMode.Append))
//{
//    string fileData = "Assalomu aleykum";
//    byte[] fileBytes = Encoding.UTF8.GetBytes(fileData);
//    sw.Write(fileBytes, 0, fileBytes.Length);
//    Console.WriteLine("Malumot yozildi");
//}
//try
//{
//    string path2 = "D:/dev/test.txt";
//    var file = new FileInfo(filePath);

//    Console.WriteLine($"{file.Name}");
//    Console.WriteLine($"{file.LastAccessTime}");
//    Console.WriteLine($"{file.CopyTo(path2, true)}");
//}
//catch(IOException ex)
//{
//    Console.WriteLine($"Fayl bilan ishlashda xatolik yuzberdi {ex}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex);
//}


using System.Reflection.Metadata;

int a = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine(a / 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

