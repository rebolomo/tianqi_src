using ProtoBuf;
using System;
using System.ComponentModel;

namespace GameData
{
	[ProtoContract(Name = "XuanShangSheZhi")]
	[Serializable]
	public class XuanShangSheZhi : IExtensible
	{
		private string _key;

		private int _num;

		private string _value = string.Empty;

		private IExtension extensionObject;

		[ProtoMember(2, IsRequired = true, Name = "key", DataFormat = DataFormat.Default)]
		public string key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "num", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
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

		[ProtoMember(4, IsRequired = false, Name = "value", DataFormat = DataFormat.Default), DefaultValue("")]
		public string value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
