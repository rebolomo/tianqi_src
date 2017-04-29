using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Package
{
	[ProtoContract(Name = "CareerAdvancedInfo")]
	[Serializable]
	public class CareerAdvancedInfo : IExtensible
	{
		private int _advancedCfgId;

		private int _stageCfgId;

		private readonly List<int> _finishedTaskId = new List<int>();

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = false, Name = "advancedCfgId", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int advancedCfgId
		{
			get
			{
				return this._advancedCfgId;
			}
			set
			{
				this._advancedCfgId = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "stageCfgId", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int stageCfgId
		{
			get
			{
				return this._stageCfgId;
			}
			set
			{
				this._stageCfgId = value;
			}
		}

		[ProtoMember(3, Name = "finishedTaskId", DataFormat = DataFormat.TwosComplement)]
		public List<int> finishedTaskId
		{
			get
			{
				return this._finishedTaskId;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
