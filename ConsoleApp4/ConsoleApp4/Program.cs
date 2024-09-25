using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();
        Console.WriteLine("Nhap ten va diem cua hoc sinh (nhap 'x' de dung):");

        // Nhap ten va diem tu nguoi dung
        while (true)
        {
            Console.Write("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") // Nhap 'x' de dung
                break;

            Console.Write("Nhap diem cua hoc sinh: ");
            if (int.TryParse(Console.ReadLine(), out int score))
                students[name] = score; // Them ten va diem vao Dictionary
            else
                Console.WriteLine("Diem khong hop le, vui long thu lai.");
        }

        // Hien thi danh sach hoc sinh va diem
        Console.WriteLine("Danh sach hoc sinh va diem:");
        foreach (var student in students)
        {
            Console.WriteLine($"Ten: {student.Key}, Diem: {student.Value}");
        }
    }
}
