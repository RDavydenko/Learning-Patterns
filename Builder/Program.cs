using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder._001_BreadBuilder;
using Builder._002_NutrientsFacts;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			BreadBuilderTest(); // 001

			GameBuilderTest(); // 002
		}

		/// <summary>
		/// Тестируем первый пример с билдером хлеба <see cref="BreadBuilder"/>
		/// </summary>
		private static void BreadBuilderTest()
		{
			// Создаем объект пекаря с настроенным билдером
			var baker = new Baker(() =>
			{
				return new BreadBuilder()
					.SetSalt(10)
					.SetFlourType(FlourType.Wheat)
					.SetFlour(50)
					.SetButter(5)
					.SetSpices("перец", "тимьян", "праванские травы");
			});

			// Испекаем хлеб с параметрами, установленными билдером при инициализации пекаря
			var bread = baker.Bake();

			Console.WriteLine(bread.ToString());
		}

		/// <summary>
		/// Тестируем второй пример с игровым билдером <see cref="GameBuilder"/>
		/// </summary>
		private static void GameBuilderTest()
		{
			// Создаем игру с помощью билдера
			Game game = new Game(
				new GameBuilder()
					.SetName("1x1 дуэль на Военной базе")
					.SetWidth(1500)
					.SetHeight(1500)
					.SetDifficult(Difficult.Impossible)
					.SetLoction(Location.MilitaryBase)
					.SetEnemiesCount(1)
					.SetDuration(TimeSpan.FromMinutes(10))
				);

			// Информация по игре
			Console.WriteLine(game.ToString());
		}
	}
}
