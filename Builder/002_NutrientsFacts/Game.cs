using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder._002_NutrientsFacts.Attributes;

namespace Builder._002_NutrientsFacts
{
	/// <summary>
	/// Игра
	/// </summary>
	public class Game
	{
		/// <summary>
		/// Игровой билдер
		/// </summary>
		private readonly GameBuilder _builder;

		/// <summary>
		/// Название игры (игровой зоны)
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Игровая сложность
		/// </summary>
		public Difficult Difficult { get; private set; }

		/// <summary>
		/// Игровая локация
		/// </summary>
		public Location Location { get; private set; }

		/// <summary>
		/// Количество врагов
		/// </summary>
		public int EnemiesCount { get; private set; }

		/// <summary>
		/// Ширина игрового поля
		/// </summary>
		public int Width { get; private set; }

		/// <summary>
		/// Высота игрового поля
		/// </summary>
		public int Height { get; private set; }

		/// <summary>
		/// Продолжительность игры
		/// </summary>
		public TimeSpan Duration { get; private set; }

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="gameBuilder">Настроенный игровой билдер</param>
		public Game(GameBuilder gameBuilder)
		{
			_builder = gameBuilder;
			Initialize();
		}

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="gameBuilder">Делегат, возвращающий настроенный игровой билдер</param>
		public Game(Func<GameBuilder> func)
		{
			_builder = func();
			Initialize();
		}

		/// <summary>
		/// Инициализирует поля по данным из билдера
		/// </summary>
		private void Initialize()
		{
			if (_builder == null)
			{
				throw new NullReferenceException("Билдер равен null");
			}

			Name = _builder.Name;
			Difficult = _builder.Difficult;
			Location = _builder.Location;
			EnemiesCount = _builder.EnemiesCount;
			Width = _builder.Width;
			Height = _builder.Height;
			Duration = _builder.Duration;
		}

		public override string ToString()
		{
			// Получаем название сложности из атрибута с помощью рефлексии		
			var attrs = Difficult.GetType().GetField(Difficult.ToString()).GetCustomAttributes(false);
			string difficult = string.Empty;
			foreach (var attr in attrs)
			{
				if (attr is NameAttribute)
				{
					difficult = (attr as NameAttribute).Name;
					break;
				}
			}

			// Получаем название локации из атрибута с помощью рефлексии
			var attrs2 = Location.GetType().GetField(Location.ToString()).GetCustomAttributes(false);
			string location = string.Empty;
			foreach (var attr in attrs2)
			{
				if (attr is NameAttribute)
				{
					location = (attr as NameAttribute).Name;
					break;
				}
			}

			return $"Название: {Name}. Сложность: {difficult}. Локация: {location}. Кол-во врагов: {EnemiesCount}. Ширина: {Width}. Высота: {Height}. Длительность: {Duration}";
		}
	}
}
