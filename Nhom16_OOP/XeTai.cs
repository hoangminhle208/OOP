﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom16_OOP
{
    class XeTai:Xe
    {
        //field
        private double trongTai;
        //property
        public double TrongTai { get { return trongTai; } set { trongTai = value; } }
        //constructor
        public XeTai():base()
        {
            trongTai = 0;
        }
        //constructor
        public XeTai(double tocDo,string bienSo,string hang,double trongTai) : base(tocDo, bienSo, hang)
        {
            TrongTai = trongTai;
        }
        //ham nhap xe
        public override void Nhap1Xe()
        {
            base.Nhap1Xe();
            do {
                Console.Write("Nhap trong tai cua xe:");
                TrongTai = double.Parse(Console.ReadLine());
               }
            while (TrongTai < 0);
            soLuong++;
        }
        //ham xuat xe
        public override void Xuat1Xe()
        {
            base.Xuat1Xe();
            Console.WriteLine("Trong tai cua xe {0} tan",TrongTai);
        }
        //ham dem so luong
        public override int Dem()
        {
            return soLuong;
        }
        public override void ThongKe()
        {
            string k=$"So xe tai: {Dem()}";
            Console.WriteLine(k);
        }
        public override string XuatTrongTai()
        {
            return $"{TrongTai}";
        }
        public override string XuatSoGhe()
        {
            return "";
        }
    }
}
