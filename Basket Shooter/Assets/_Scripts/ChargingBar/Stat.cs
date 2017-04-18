using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {

	//Bound to a Bar script to communicate stats to the bar
	[SerializeField]
	private Bar bar; // energy, health, experience, etc

	//[SerializeField]
	private float maxVal;

	// current value of stat 
	//[SerializeField]
	private float currVal;

	public float CurrVal{
		get{return currVal;}

		set{
			this.currVal = Mathf.Clamp(value, 0, MaxVal);
			bar.Value = currVal;
		}

	}	

	public float MaxVal{
		get{return maxVal;}
		set{
			bar.MaxValue = maxVal;
			this.maxVal = value;
		}
	}

	public void Initialize(){
		this.MaxVal = maxVal;
		this.CurrVal = currVal;
	}
}
