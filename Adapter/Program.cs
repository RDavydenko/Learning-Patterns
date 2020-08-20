using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Adapter.Adapters;
using Adapter.Animals;
using Adapter.Transports;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			ITransport auto = new Auto(); // Автомобиль
			IAnimal horse = new Horse(); // Лощадь

			People people = new People(auto); // Человек с транспортом - автомобиль
			people.MoveTo("Владивосток"); // Передвигаемся
			Console.WriteLine();

			// Меняем транспорт
			ITransport horseAdapter = new AnimalToTransportAdapter(horse); // Адаптер
			people.ChangeTransport(horseAdapter);

			// Едем на лошади
			people.MoveTo("Монголия"); // Передвигаемся
			Console.WriteLine();
		}
	}
}
