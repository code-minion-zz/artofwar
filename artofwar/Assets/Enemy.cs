using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Object BarPrefab;

	// Use this for initialization
	void Start () {
		GameObject go = Instantiate(BarPrefab) as GameObject;
		go.GetComponent<HPBarHider>().Initialize(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
