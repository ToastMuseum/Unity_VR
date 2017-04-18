using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	private Stat charge;

	private void Awake(){
		charge.Initialize ();
	}

	private float damagePerSecond = 5;
	public float amt;

	// Use this for initialization
	void Start () {
		amt = damagePerSecond;
	}

	// Update is called once per frame
	void Update () {


		// QW effect charge bar
		if (Input.GetKeyDown (KeyCode.Q)) {
			charge.CurrVal -= 10;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			charge.CurrVal += 10;
		}

	}



	void OnTriggerStay2D(Collider2D other){
		if (other.name == "heal_spot"){
			//charge.CurrVal += 10;
			amt *= Time.deltaTime;

			charge.CurrVal += amt;
		}
		if (other.name == "damage_spot") {
			//charge.CurrVal -= 10;
			amt *= Time.deltaTime;

			charge.CurrVal -= amt;

		}
		amt = damagePerSecond;
	}
		

}
