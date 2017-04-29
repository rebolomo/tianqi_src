using NetWork.Utilities;
using ProtoBuf;
using System;
using System.ComponentModel;

namespace Package
{
	[ForRecv(3281), ForSend(3281), ProtoContract(Name = "GetZeroCityPrizeReq")]
	[Serializable]
	public class GetZeroCityPrizeReq : IExtensible
	{
		public static readonly short OP = 3281;

		private int _num;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = false, Name = "num", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int num
		{
			get
			{
				return this._num;
			}
			set
			{
				this._num = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
