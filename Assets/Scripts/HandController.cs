using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// コントローラの傾きをとってカーソルの位置を動かす
		this.gameObject.transform.rotation = GvrController.Orientation;

		// Rayを使って対象のカーソルに合わさったオブジェクトを取得
		RaycastHit hitInfo;
		Vector3 rayDirection = GvrController.Orientation * Vector3.forward;
//		Debug.DrawRay (transform.position, rayDirection * 10, Color.green); デバッグ時に書いとくと便利
		GameObject selectedObject = null;

		if (Physics.Raycast (Vector3.zero, rayDirection, out hitInfo)) {
			if (hitInfo.collider && hitInfo.collider.gameObject) {
				selectedObject = hitInfo.collider.gameObject;
			}
		}

		// オブジェクトが選択されている、かつコントローラがタップされている時のみ実行
		if (selectedObject != null && GvrController.TouchDown) {
			Destroy (selectedObject);
		}
	}
}
