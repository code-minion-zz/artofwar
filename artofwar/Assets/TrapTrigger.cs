using UnityEngine;
using System.Collections;

public class TrapTrigger : MonoBehaviour {

	public bool Triggered = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (Triggered) return;
		if (other.gameObject.layer == LayerMask.NameToLayer("Character"))
		{
			Triggered = true;
			NGUITools.FindInParents<Trap>(transform).TrapTriggered();
		}
	}
}
