using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Trucks_and_Motorcycles
{
	/// <summary>
	/// Реализация конктретного автомобиля
	/// </summary>
	public class Auto
	{
		/// <summary>
		/// Название автомобиля
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Двигатель
		/// </summary>
		public IEngine Engine { get; }

		/// <summary>
		/// Корпус
		/// </summary>
		public IBody Body { get; }

		/// <summary>
		/// Бензобак
		/// </summary>
		public ITank Tank { get; }

		/// <summary>
		/// Суммарный вес автомобиля
		/// </summary>
		public double SummaryWeight => Engine.Weight + Body.Weight + Tank.Weight;

		/// <summary>
		/// Суммарная стоимость автомобиля
		/// </summary>
		public decimal SummaryCost => Engine.Price + Body.Price + Tank.Price;

		/// <summary>
		/// Событие, сообщающее о том, сколько проехал автомобиль за единицу времени
		/// </summary>
		public event EventHandler<double> Moved;

		/// <summary>
		/// Конструктор автомобиля. Принимает реализацию абстрактной фабрики автомобилей
		/// </summary>
		/// <param name="factory">Фабрика автомобиля</param>
		public Auto(IAutoFactory factory, string name)
		{
			Name = name;
			Engine = factory.CreateEngine();
			Body = factory.CreateBody();
			Tank = factory.CreateTank();

			if (SummaryWeight > Body.MaxWeight)
			{
				throw new Exception("Суммарный вес машины больше допустимого этим корпусом");
			}
		}

		/// <summary>
		/// Осуществляет движение автомобиля с заданной скоростью
		/// </summary>
		/// <returns>Возвращает <see langword="true"/>, если движение было совершено или <see langword="false"/>, если движение не было совершено</returns>
		public bool Move(double speed)
		{
			if (!Tank.IsEmpty)
			{
				var consumption = Engine.GetConsumption(speed); // Расход топлива на 100 км. (л.)				
				var bonusConsumption = consumption * (1 / Body.Aerodynamic); // Расход топлива считаем исходя из аэродинамики (чем лучше аэродинамика, тем меньше расход)
				var fuel = Tank.Spend(bonusConsumption); // Сколько было потрачено топлива (л.)
				var distance = 100 * (fuel / bonusConsumption); // Какая дистанция была проехана

				Moved?.Invoke(this, distance); // Инициируем событие движения

				return true;
			}
			return false;
		}

	}
}
