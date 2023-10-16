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
    public class DAL_KhachHangTests
    {
        [TestMethod()]
        public void insertKHTest001()
        {
            // login thiếu số điện thoại
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang() 
            {
                phai = "Nam",

                tenKhach = "ab",
                diaChi = "a",
                emailNV = "nexeker123@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);
        }
        [TestMethod()]

        public void insertKHTest002()
        {
            // login thiếu tên
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                phai = "Nam",

                soDienThoai = "012345678912",
                diaChi = "a",
                emailNV = "nexeker123@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }

        [TestMethod()]

        public void insertKHTest003()
        {
            // login thiếu địa chỉ
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                phai = "Nam",
                soDienThoai = "012345678912",
                tenKhach = "ab",
                emailNV = "nexeker123@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }
        [TestMethod()]

        public void insertKHTest004()
        {
            // login thiếu phái
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                soDienThoai = "012345678912",
                tenKhach = "ab",
                emailNV = "nexeker123@gmail.com",
                diaChi = "a"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }
        [TestMethod()]

        public void insertKHTest005()
        {
            // login thành công
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                soDienThoai = "012345678912",
                tenKhach = "ab",
                diaChi = "a",
                phai = "Nam",
                emailNV = "nexeker123@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsTrue(result);

        }


    }
}