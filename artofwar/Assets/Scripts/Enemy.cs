using UnityEngine;
using System.Collections;


public class Enemy : MonoBehaviour {

	public Object BarPrefab;
	Health myHP;

	// Use this for initialization
	void Start () {
		myHP = GetComponent<Health>();
		GameObject go = Instantiate(BarPrefab) as GameObject;
		myHP.hpBar = go.GetComponent<HPBarHider>();
		myHP.hpBar.Initialize(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
