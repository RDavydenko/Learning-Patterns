using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.BuildingMachines
{
	/// <summary>
	/// Сборщик транспорта - базовый класс
	/// </summary>
	public abstract class TransportBuilderBase
	{
		/// <summary>
		/// Сборка транспорта
		/// </summary>
		public void Build()
		{
			BuildChassis(); // Сборка шасси
			BuildCase(); // Сборка кузова
			BuildEngine(); // Сборка двигателя			
		}

		/// <summary>
		/// Собрать шасси
		/// </summary>
		public abstract void BuildChassis();

		/// <summary>
		/// Собрать кузов
		/// </summary>
		public abstract void BuildCase();

		/// <summary>
		/// Собрать двигатель
		/// </summary>
		public abstract void BuildEngine();
	}
}
