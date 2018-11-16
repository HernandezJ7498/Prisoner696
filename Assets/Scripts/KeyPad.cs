using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class KeyPad : MonoBehaviour {

	public string curPassword = "5283";
	public string input;
	public bool onTrigger;
	public bool doorOpen = false;
	public bool keypadScreen;
	public Transform doorHinge;
	public GameObject SwitchAlert;
	public GameObject Chestdoor;
	public GameObject M16;

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
		if (doorOpen) {
			Chestdoor.GetComponent<Animation>().Play("openchestup");
			M16.GetComponent<Animation>().Play("FloatingM16");
		}
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
		keypadScreen = false;
		SwitchAlert.GetComponent<Text> ().text = "";
        input = "";
		if (doorOpen) {
			Chestdoor.GetComponent<Animation>().Play("closechestdown");
			M16.GetComponent<Animation>().Play("FloatingM16down");
		}
	}

	void Update()
	{
		if (input.Length > 5) {
			SwitchAlert.GetComponent<Text> ().text = "Use numpad to enter passcode: ";
			input = "";
		}
		if(input == curPassword && !doorOpen)
		{
			Chestdoor.GetComponent<Animation>().Play("openchestup");
			M16.GetComponent<Animation>().Play("FloatingM16");
			doorOpen = true;
			SwitchAlert.GetComponent<Text> ().text = "";
		}
		if(!doorOpen)
		{
			if(onTrigger)
			{
				SwitchAlert.GetComponent<Text> ().text = "Pess 'E' to use numpad";
				if(Input.GetKeyDown(KeyCode.E))
				{
					keypadScreen = true;
					onTrigger = false;
				}
			}

			if(keypadScreen)
			{
				/*GUI.Box(new Rect(0, 0, 320, 455), "");
				GUI.Box(new Rect(5, 5, 310, 25), input);*/
				SwitchAlert.GetComponent<Text> ().text = "Use numpad to enter passcode: " + input;

				if(Input.GetKeyDown(KeyCode.Keypad1))
				{
					input += "1";
				}

				if(Input.GetKeyDown(KeyCode.Keypad2))
				{
					input += "2";
				}

				if(Input.GetKeyDown(KeyCode.Keypad3))
				{
					input += "3";
				}

				if(Input.GetKeyDown(KeyCode.Keypad4))
				{
					input += "4";
				}

				if(Input.GetKeyDown(KeyCode.Keypad5))
				{
					input += "5";
				}

				if(Input.GetKeyDown(KeyCode.Keypad6))
				{
					input += "6";
				}

				if(Input.GetKeyDown(KeyCode.Keypad7))
				{
					input += "7";
				}

				if(Input.GetKeyDown(KeyCode.Keypad8))
				{
					input += "8";
				}

				if(Input.GetKeyDown(KeyCode.Keypad9))
				{
					input += "9";
				}

				if(Input.GetKeyDown(KeyCode.Keypad0))
				{
					input += "0";
				}
		}
		/*if(doorOpen)
		{
			var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
			doorHinge.rotation = newRot;
		}*/
	}
}
}
