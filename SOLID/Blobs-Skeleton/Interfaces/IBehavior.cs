using _02.Blobs.Entities;

namespace _02.Blobs.Interfaces
{
	public interface IBehavior
	{
		bool IsTriggered { get; set; }

		void TriggerEffect(Blob source);

		void ApplySideEffect(Blob source);
	}
}