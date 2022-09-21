using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class GetElement<T> : LogixOperator<T> where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
		public readonly Input<int> index;
		public override T Content
		{
			get
			{
				return array.Evaluate()[index.Evaluate()];
			}
		}
	}
}