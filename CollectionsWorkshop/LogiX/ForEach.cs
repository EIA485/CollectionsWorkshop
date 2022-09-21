using System;
using FrooxEngine;
using FrooxEngine.LogiX;
using System.Collections.Generic;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class ForEach<T> : LogixOperator<T> where T : IEquatable<T>
	{
		public readonly Input<IEnumerable<T>> Enumerable;
		public readonly Impulse LoopStart;
		public readonly Impulse LoopIteration;
		public readonly Impulse LoopEnd;
		private T content;
		public override T Content
		{
			get
			{
				return content;
			}
		}

		[ImpulseTarget]
		public void Run()
		{
			IEnumerable<T> enumerable = Enumerable.Evaluate();
			LoopStart.Trigger();
			foreach (T element in enumerable)
			{
				content = element;
				LoopIteration.Trigger();
			}
			LoopEnd.Trigger();
			content = default(T);
		}
    }
}