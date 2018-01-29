using _02.Blobs.Interfaces;

namespace _02.Blobs.Entities.Behaviors
{
	public class Aggressive : IBehavior
	{
		private const int AggressiveDamageMultiplier = 2;
		private const int AggressiveDamageDecrementer = 5;

		private int _sourceInitialDamage;

		public bool IsTriggered { get; set; }

		public void TriggerEffect(Blob source)
		{
			_sourceInitialDamage = source.Damage;
			IsTriggered = true;
			source.Damage *= AggressiveDamageMultiplier;
		}

		public void ApplySideEffect(Blob source)
		{
			if (source.Damage > _sourceInitialDamage)
			{
				source.Damage -= AggressiveDamageDecrementer;
			}
		}
	}
}