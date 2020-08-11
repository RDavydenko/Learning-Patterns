using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder._002_NutrientsFacts.Attributes;

namespace Builder._002_NutrientsFacts
{
	/// <summary>
	/// Билдер для создания игрового поля
	/// </summary>
	public class GameBuilder
	{
		/// <summary>
		/// Название игры (игровой зоны)
		/// </summary>
		public string Name { get; private set; } = "Игра";

		/// <summary>
		/// Игровая сложность
		/// </summary>
		public Difficult Difficult { get; private set; } = Difficult.Easy;

		/// <summary>
		/// Игровая локация
		/// </summary>
		public Location Location { get; private set; } = Location.City;

		/// <summary>
		/// Количество врагов
		/// </summary>
		public int EnemiesCount { get; private set; } = 100;

		/// <summary>
		/// Ширина игрового поля
		/// </summary>
		public int Width { get; private set; } = 1000;

		/// <summary>
		/// Высота игрового поля
		/// </summary>
		public int Height { get; private set; } = 1000;

		/// <summary>
		/// Продолжительность игры
		/// </summary>
		public TimeSpan Duration { get; private set; } = TimeSpan.FromMinutes(5);

		/// <summary>
		/// Устанавливает название игры
		/// </summary>
		/// <param name="name">Название</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetName(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			Name = name;
			return this;
		}

		/// <summary>
		/// Устанавливает игровую сложность
		/// </summary>
		/// <param name="difficult">Игровая сложность</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetDifficult(Difficult difficult)
		{
			Difficult = difficult;
			return this;
		}

		/// <summary>
		/// Устанавливает игровую локацию
		/// </summary>
		/// <param name="location">Игровая локация</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetLoction(Location location)
		{
			Location = location;
			return this;
		}

		/// <summary>
		/// Устанавливает количество врагов
		/// </summary>
		/// <param name="count">Количество врагов</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetEnemiesCount(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			EnemiesCount = count;
			return this;
		}

		/// <summary>
		/// Устанавливает ширину игровой зоны
		/// </summary>
		/// <param name="width">Ширина игровой зоны</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetWidth(int width)
		{
			if (width < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			Width = width;
			return this;

		}

		/// <summary>
		/// Устанавливает высоту игровой зоны
		/// </summary>
		/// <param name="height">Высота игровой зоны</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetHeight(int height)
		{
			if (height < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			Height = height;
			return this;
		}

		/// <summary>
		/// Устанавливает продолжительность игры
		/// </summary>
		/// <param name="duration">Продолжительность игры</param>
		/// <returns>Этот объект класса билдера</returns>
		public GameBuilder SetDuration(TimeSpan duration)
		{
			Duration = duration;
			return this;
		}
	}

	/// <summary>
	/// Сложность игры
	/// </summary>
	public enum Difficult
	{
		[Name("Ребенок")]
		Kid = 0,

		[Name("Легкая")]
		Easy = 1,

		[Name("Средняя")]
		Medium = 2,

		[Name("Сложная")]
		Hard = 3,

		[Name("Невозможная")]
		Impossible = 4
	}

	/// <summary>
	/// Игровая локация
	/// </summary>
	public enum Location
	{
		[Name("Стадион")]
		Stadium = 0,

		[Name("Плавательный бассейн")]
		SwimmingPool = 1,

		[Name("Город")]
		City = 2,

		[Name("Пустыня")]
		Desert = 3,

		[Name("Военная база")]
		MilitaryBase = 4
	}
}
