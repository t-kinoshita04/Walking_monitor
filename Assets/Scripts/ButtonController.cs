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
		else if ("Button6".Equals(objectName))
		{
			this.Button6Click();
		}
		else if ("Button7".Equals(objectName))
		{
			this.Button7Click();
		}
		else if ("Button8".Equals(objectName))
		{
			this.Button8Click();
		}
		else if ("Button9".Equals(objectName))
		{
			this.Button9Click();
		}
		else if ("Button10".Equals(objectName))
		{
			this.Button10Click();
		}
		else if ("Button11".Equals(objectName))
		{
			this.Button11Click();
		}
		else if ("Button12".Equals(objectName))
		{
			this.Button12Click();
		}
		else if ("Button13".Equals(objectName))
		{
			this.Button13Click();
		}
		else if ("Button14".Equals(objectName))
		{
			this.Button14Click();
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

	private void Button6Click ()
	{
		Debug.Log("Button6 Click");
	}

	private void Button7Click ()
	{
		Debug.Log("Button7 Click");
	}

	private void Button8Click ()
	{
		Debug.Log("Button8 Click");
	}

	private void Button9Click ()
	{
		Debug.Log("Button9 Click");
	}

	private void Button10Click ()
	{
		Debug.Log("Button10 Click");
	}

	private void Button11Click ()
	{
		Debug.Log("Button11 Click");
	}

	private void Button12Click ()
	{
		Debug.Log("Button12 Click");
	}

	private void Button13Click ()
	{
		Debug.Log("Button13 Click");
	}

	private void Button14Click ()
	{
		Debug.Log("Button14 Click");
	}
}
