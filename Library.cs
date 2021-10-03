using System;
using System.Collections.Generic;
namespace Library
{
	public class Program
	{
		public static void Main()
		{
			homepage(); //หน้าแรก
			Console.Clear(); //เคลียร์หน้า
			homepage(); //หน้าแรก
		}
		public static void homepage()
		{
			Console.WriteLine("Welcome to Digital Library");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("--------------------------------");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("1.Login"); //กด1เพื่อเข้าสู่ระบบ
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("2.Register"); //กด2เพื่อสมัคร
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("Select Menu: "); //ให้เลือกระหว่าง1หรือ2
			int selectmenu = Convert.ToInt32(Console.ReadLine());
			switch (selectmenu)
			{
				case 1:
					{
						Console.Clear(); //เคลียร์หน้า
						login(); //เรียกใช้เมธอดเข้าสู้ระบบบ
						break;
					}
				case 2:
					{
						Console.Clear(); //เคลียร์หน้า
						register(); ////เรียกใช้เมธอดสมัคร
						break;
					}
			}
		}

		public static void login() //หน้าเข้าสู่ระบบ
		{
			Console.WriteLine("Login Screen");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("----------------");

		}
		public static void register()
		{
			Console.WriteLine("Register new Person");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("-------------------------");
			Console.WriteLine(""); //เว้นบรรทัด
			name(); //เรียกใช้เมธอดชื่อ
			pass(); //เรียกใช้เมธอดรหัสผ่าน
			type(); //เรียกใช้เมธอดประเภทผู้ใช้
		}

		public static void name() //เมธอดชื่อ
		{
			Console.Write("Input Name : ");
			string inputname = Convert.ToString(Console.ReadLine());
			
		}
		public static void pass() //เมธอดรหัสผ่าน
		{
			Console.Write("Input Password : ");
			string inputpass = Convert.ToString(Console.ReadLine());
		}
		public static void stdid() //เมธอดไอดีนักศึกษา
		{
			Console.Write("Student ID : ");
			string inputstdid = Convert.ToString(Console.ReadLine());
		}
		public static void empid() //เมธอดไอดีพนักงาน
		{
			Console.Write("Employee ID : ");
			string inputempid = Convert.ToString(Console.ReadLine());
		}

		public static void type() //เมธอดประเภทผู้ใช้
		{
			Console.Write("Input User Type 1 = Student, 2 = Employee :");
			int type = Convert.ToInt32(Console.ReadLine());
			switch (type)
			{
				case 1:
					{
						stdid(); //เรียกใช้เมธอดไอดีนักศึกษา
						break;
					}
				case 2:
					{
						empid(); //เรียกใช้เมธอดไอดีพนักงาน
						break;
					}
			}
		}

	}
}
