using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class IndexOfElement<T> : LogixOperator<int> where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
        public readonly Input<T> elemenet;
        public override int Content
        {
            get
            {
                return array.Evaluate().IndexOf(elemenet.Evaluate());
            }
        }
    }
}