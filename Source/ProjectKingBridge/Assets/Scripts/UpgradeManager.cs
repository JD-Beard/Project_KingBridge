using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {


	public ClickMotor clickmotor;
	public Text itemInfo;
	public string itemName;
	public float cost;
	public int count = 0;
	public int clickPower;
	private float baseCost;

	void Start(){

		baseCost = cost;

	}

	void Update(){

		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;

	}


	public void PurchasedUpgrade(){

		if (clickmotor.gold >= cost) {
			clickmotor.gold -= cost;
			count += 1;
			clickmotor.goldPerClick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));



//			cost = Mathf.Round (cost * 1.15f);
//			baseCost = Mathf.Pow (cost, baseCost = cost);

		}

	}

}
