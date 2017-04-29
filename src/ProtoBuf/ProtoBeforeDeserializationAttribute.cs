using System;
using System.ComponentModel;

namespace ProtoBuf
{
	[AttributeUsage, ImmutableObject(true)]
	public sealed class ProtoBeforeDeserializationAttribute : Attribute
	{
	}
}
