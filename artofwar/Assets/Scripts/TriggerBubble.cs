using UnityEngine;
using System.Collections;

public class TriggerBubble : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (GetComponent<UITweener>().enabled)
			{
				SendMessageUpwards("TrapHit", other.gameObject, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
