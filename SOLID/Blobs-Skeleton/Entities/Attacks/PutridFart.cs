using _02.Blobs.Interfaces;

namespace _02.Blobs.Entities.Attacks
{
	public class PutridFart : IAttack
	{
		public void Execute(Blob attacker, Blob target)
		{
			target.Health -= attacker.Damage;
		}
	}
}