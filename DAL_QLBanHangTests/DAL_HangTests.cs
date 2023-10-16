using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;
namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_HangTests
    {
        [TestMethod()]
        public void insertHangTest001()
        {
            // thiếu tên
            DAL_Hang add = new DAL_Hang();
            DTO_Hang hang = new DTO_Hang() 
            {
                soLuong = 1,
                donGiaBan = 11,
                donGiaNhap = 1,
                email = "nexeker123@gmail.com",
                hinhAnh = "help.jpg",
                ghiChu = "a"

            };
            bool result = add.insertHang(hang);
            Assert.IsFalse(result);
        }



        [TestMethod()]
        public void insertHangTest002()
        {
            // thiếu 
            DAL_Hang add = new DAL_Hang();
            DTO_Hang hang = new DTO_Hang()
            {
                tenHang = "ab",
                soLuong = 1,
                donGiaBan = 11,
                donGiaNhap = 1,
                email = "nexeker123@gmail.com",
                ghiChu = "a"

            };
            bool result = add.insertHang(hang);
            Assert.IsFalse(result);
        }



        [TestMethod()]
        public void insertHangTest003()
        {
            // thiếu ghi chu
            DAL_Hang add = new DAL_Hang();
            DTO_Hang hang = new DTO_Hang()
            {
                tenHang = "ab",
                soLuong = 1,
                donGiaBan = 11,
                donGiaNhap = 1,
                email = "nexeker123@gmail.com",
                hinhAnh = "help.jpg",

            };
            bool result = add.insertHang(hang);
            Assert.IsFalse(result);
        }



        [TestMethod()]
        public void insertHangTest004()
        {
            // thành công
            DAL_Hang add = new DAL_Hang();
            DTO_Hang hang = new DTO_Hang()
            {
                tenHang = "ab",
                soLuong = 1,
                donGiaBan = 11,
                donGiaNhap = 1,
                email = "nexeker123@gmail.com",
                hinhAnh = "help.jpg",
                ghiChu = "a"

            };
            bool result = add.insertHang(hang);
            Assert.IsTrue(result);
        }




    }
}