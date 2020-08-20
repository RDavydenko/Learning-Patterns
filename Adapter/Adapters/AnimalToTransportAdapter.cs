using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Adapter.Animals;
using Adapter.Transports;

namespace Adapter.Adapters
{
	/// <summary>
	/// Адаптер для приведения <see cref="IAnimal"/> к <see cref="ITransport"/> 
	/// </summary>
	class AnimalToTransportAdapter : ITransport
	{
		private IAnimal _animal;

		public AnimalToTransportAdapter(IAnimal animal)
		{
			_animal = animal;
		}

		public void Drive()
		{
			_animal.Move();
		}
	}
}
