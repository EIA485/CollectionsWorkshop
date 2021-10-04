using FrooxEngine;
using System;

namespace CollectionsWorkshop
{
	public class SyncLinearKey<T> : SyncObject where T : IEquatable<T>
	{
		[Range(0.0f, 1f, "0.000")]
		public readonly Sync<float> Point;
		[Range(0.0f, 1f, "0.00")]
		public readonly Sync<T> value;
		public static implicit operator LinearKey<T>(SyncLinearKey<T> key) => new LinearKey<T>(key.Point.Value, key.value.Value);
	}
}