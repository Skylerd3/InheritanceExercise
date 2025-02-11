using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			Age = 1;
			NumOfLegs = 4;
			Color = "Green";
			CanSwim = true;


		}

		public bool IsCooldBlooded { get; set; }
		public bool HasTail { get; set; }
		public bool CanGrowTailBack { get; set; }
		public bool IsScaly { get; set; }



	}
}

