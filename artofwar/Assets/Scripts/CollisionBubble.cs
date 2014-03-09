using UnityEngine;
using System.Collections;

public class CollisionBubble : MonoBehaviour {

	public string DiscriminateTag = "Enemy";
	public string Callback = "TrapHit";
	bool hitOnce = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (hitOnce) return;
		string test = other.tag;
		if (other.CompareTag(DiscriminateTag))
		{
			//if (GetComponent<UITweener>().enabled)
			//{
			SendMessageUpwards(Callback, other.gameObject, SendMessageOptions.DontRequireReceiver);
			//}
			hitOnce = true;
		}
	}
}
