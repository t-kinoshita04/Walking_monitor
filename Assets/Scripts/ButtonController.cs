using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : BaseButtonController {

	protected override void OnClick(string objectName) {
		if ("Button1".Equals(objectName))
		{
			this.Button1Click();
		}
		else if ("Button2".Equals(objectName))
		{
			this.Button2Click();
		}
		else if ("Button3".Equals(objectName))
		{
			this.Button3Click();
		}
		else if ("Button4".Equals(objectName))
		{
			this.Button4Click();
		}
		else if ("Button5".Equals(objectName))
		{
			this.Button5Click();
		}
		else
		{
			throw new System.Exception("Not implemented!");
		}
	}
	
	private void Button1Click ()
	{
		Debug.Log("Button1 Click");
	}

	private void Button2Click ()
	{
		Debug.Log("Button2 Click");
	}

	private void Button3Click ()
	{
		Debug.Log("Button3 Click");
	}

	private void Button4Click ()
	{
		Debug.Log("Button4 Click");
	}

	private void Button5Click ()
	{
		Debug.Log("Button5 Click");
	}
}
