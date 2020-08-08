using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Heroes
{
	/// <summary>
	/// Игровой персонаж
	/// </summary>
	public class Hero : ITarget
	{
		private double _health;

		/// <summary>
		/// Имя персонажа
		/// </summary>
		public string Name { get; }

		public double Health
		{
			get { return _health; }
			set
			{
				if (value < 0)
				{
					_health = 0;
				}
				else
				{
					_health = value;
				}

				if (_health == 0)
				{
					Died?.Invoke(this, Name);
				}
			}
		}

		/// <summary>
		/// Оружие
		/// </summary>
		public IWeapon Weapon { get; }

		/// <summary>
		/// Броня
		/// </summary>
		public IArmor Armor { get; }

		/// <summary>
		/// Инвентарь
		/// </summary>
		public IInventory Inventory { get; }

		public event EventHandler<string> Died;

		/// <summary>
		/// Конструктор персонажа. Принимает экземляр абстрактной фабрики персонажа
		/// </summary>
		/// <param name="factory">Экземляр абстрактной фабрики персонажа</param>
		/// <param name="name">Имя персонажа</param>
		public Hero(IHeroFactory factory, string name)
		{
			Weapon = factory.CreateWeapon();
			Armor = factory.CreateArmor();
			Inventory = factory.CreateInventory();

			Health = 100;
			Name = name;
		}

		public double TakeDamage(double damage)
		{
			var correctedDamage = damage * (1 - Armor.ProtectionPoints); // Скорректированный урон с учетом очков брони
			correctedDamage = correctedDamage < 0 ? 0 : correctedDamage; // Если меньше нуля, то ноль, иначе то, что было
			Health -= correctedDamage; // Отнимаем очки здоровья

			return correctedDamage;
		}
	}
}
