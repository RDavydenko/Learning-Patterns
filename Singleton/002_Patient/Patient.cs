using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton._002_Patient
{
	/// <summary>
	/// Представляет собой данные о пациенте. Реализует паттерн Singleton
	/// </summary>
	public class Patient
	{
		private static Lazy<Patient> _instance = new Lazy<Patient>(() => new Patient());

		/// <summary>
		/// Позволяет получить экземляр класса
		/// </summary>
		public static Patient Instance { get => _instance.Value; }

		/// <summary>
		/// Возраст пациента
		/// </summary>
		public int Age { get; set; }

		/// <summary>
		/// Пол пациента
		/// </summary>
		public Sex Sex { get; set; }		

		/// <summary>
		/// Вес пациента
		/// </summary>
		public double Weight { get; set; }

		/// <summary>
		/// Рост пациента
		/// </summary>
		public double Height { get; set; }

		/// <summary>
		/// Пульс пациента
		/// </summary>
		public int Pulse { get; set; }

		private Patient() { }

		/// <summary>
		/// Инициализирует данными пациента
		/// </summary>
		/// <param name="age">Возраст</param>
		/// <param name="sex">Пол</param>
		/// <param name="weight">Вес</param>
		/// <param name="height">Рост</param>
		/// <param name="pulse">Пульс</param>
		public void Init(int age, Sex sex, double weight, double height, int pulse)
		{
			Age = age;
			Sex = sex;
			Weight = weight;
			Height = height;
			Pulse = pulse;
		}

		public override string ToString()
		{
			return $"Характеристика пациента:\nВозраст: {Age}\nПол: {(Sex == 0 ? "Мужской" : "Женский")}\nВес: {Weight:0.0}\nРост: {Height:0.00}\nПульс: {Pulse}";
		}		
	}

	public enum Sex
	{
		Male = 0,
		Female = 1
	}
}
