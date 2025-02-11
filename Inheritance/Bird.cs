using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			Age = 1;
			NumOfLegs = 2;
			Color = "Black";
			CanSwim = true;

		}
		public string WingColor { get; set; }
		public bool HasTalons { get; set; }
		public int BeakLength { get; set; }
		public bool CanFly { get; set; }



	}
}

