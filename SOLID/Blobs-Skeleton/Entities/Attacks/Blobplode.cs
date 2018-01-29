using _02.Blobs.Interfaces;
using System;

namespace _02.Blobs.Entities.Attacks
{
	class Blobplode : IAttack
	{
		public void Execute(Blob attacker, Blob target)
		{
			attacker.Health /= 2;
			if (attacker.Health < 1)
			{
				attacker.Health = 1;
			}
			target.Health -= attacker.Damage * 2;
		}
	}
}
