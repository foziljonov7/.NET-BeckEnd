﻿//using Lesson16;

//string nomi = Console.ReadLine();
//string turi = Console.ReadLine();

//Animal animal = new Animal()
//{
//    Nomi = nomi,
//    Turi = turi
//};

//animal.Nomi = "Mol";

//Console.WriteLine(animal.Nomi + " " + animal.Turi);

//Fayllar biln ishlash
//string path = Console.ReadLine();

//var file = new FileInfo(path);

//if(file.Exists)
//{
//    var fi1 = new FileInfo(path);

//    // Create a file to write to.
//    using (StreamWriter sw = fi1.CreateText())
//    {
//        sw.WriteLine("Hello");
//        sw.WriteLine("And");
//        sw.WriteLine("Welcome");
//    }

//    // Open the file to read from.
//    using (StreamReader sr = fi1.OpenText())
//    {
//        var s = "";
//        while ((s = sr.ReadLine()) != null)
//        {
//            Console.WriteLine(s);
//        }
//    }

//    try
//    {
//        string path2 = Path.GetTempFileName();
//        var fi2 = new FileInfo(path2);

//        // Ensure that the target does not exist.
//        fi2.Delete();

//        // Copy the file.
//        fi1.CopyTo(path2);
//        Console.WriteLine($"{path} was copied to {path2}.");

//        // Delete the newly created file.
//        fi2.Delete();
//        Console.WriteLine($"{path2} was successfully deleted.");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"The process failed: {e.ToString()}");
//    }
//    Console.ReadKey();
//}

//FileInfo file = new FileInfo(path);

//if (file.Exists)
//    Console.WriteLine(file.CreationTime);
//else
//    Console.WriteLine("Bunday fayl mavjud emas!");



