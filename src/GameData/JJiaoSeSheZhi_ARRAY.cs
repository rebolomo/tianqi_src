using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "JJiaoSeSheZhi_ARRAY")]
	[Serializable]
	public class JJiaoSeSheZhi_ARRAY : IExtensible
	{
		private readonly List<JJiaoSeSheZhi> _items = new List<JJiaoSeSheZhi>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<JJiaoSeSheZhi> items
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
