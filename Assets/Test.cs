using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityRandom urand = new UnityRandom ();
		float val = urand.Possion (035.6f);
		float val2 = urand.Possion (3.0f);
		Debug.Log (val);
		Debug.Log (val2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
