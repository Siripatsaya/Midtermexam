using System;
using System.Collections.Generic;
namespace HangMan
{
	public class HangManGame
	{
		public static void Main()
		{
			Homepage(); //หน้าแรก
			work(); //การทำงาน
		}

		public static void work() //เมธอดการทำงาน
		{
			string secretword = "Badminton"; //ข้อความลับ
			List<string> letterGuessed = new List<string>();
			int score = 0;
			Isletter(secretword, letterGuessed);
			while (score < 6) //คะแนนผิดต้องน้อยกว่า6ถึงจะมีสิทธิ์ชนะ
			{
				string input = Console.ReadLine();
				if (letterGuessed.Contains(input)) //ผู้ใช้รับค่าโดยเดาตัวอักษร
				{
					Console.Clear(); //เคลียร์หน้า
					Console.WriteLine("Play Game Hangman "); 
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("--------------------------");
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine("You Entered [{0}] already", input); //บอกว่าผู้ใช้ป้อนคำอะไรมา
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine("Try a Different Word"); //บอกผู้ใช้ว่าให้ลองเปลี่ยนเป็นคำอื่น
					Console.WriteLine(" "); //เว้นบรรทัด
					GetAlphabet(input);
					continue;
				}
				letterGuessed.Add(input);
				if (IsWord(secretword, letterGuessed))
				{
					Console.Clear(); ////เคลียร์หน้า
					Console.WriteLine("Play Game Hangman "); //เริ่มเกม
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("--------------------------");
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine(secretword);
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("Your Win !!!"); //ถ้าผู้เล่นตอบครบและถูกต้องจะขึ้นว่าคุณชนะ
					break;
				}
				else if (secretword.Contains(input))
				{
					Console.Clear(); //เคลียร์หน้า
					Console.WriteLine("Play Game Hangman "); //เริ่มเกม
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("--------------------------");
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine("Nice Entry");
					Console.WriteLine(""); //เว้นบรรทัด
					string letters = Isletter(secretword, letterGuessed);
					Console.WriteLine(letters);
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("Input letter alphabet: "); //ป้อนตัวอักษร
				}
				else
				{
					Console.Clear(); //เคลียร์หน้า
					Console.WriteLine("Play Game Hangman "); //เริ่มเกม
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("--------------------------");
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine("letter Not in My Word"); //บอกว่าในคำไม่มีตัวอักษรนี้
					Console.WriteLine(""); //เว้นบรรทัด
					score += 1;
					Console.WriteLine("Incorrect Score : {0} ", score); //ถ้าผู้เล่นใส่ตัวอักษรผิด Incorrect Score จะเพิ่มขึ้นที่ละ1โดยทุกครั้งที่ใส่ผิด
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("Input letter alphabet: "); //ป้อนตัวอักษร
				}
				Console.WriteLine();
				if (score == 6)
				{
					Console.Clear(); //เคลียร์หน้า
					Console.WriteLine("Play Game Hangman "); //เริ่มเกม
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("--------------------------");
					Console.WriteLine(" "); //เว้นบรรทัด
					Console.WriteLine("game Over :( "); //ถ้าผู้เล่นใส่ตัวอักษรผิดครบ6ครั้งจะจบเกม 
					Console.WriteLine(""); //เว้นบรรทัด
					Console.WriteLine("Word is  {0} ", secretword);
					break;
				}
			}
		}

		public static void Homepage() //เมธอดหน้าแรก
		{
			Console.WriteLine("Welcome to Hangman Game ");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("------------------------------------");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("1. Play Game"); //กด1เพื่อเล่นเกม
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("2. Exit"); //กด2เพื่อออก
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("Please Select Menu :"); //ให้เลือกรับค่าระหว่าง1หรือ2
			Console.WriteLine(""); //เว้นบรรทัด
			int menu = int.Parse(Console.ReadLine());
			switch (menu) //เงื่อนไขเพื่อไปยังหน้าต่อไป
			{
				case 1: //กด1จะเข้าไปยังหน้าเล่นเกมHangman
					{
						selectone(); //เรียกใช้เมธอดหน้าเกมHangman
						break;
					}
				case 2: //กด2จะจบการทำงาน
					{
						Console.WriteLine("End Game"); //ขึ้นว่าจบเกม
						break;
					}
			}
		}

		public static void selectone() //เมธอดหน้าเกมHangman
		{
			Console.Clear(); //เคลียร์หน้า
			Console.WriteLine("Play Game Hangman");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("--------------------------");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("Incorrect Score : 0"); //โดยคะแนนเริ่มต้นจะอยู่ที่0คะแนน
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("--------------------------");
			Console.WriteLine(""); //เว้นบรรทัด
			Console.WriteLine("Input letter alphabet : "); //ป้อนตัวอักษร
			Console.WriteLine(""); //เว้นบรรทัด
		}
		public static bool IsWord(string secreword, List<string> letterGuessed)
		{
			bool word = false;
			for (int i = 0; i < secreword.Length; i++)
			{
				string c = Convert.ToString(secreword[i]);
				if (letterGuessed.Contains(c))
				{
					word = true;
				}
				else
				{
					return word = false;
				}
			}
			return word;
		}

		public static string Isletter(string secretword, List<string> letterGuessed)
		{
			string correctletters = " ";
			for (int i = 0; i < secretword.Length; i++)
			{
				string c = Convert.ToString(secretword[i]);
				if (letterGuessed.Contains(c))
				{
					correctletters += c;
				}
				else
				{
					correctletters += "_ ";
				}
			}
			return correctletters;
		}
		public static void GetAlphabet(string letters)
		{
			List<string> alphabet = new List<string>(); //รายการรับตัวอักษร
			for (int i = 1; i <= 26; i++)
			{
				char alpha = Convert.ToChar(i + 96);
				alphabet.Add(Convert.ToString(alpha));
			}
			int num = 49;
			Console.WriteLine("Letters Left are : ");
			Console.WriteLine("");
			for (int i = 0; i < num; i++)
			{
				if (letters.Contains(letters))
				{
					alphabet.Remove(letters);
					num -= 1;
				}
				Console.Write("[" + alphabet[i] + "]");
			}
			Console.WriteLine();
		}
	}
}
