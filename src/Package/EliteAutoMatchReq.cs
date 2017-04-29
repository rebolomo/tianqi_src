using NetWork.Utilities;
using ProtoBuf;
using System;

namespace Package
{
	[ForRecv(99), ForSend(99), ProtoContract(Name = "EliteAutoMatchReq")]
	[Serializable]
	public class EliteAutoMatchReq : IExtensible
	{
		public static readonly short OP = 99;

		private int _copyId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "copyId", DataFormat = DataFormat.TwosComplement)]
		public int copyId
		{
			get
			{
				return this._copyId;
			}
			set
			{
				this._copyId = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
