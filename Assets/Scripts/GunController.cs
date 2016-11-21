using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	public GameObject gunMuzzle;
	public GameObject gunPivot;
	public GameObject bullet;

	// Update is called once per frame
	void Update () {
		gunPivot.transform.rotation = GvrController.Orientation;

		if (GvrController.ClickButtonDown)
		{
			Shoot ();
		}
	}

	void Shoot() {
		GameObject bullet = (GameObject)Instantiate(this.bullet, gunMuzzle.transform.position, Quaternion.identity);
		bullet.GetComponent<Rigidbody> ().AddForce(gunPivot.transform.forward * 1000);
	}
}
