using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class ClearArray<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Impulse done;

		[ImpulseTarget]
		public void Clear()
		{ 
			array.Evaluate().Clear();
			done.Trigger();
		}
    }
}