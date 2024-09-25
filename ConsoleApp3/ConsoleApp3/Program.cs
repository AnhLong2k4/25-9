using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable people = new Hashtable();
        Console.WriteLine("Nhap ten va tuoi cua moi nguoi (nhap 'x' de dung):");

        // Nhap ten va tuoi tu nguoi dung
        while (true)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") // Nhap 'x' de dung
                break;

            Console.Write("Nhap tuoi: ");
            if (int.TryParse(Console.ReadLine(), out int age))
                people.Add(name, age); // Them ten va tuoi vao Hashtable
            else
                Console.WriteLine("Tuoi khong hop le, vui long thu lai.");
        }

        // Hien thi danh sach ten va tuoi
        Console.WriteLine("Danh sach ten va tuoi da nhap:");
        foreach (DictionaryEntry entry in people)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }
    }
}
