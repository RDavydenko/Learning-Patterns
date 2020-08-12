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
	public class Hero : ITarget, IDamager
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
					Died?.Invoke(this);
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

		/// <summary>
		/// Персонаж умер
		/// </summary>
		public event Action<ITarget> Died;

		/// <summary>
		/// Персонаж атаковал другого персонажа (Атакующий, атакованный)
		/// </summary>
		public event Action<IDamager, ITarget> Attacked;

		/// <summary>
		/// Персонаж нанес урон (Атакующий, атакованный, нанесенный урон)
		/// </summary>
		public event Action<IDamager, ITarget, double> DidDamage;

		/// <summary>
		/// Персонаж отразил урон (Атакованный, атакующий, нанесенный урон)
		/// </summary>
		public event Action<ITarget, IDamager, double> ReflectedDamage;

		/// <summary>
		/// Персонаж принял урон (Атакованный, атакующий, нанесенный урон)
		/// </summary>
		public event Action<ITarget, IDamager, double> TookDamage;

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

		// Принять урон
		public double TakeDamage(IDamager damager, double damage)
		{
			var correctedDamage = damage * (1 - Armor.ProtectionPoints); // Скорректированный урон с учетом очков брони
			var reflectedDamage = damage - correctedDamage; // Отраженный урон (заблокированный броней)

			if (reflectedDamage != 0)
			{
				ReflectedDamage?.Invoke(this, damager, reflectedDamage); // Инициируем событие "Отразил урон"
			}

			correctedDamage = correctedDamage < 0 ? 0 : correctedDamage; // Если меньше нуля, то ноль, иначе то, что было
			Health -= correctedDamage; // Отнимаем очки здоровья

			if (correctedDamage > 0)
			{
				TookDamage?.Invoke(this, damager, correctedDamage); // Инициируем событие "Принял урон" 
			}

			return correctedDamage;
		}

		public void Atack(ITarget target)
		{
			Attacked?.Invoke(this, target);  // Инициируем событие "Атаковал персонажа" 

			var damage = Weapon.Damage * Weapon.Sharpness;
			var correctedDamage = target.TakeDamage(this, damage); // Нанесенный урон
			
			if (correctedDamage > 0)
			{
				DidDamage?.Invoke(this, target, correctedDamage); // Инициируем событие "Нанес урон" 
			}
		}
	}
}
