using ProtoBuf;
using System;
using System.ComponentModel;

namespace GameData
{
	[ProtoContract(Name = "DuiHua")]
	[Serializable]
	public class DuiHua : IExtensible
	{
		private int _id;

		private int _body;

		private int _word;

		private IExtension extensionObject;

		[ProtoMember(2, IsRequired = true, Name = "id", DataFormat = DataFormat.TwosComplement)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "body", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int body
		{
			get
			{
				return this._body;
			}
			set
			{
				this._body = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "word", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int word
		{
			get
			{
				return this._word;
			}
			set
			{
				this._word = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
