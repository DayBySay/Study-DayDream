using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.rotation = GvrController.Orientation;
	}
}
