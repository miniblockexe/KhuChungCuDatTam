using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KhuChungCuDatTam.Data
{
    public static class HashHelper
    {
        public static string SHA256Hash(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static bool XacMinhMatKhau(string matKhauNhap, string hashDaLuu)
        {
            return SHA256Hash(matKhauNhap) == hashDaLuu;
        }

        public static (bool IsValid, string ThongBao) KiemTraDoManhMatKhau(string matKhau)
        {
            if (string.IsNullOrEmpty(matKhau))
                return (false, "Mật khẩu không được để trống.");
            if (matKhau.Length < 8)
                return (false, "Mật khẩu phải có ít nhất 8 ký tự.");
            if (!Regex.IsMatch(matKhau, @"[A-Z]"))
                return (false, "Mật khẩu phải có ít nhất 1 chữ hoa (A-Z).");
            if (!Regex.IsMatch(matKhau, @"[a-z]"))
                return (false, "Mật khẩu phải có ít nhất 1 chữ thường (a-z).");
            if (!Regex.IsMatch(matKhau, @"\d"))
                return (false, "Mật khẩu phải có ít nhất 1 chữ số (0-9).");
            if (!Regex.IsMatch(matKhau, @"[!@#$%^&*()_+\-=\[\]{}|;':"",./<>?]"))
                return (false, "Mật khẩu phải có ít nhất 1 ký tự đặc biệt (!@#$...).");

            return (true, "Mật khẩu hợp lệ.");
        }
    }
}
