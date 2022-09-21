using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class DeltaSize<T> : LogixNode where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<int> change;
		public readonly Impulse done;
		public readonly Impulse fail;


		[ImpulseTarget]
		public void Run()
		{
			try
			{
				if (change.Evaluate() > 0)
					array.Evaluate().Expand(change.EvaluateRaw());
				else
					array.Evaluate().Shrink(change.EvaluateRaw()*-1);

				done.Trigger();
			}
			catch
			{
				fail.Trigger();
			}
		}
    }
}