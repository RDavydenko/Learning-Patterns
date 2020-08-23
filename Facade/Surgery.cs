using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facade.Doctors;

namespace Facade
{
	/// <summary>
	/// Хирургия
	/// </summary>
	public class Surgery
	{
		private readonly Surgeon _surgeon; // Хирург
		private readonly Anesthesiologist _anesthesiologist; // Анестезиолог
		private readonly Nurse _nurse; // Медсестра

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="surgeon">Хирург</param>
		/// <param name="anesthesiologist">Анестезиолог</param>
		/// <param name="nurse">Медсестра</param>
		public Surgery(Surgeon surgeon, Anesthesiologist anesthesiologist, Nurse nurse)
		{
			_surgeon = surgeon;
			_anesthesiologist = anesthesiologist;
			_nurse = nurse;
		}

		/// <summary>
		/// Сделать операцию на колено
		/// </summary>
		public void DoKneeSurgery()
		{
			_anesthesiologist.DoAnaesthetic(Anesthesiologist.AnesthesiaType.Spinal);
			_nurse.GiveScalpel();
			_surgeon.Cut(BodyPart.Leg);
			_surgeon.Clear(BodyPart.Leg);
			_surgeon.Sew(BodyPart.Leg);
		}

		/// <summary>
		/// Сделать операцию на мозге
		/// </summary>
		public void DoBrainSurgery()
		{
			_anesthesiologist.DoAnaesthetic(Anesthesiologist.AnesthesiaType.Narcosis);
			_nurse.GiveScalpel();
			_surgeon.Cut(BodyPart.Head);
			_nurse.GivePincers();
			_surgeon.Clear(BodyPart.Head);
			_nurse.GiveScalpel();
			_surgeon.Sew(BodyPart.Head);
		}
	}
}
