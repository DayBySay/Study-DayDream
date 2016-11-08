using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.rotation = GvrController.Orientation;

		RaycastHit hitInfo;
		Vector3 rayDirection = GvrController.Orientation * Vector3.forward;
//		Debug.DrawRay (transform.position, rayDirection * 10, Color.green); デバッグ時に書いとくと便利
		GameObject selectedObject = null;

		if (Physics.Raycast (Vector3.zero, rayDirection, out hitInfo)) {
			if (hitInfo.collider && hitInfo.collider.gameObject) {
				selectedObject = hitInfo.collider.gameObject;
			}
		}

		if (selectedObject == null) {
			return;
		}

		if (!GvrController.TouchDown) {
			return;
		}

		Select (selectedObject);
	}

	void Select(GameObject selectedObject) {
		Destroy (selectedObject);
	}
}
