using UnityEngine;
using System.Collections;

public class LabelSetter : MonoBehaviour {

	public ProjectileLauncher pLauncher;

	public enum EMode
	{
		chicken,
		bullet,
		trap
	}
	public EMode mode = EMode.chicken;

	// Use this for initialization
	void Start () {
		pLauncher = GameObject.Find("3rd Person Controller").GetComponent<ProjectileLauncher>();
	}
	
	// Update is called once per frame
	void Update () {
		if (pLauncher)
		{
			string toUse = "";
			switch (mode)
			{
			case EMode.chicken:
				toUse = pLauncher.chickencount.ToString();
				break;
			case EMode.bullet:
				toUse = pLauncher.slingcount.ToString();
				break;
			case EMode.trap:
				toUse = pLauncher.trapcount.ToString();
				break;
			}

			//GetComponent<UILabel>().text = pLauncher.chickencount.ToString();
			GetComponent<UILabel>().text = toUse;
		}
	}
}
