using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        Console.WriteLine("Nhap cac so nguyen (nhap 'x' de dung):");

        // Nhap so tu nguoi dung va them vao ArrayList
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "x") // Nhap 'x' de dung
                break;

            if (int.TryParse(input, out int number))
                numbers.Add(number); // Them so vao ArrayList
            else
                Console.WriteLine("Vui long nhap mot so hop le.");
        }

        // Sap xep danh sach theo thu tu tang dan
        numbers.Sort();

        // In ra danh sach sau khi sap xep
        Console.WriteLine("Danh sach cac so da nhap (theo thu tu tang dan):");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
