using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Singleton._001_Logger
{
	public class Logger
	{
		private static Logger _instance;
		private string _path = "logs.txt";

		private Logger() { }

		public static Logger GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Logger();
			}
			return _instance;
		}

		private DateTime ExtractDateTime(string logRow)
		{
			string dateTime = logRow.Substring(logRow.IndexOf('[') + 1, 23);
			DateTime result = TryParseDateTime(dateTime);
			return result;
		}

		private DateTime TryParseDateTime(string date)
		{
			var nums = date.Split('.', ' ', ':');
			if (nums.Length < 6)
			{
				return DateTime.MinValue;
			}
			int.TryParse(nums[0], out int days);
			int.TryParse(nums[1], out int mouth);
			int.TryParse(nums[2], out int years);
			int.TryParse(nums[3], out int hours);
			int.TryParse(nums[4], out int minutes);
			int.TryParse(nums[5], out int seconds);
			int.TryParse(nums[6], out int milliseconds);

			return new DateTime(years, mouth, days, hours, minutes, seconds, milliseconds);
		}

		public void AddLog(string text)
		{
			string log = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss.fff}] {text}";
			using (StreamWriter sr = new StreamWriter(_path, true))
			{
				sr.WriteLine(log);
				sr.Close();
			}
		}

		public List<string> GetLogs()
		{
			List<string> logs = new List<string>();

			#region Проверка существования файла с логами
			if (!File.Exists(_path))
			{
				throw new FileNotFoundException("Файл с логами не найден");
			}
			#endregion

			using (StreamReader sr = new StreamReader(_path))
			{
				while (!sr.EndOfStream)
				{
					logs.Add(sr.ReadLine());
				}
			}

			return logs;
		}

		public List<string> GetLogs(DateTime start, DateTime end)
		{
			List<string> logs = new List<string>();

			#region Проверка существования файла с логами
			if (!File.Exists(_path))
			{
				throw new FileNotFoundException("Файл с логами не найден");
			}
			#endregion

			using (StreamReader sr = new StreamReader(_path))
			{
				while (!sr.EndOfStream)
				{
					var row = sr.ReadLine();
					var dateTime = ExtractDateTime(row);
					if (dateTime >= start && dateTime <= end)
					{
						logs.Add(row);
					}
				}
			}

			return logs;
		}
	}
}
