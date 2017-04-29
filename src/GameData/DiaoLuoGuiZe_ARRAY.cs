using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "DiaoLuoGuiZe_ARRAY")]
	[Serializable]
	public class DiaoLuoGuiZe_ARRAY : IExtensible
	{
		private readonly List<DiaoLuoGuiZe> _items = new List<DiaoLuoGuiZe>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<DiaoLuoGuiZe> items
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
