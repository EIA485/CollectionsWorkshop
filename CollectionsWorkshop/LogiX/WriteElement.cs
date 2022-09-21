using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class WriteElement<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<T> element;
		public readonly Input<int> index;
		public readonly Impulse done;


		[ImpulseTarget]
		public void Write()
		{
			array.Evaluate().Write(element.Evaluate(), index.Evaluate());
			done.Trigger();
		}
    }
}