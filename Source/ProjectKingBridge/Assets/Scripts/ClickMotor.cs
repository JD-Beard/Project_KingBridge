using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMotor : MonoBehaviour {



	public Text goldDisplay;
	public Text goldPerClickDisplay;
	public float gold = 0;
	public int goldPerClick = 1;


	void Update(){

		goldDisplay.text = "Gold: " + gold;
		goldPerClickDisplay.text = "GPC: " + goldPerClick;

	}


	public void Clicked(){

		gold += goldPerClick;


	}
}
