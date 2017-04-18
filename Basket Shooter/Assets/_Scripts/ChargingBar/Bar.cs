using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {

	[SerializeField]
	private float fillAmount;

	[SerializeField]
	private float lerpSpeed;

	[SerializeField]
	private Image content;


	[SerializeField]
	private Color fullColor;
	[SerializeField]
	private Color lowColor;

	[SerializeField]
	private bool lerpColors;



	public float MaxValue { get; set; }

	public float Value	{ 
		set { 
			// update fillamount
			fillAmount = Map (value, MaxValue);
		} 
	}

	// Use this for initialization
	void Start () {
		if (lerpColors) {
			content.color = fullColor;
		}

	}

	// Update is called once per frame
	void Update () {
		HandleBar ();	
	}

	private void HandleBar(){
		//Change fill amount in Healthbar
		if (fillAmount != content.fillAmount) {
			content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime*lerpSpeed);
		}
		if (lerpColors) {
			content.color = Color.Lerp (lowColor, fullColor, (01.2f*fillAmount));
		}

	}

	private float Map(float value, float inMax){

		return value/inMax;

	}
}
