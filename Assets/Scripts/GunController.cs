using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	public GameObject gun;

	// Update is called once per frame
	void Update () {
		gun.transform.rotation = GvrController.Orientation;
	}
}
