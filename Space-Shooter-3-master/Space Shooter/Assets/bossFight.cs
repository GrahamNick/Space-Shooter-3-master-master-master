using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFight : MonoBehaviour {
	public float BossWaitTime;
	public float nextAnimTime;
	public float bossHealth;
	public float moveBy;
	// Use this for initialization
	void Start () {
		StartCoroutine (BossFight ());
	}
	IEnumerator BossFight() {
		yield return new WaitForSeconds (BossWaitTime);
		while (transform.position.z < 24f) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + moveBy);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
