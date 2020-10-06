﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RegexExp17
{
	class Switch
	{
		static bool IsValid1(string path)
		{
			return Regex.IsMatch(path, @"^[a-zA-Z0-9]*$");
		}

		static bool IsValid2(string path)
		{
			for (int i = 0; i < path.Length; i++)
			{
				switch (path[i])
				{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
					case 'g':
					case 'h':
					case 'i':
					case 'j':
					case 'k':
					case 'l':
					case 'm':
					case 'n':
					case 'o':
					case 'p':
					case 'q':
					case 'r':
					case 's':
					case 't':
					case 'u':
					case 'v':
					case 'w':
					case 'x':
					case 'y':
					case 'z':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
					case 'G':
					case 'H':
					case 'I':
					case 'J':
					case 'K':
					case 'L':
					case 'M':
					case 'N':
					case 'O':
					case 'P':
					case 'Q':
					case 'R':
					case 'S':
					case 'T':
					case 'U':
					case 'V':
					case 'W':
					case 'X':
					case 'Y':
					case 'Z':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						{
							continue;
						}
					default:
						{
							return false;
						}
				}
			}
			return true;
		}

		const int _max = 1000000;
		static void Main()
		{
			// Version 1: use Regex.
			var s1 = Stopwatch.StartNew();
			for (int i = 0; i < _max; i++)
			{
				if (IsValid1("hello") == false || IsValid1("$bye") == true)
				{
					return;
				}
			}
			s1.Stop();
			// Version 2: use for-loop.
			var s2 = Stopwatch.StartNew();
			for (int i = 0; i < _max; i++)
			{
				if (IsValid2("hello") == false || IsValid2("$bye") == true)
				{
					return;
				}
			}
			s2.Stop();
			Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
				_max).ToString("0.00 ns"));
			Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
				_max).ToString("0.00 ns"));
			Console.ReadLine();

		}
	}
}

