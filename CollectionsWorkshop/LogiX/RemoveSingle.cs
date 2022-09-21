using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class RemoveSingle<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<int> index;
		public readonly Impulse done;


		[ImpulseTarget]
		public void Remove()
		{
			array.Evaluate().RemoveAt(index.Evaluate());
			done.Trigger();
		}
    }
}