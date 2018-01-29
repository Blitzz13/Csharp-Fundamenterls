using _02.Blobs.Interfaces;
using System;

namespace _02.Blobs.Entities.Behaviors
{
	class Inflated : IBehavior
	{
		public bool IsTriggered { get; set; }

		public void TriggerEffect(Blob source)
		{
			source.Health += 10;
			IsTriggered = true;
		}

		public void ApplySideEffect(Blob source)
		{
			source.Health -= 10;
		}
	}
}
