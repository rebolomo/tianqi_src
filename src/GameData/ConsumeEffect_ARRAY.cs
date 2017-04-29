using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "ConsumeEffect_ARRAY")]
	[Serializable]
	public class ConsumeEffect_ARRAY : IExtensible
	{
		private readonly List<ConsumeEffect> _items = new List<ConsumeEffect>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<ConsumeEffect> items
		{
			get
			{
				return this._items;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
