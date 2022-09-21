using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class SetArraySize<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<int> size;
		public readonly Impulse done;
		public readonly Impulse fail;


		[ImpulseTarget]
		public void SetSize()
		{
			try
			{
				array.Evaluate().SetSize(size.Evaluate());
				done.Trigger();
			}
			catch
			{
				fail.Trigger();
			}
		}
    }
}