using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class AppendElement<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<T> element;
		public readonly Impulse done;


		[ImpulseTarget]
		public void Append()
		{
			array.Evaluate().Append(element.Evaluate());
			done.Trigger();
		}
    }
}