using System;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace CollectionsWorkshop.LogiX
{
	[Category("LogiX/Add-Ons/CollectionsWorkshop")]
	class ContainsElement<T> : LogixOperator<bool> where T : IEquatable<T>
	{
		public readonly Input<SyncArray<T>> array;
        public readonly Input<T> elemenet;
        public override bool Content
        {
            get
            {
                return array.Target.Content.Contains(elemenet.Evaluate());
            }
        }
    }
}