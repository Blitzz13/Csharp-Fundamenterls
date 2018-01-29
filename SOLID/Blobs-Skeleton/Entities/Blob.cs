using _02.Blobs.Interfaces;

namespace _02.Blobs.Entities
{

	public class Blob : IBlob
	{
		private IAttack _attack;
		private int _initialHealth;
		private int _initialDamage;

		public Blob(string name, int health, int damage, IBehavior behavior, IAttack attack)
		{
			Name = name;
			Health = health;
			Damage = damage;
			Behavior = behavior;
			Attack = attack;

			_initialHealth = health;
			_initialDamage = damage;
		}

		public string Name { get; private set; }

		public int Health { get; set; }

		public IBehavior Behavior { get; private set; }

		public IAttack Attack { get; private set; }

		public int Damage { get; set; }

		public void MakeAttack(Blob target)
		{
			Attack.Execute(this, target);
		}

		public void TriggerBehavior()
		{
			Behavior.TriggerEffect(this);
		}

		public override string ToString()
		{
			if (Health <= 0)
			{
				return $"IBlob {Name} KILLED";
			}

			return $"IBlob {Name}: {Health} HP, {Damage} Damage";
		}
	}
}