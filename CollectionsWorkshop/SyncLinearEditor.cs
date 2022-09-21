using System;
using FrooxEngine;

namespace CollectionsWorkshop
{
	[Category("Add-Ons")]
	class SyncLinearEditor<T> : Component where T : IEquatable<T>
	{
		public readonly SyncRef<SyncLinear<T>> SyncLinear;
		public readonly SyncList<SyncLinearKey<T>> linear;
		protected override void OnAttach()
		{
			if (SyncLinear != null && !SyncLinear.IsDisposed)
			{
				linear.Changed += Colours_Changed;
				SyncLinear.Changed += Colours_Changed;
			}
			base.OnAttach();
		}
		private void Colours_Changed(IChangeable obj)
		{
			SyncLinear.Target.Clear();
			foreach (SyncLinearKey<T> key in linear)
			{
				SyncLinear.Target.Append(key);
			}
		}
	}
}