using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai2
{
     public class MangSoNguyen
    {
        private List<int> mang;

        public int SoPhanTu
        {
            get { return mang.Count; }
        }

        public MangSoNguyen(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng.");
            }

            mang = new List<int>(arr);
        }

        // Lấy mảng hiện tại
        public int[] LayMang()
        {
            return mang.ToArray();
        }

        // Sắp xếp tăng
        public void SapXepTang()
        {
            mang.Sort();
        }

        // Sắp xếp giảm
        public void SapXepGiam()
        {
            mang.Sort();
            mang.Reverse();
        }

        // Tìm vị trí của giá trị
        public List<int> TimViTri(int giaTri)
        {
            List<int> viTri = new List<int>();

            for (int i = 0; i < mang.Count; i++)
            {
                if (mang[i] == giaTri)
                {
                    viTri.Add(i);
                }
            }

            return viTri;
        }

        // Tìm giá trị tại vị trí
        public int TimGiaTri(int viTri)
        {
            if (viTri < 0 || viTri >= mang.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí không hợp lệ.");
            }

            return mang[viTri];
        }

        // Thêm giá trị tại vị trí
        public void Them(int giaTri, int viTri)
        {
            if (viTri < 0 || viTri > mang.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí thêm không hợp lệ.");
            }

            mang.Insert(viTri, giaTri);
        }

        // Xóa theo giá trị
        public bool XoaGiaTri(int giaTri)
        {
            return mang.Remove(giaTri);
        }

        // Xóa theo vị trí
        public void XoaViTri(int viTri)
        {
            if (viTri < 0 || viTri >= mang.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí xóa không hợp lệ.");
            }

            mang.RemoveAt(viTri);
        }

        // Tổng mảng
        public long TinhTong()
        {
            long tong = 0;

            foreach (int x in mang)
            {
                tong += x;
            }

            return tong;
        }

        // Tổng số chẵn
        public long TinhTongChan()
        {
            long tong = 0;

            foreach (int x in mang)
            {
                if (x % 2 == 0)
                {
                    tong += x;
                }
            }

            return tong;
        }

        // Tổng số lẻ
        public long TinhTongLe()
        {
            long tong = 0;

            foreach (int x in mang)
            {
                if (x % 2 != 0)
                {
                    tong += x;
                }
            }

            return tong;
        }

        // Tìm giá trị lớn nhất
        public int TimMax()
        {
            if (mang.Count == 0)
            {
                throw new InvalidOperationException(
                    "Mảng đang rỗng.");
            }

            return mang.Max();
        }

        // Tìm giá trị nhỏ nhất
        public int TimMin()
        {
            if (mang.Count == 0)
            {
                throw new InvalidOperationException(
                    "Mảng đang rỗng.");
            }

            return mang.Min();
        }

        // Thay thế theo giá trị
        public int ThayTheGiaTri(int giaTriCu, int giaTriMoi)
        {
            int soLuong = 0;

            for (int i = 0; i < mang.Count; i++)
            {
                if (mang[i] == giaTriCu)
                {
                    mang[i] = giaTriMoi;
                    soLuong++;
                }
            }

            return soLuong;
        }

        // Thay thế theo vị trí
        public void ThayTheViTri(int viTri, int giaTriMoi)
        {
            if (viTri < 0 || viTri >= mang.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí thay thế không hợp lệ.");
            }

            mang[viTri] = giaTriMoi;
        }
    }
}