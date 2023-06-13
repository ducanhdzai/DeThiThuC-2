using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrangXinhGai
{
    internal class SERVICES
    {
        List<DienThoai> _lstDienThoai = new List<DienThoai>();
        FileStream _fS;
        BinaryFormatter _bF = new BinaryFormatter();
        string filePath = @"C:\Users\Duc Anh\Desktop\Learn_to_Work\TrangXinhGai\TrangXinhGai\data.bin";
        public void Add()
        {
            DienThoai dt = new DienThoai();
            string idTest ;
            do
            {
                Console.WriteLine("Moi ban nhap id dien thoai: ");
                idTest = Console.ReadLine();
                if (Regex.IsMatch(idTest, @"^[0-9]+$") && idTest.Length == 5)
                {
                    dt.Id = Convert.ToInt32(idTest);
                }
            } while (!Regex.IsMatch(idTest, @"^[0-9]+$") || idTest.Length != 5);
            Console.WriteLine("Moi ban nhap ten dien thoai: ");
            dt.Ten = Console.ReadLine();
            Console.WriteLine("Moi ban nhap NSX dien thoai: ");
            dt.NhaSX = Console.ReadLine();
            _lstDienThoai.Add(dt);
        }
        public void Show()
        {
            foreach (var item in _lstDienThoai)
            {
                item.InThongTin();
            }
        }
        public void ShowOrderByName()
        {
            foreach (var item in _lstDienThoai.OrderBy(c => c.Ten))
            {
                item.InThongTin();
            }
        }
        public void DeleteUseLinQ()
        {
            Console.WriteLine("Moi ban nhap ID muon tim");
            _lstDienThoai.Remove(_lstDienThoai.FirstOrDefault(c => c.Id == Convert.ToInt32(Console.ReadLine())));
        }
        public void SaveFile()
        {
            _fS = new FileStream(filePath, FileMode.OpenOrCreate);
            _bF.Serialize(_fS, _lstDienThoai);
            _fS.Close();
            Console.WriteLine("Save File Successfully!");
        }
        public List<DienThoai> ReadFile()
        {
            _fS = new FileStream(filePath,FileMode.Open,FileAccess.Read);
            var data = _bF.Deserialize(_fS) as List<DienThoai>;
            _fS.Close();
            return data;
        }
    }
}
