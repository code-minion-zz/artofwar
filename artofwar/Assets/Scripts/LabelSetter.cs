using UnityEngine;
using System.Collections;

public class LabelSetter : MonoBehaviour {

	public ProjectileLauncher pLauncher;


	// Use this for initialization
	void Start () {
		pLauncher = GameObject.Find("3rd Person Controller").GetComponent<ProjectileLauncher>();
	}
	
	// Update is called once per frame
	void Update () {
		if (pLauncher)
		{
			GetComponent<UILabel>().text = pLauncher.chickencount.ToString();
		}
	}
}
