using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class RemoveMultiple<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<int> index;
		public readonly Input<int> count;
		public readonly Impulse done;


		[ImpulseTarget]
		public void Write()
		{
			array.Evaluate().Remove(index.Evaluate(), count.Evaluate());
			done.Trigger();
		}
    }
}