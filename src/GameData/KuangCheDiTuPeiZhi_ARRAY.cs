using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "KuangCheDiTuPeiZhi_ARRAY")]
	[Serializable]
	public class KuangCheDiTuPeiZhi_ARRAY : IExtensible
	{
		private readonly List<KuangCheDiTuPeiZhi> _items = new List<KuangCheDiTuPeiZhi>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<KuangCheDiTuPeiZhi> items
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
