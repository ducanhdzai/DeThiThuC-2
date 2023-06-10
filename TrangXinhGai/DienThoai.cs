using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangXinhGai
{
    [Serializable]
    internal class DienThoai
    {
        private int id;
        private string ten;
        private string nhaSX;


        public DienThoai()
        {

        }

        public DienThoai(int id, string ten, string nhaSX)
        {
            this.id = id;
            this.ten = ten;
            this.nhaSX = nhaSX;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NhaSX { get => nhaSX; set => nhaSX = value; }

        public void InThongTin()
        {
            Console.WriteLine($"ID: {id}     Tên: {ten}      Nhà sản xuất: {nhaSX} ");
        }
    }
}
