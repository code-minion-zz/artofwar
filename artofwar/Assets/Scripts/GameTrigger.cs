using UnityEngine;
using System.Collections;

public class GameTrigger : MonoBehaviour {

	public bool Triggered = false;
	public string DiscriminateString = "Enemy";
	public string Callback = "TrapTriggered";

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (Triggered) return;
		if (other.gameObject.CompareTag(DiscriminateString))
		{
			Triggered = true;
			SendMessageUpwards(Callback, SendMessageOptions.DontRequireReceiver);
			//NGUITools.FindInParents<Trap>(transform).TrapTriggered();
		}
	}
}
