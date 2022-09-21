using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class InsertElement<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<T> element;
		public readonly Input<int> index;
		public readonly Impulse done;


		[ImpulseTarget]
		public void Insert()
		{
			array.Evaluate().Insert(element.Evaluate(), index.Evaluate());
			done.Trigger();
		}
    }
}