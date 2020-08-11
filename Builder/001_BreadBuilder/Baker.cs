using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._001_BreadBuilder
{
	/// <summary>
	/// Пекарь хлеба. Занимается изготовлением хлеба <see cref="Bread"/>
	/// </summary>
	public class Baker
	{
		/// <summary>
		/// Хранит информацию о нутриентах (конфигурации) выпекаемого хлеба
		/// </summary>
		private readonly BreadBuilder _breadBuilder;

		/// <summary>
		/// Конструктор класса <see cref="Baker"/>
		/// </summary>
		/// <param name="builder">Экземпляр класса <see cref="BreadBuilder"/>, который необходимо предварительно настроить</param>
		public Baker(BreadBuilder builder)
		{
			_breadBuilder = builder;
		}

		/// <summary>
		/// Конструктор класса <see cref="Baker"/>
		/// </summary>
		/// <param name="func">Делегат, возвращающий настроенный <see cref="BreadBuilder"/> билдер</param>
		public Baker(Func<BreadBuilder> func)
		{
			_breadBuilder = func();
		}

		/// <summary>
		/// Выпекает хлеб
		/// </summary>
		/// <returns>Хлеб</returns>
		public Bread Bake()
		{
			return new Bread { Flour = _breadBuilder.Flour, FlourType = _breadBuilder.FlourType, Butter = _breadBuilder.Butter, Salt = _breadBuilder.Salt, Spices = _breadBuilder.Spices };
		}
	}
}
