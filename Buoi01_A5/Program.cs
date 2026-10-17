/*
 * Bài: Buoi01_A5 - Từ lưu đồ đến code: chu vi, diện tích hình chữ nhật
 * Sinh viên: Vương Thục Lan
 * MSSV: 31251022558
*/

namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập (tạm gán giá trị)
            double a = 5, b = 3;

            // Xử lý
            double cv = 2 * (a + b);
            double dt = a * b;
            double d = Math.Sqrt(a * a + b * b);

            // Xuất
            Console.WriteLine("Chiều dài = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Diện tích = " + dt);
            Console.WriteLine("Đường chéo = " + d);
            
        }
    }
}
