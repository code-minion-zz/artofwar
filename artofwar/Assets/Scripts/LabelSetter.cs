using UnityEngine;
using System.Collections;

public class LabelSetter : MonoBehaviour {

	public ProjectileLauncher pLauncher;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (pLauncher)
		{
			GetComponent<UILabel>().text = pLauncher.chickencount.ToString();
		}
	}
}
