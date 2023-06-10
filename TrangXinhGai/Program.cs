using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrangXinhGai
{
    internal class Program
    {
        static void menu()
        {
            SERVICES sv = new SERVICES();
            int choice;
            do
            {
                Console.WriteLine("1. Nhập danh sách đối tượng");
                Console.WriteLine("2. Xuất danh sách đối tượng");
                Console.WriteLine("3. Lưu file");
                Console.WriteLine("4. Đọc file");
                Console.WriteLine("5. Áp dụng LinQ để sắp xếp theo tên");
                Console.WriteLine("6. Áp dụng LinQ để xóa đối tượng trong danh sách");
                Console.WriteLine("0. Thoát.");
                Console.Write("Mời bạn chọn 1 mục: ");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhập danh sách đối tượng");
                        sv.Add();
                        break;
                    case 2:
                        Console.WriteLine("Xuất danh sách đối tượng");
                        sv.Show();
                        break;
                    case 3:
                        Console.WriteLine("Lưu file");
                        sv.SaveFile();
                        break;
                    case 4:
                        Console.WriteLine("Đọc file");
                        foreach (var item in sv.ReadFile())
                        {
                            item.InThongTin();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Áp dụng LinQ để sắp xếp theo tên");
                        sv.ShowOrderByName();
                        break;
                    case 6:
                        Console.WriteLine("Áp dụng LinQ để xóa đối tượng trong danh sách");
                        sv.DeleteUseLinQ();
                        break;
                    case 0:
                        Console.WriteLine("Thoát");
                        break;
                    default:
                        Console.WriteLine("Mục bạn chọn không có, vui lòng chọn lại!");
                        break;
                }
            } while (choice != 0);         
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            menu();
        }
    }
}
