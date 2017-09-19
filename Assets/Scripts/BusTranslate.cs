using UnityEngine;
using System.Collections;

public class BusTranslate : MonoBehaviour {
	void Update() {
		transform.Translate (Vector3.forward * Time.deltaTime);
	}
}
