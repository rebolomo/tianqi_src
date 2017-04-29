using Foundation.Core.Databinding;
using System;

public class TextItem : BaseUIBehaviour
{
	private void Awake()
	{
		base.AwakeBase(BindingContext.BindingContextMode.MockBinding, false);
	}

	protected override void DataBinding()
	{
		base.DataBinding();
		TextBinder textBinder = base.get_gameObject().AddComponent<TextBinder>();
		textBinder.BindingProxy = base.get_gameObject();
		textBinder.LabelBinding.MemberName = "Content";
	}

	protected override void EventsBinding()
	{
		base.EventsBinding();
	}
}
