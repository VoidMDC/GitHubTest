using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintNames : MonoBehaviour {

	private Text _namesTextBox;

	// Please add your full name to the array under this comment. Remember to have a comma before your name and put your name in double quotes. 
	private string [] names = {"Ray Millares", "Alexander Villarreal", "Gabriel Cabrera", "William Tang", "Austin Acosta", "Alexander Artigas"};

	// Use this for initialization
	void Start () {

		_namesTextBox = GameObject.Find ("Names").GetComponent<Text>();
		_namesTextBox.text = "";

		foreach (string name in names)
		{
			_namesTextBox.text += name + ",\n";
			// ^ harder to see all the names if they're all on one line, hence the newline I added
		}

	}
}
