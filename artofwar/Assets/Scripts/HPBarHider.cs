using UnityEngine;
using System.Collections;

public class HPBarHider : MonoBehaviour {

	public UISprite sprite;
	Transform player;
	Transform owner;
	bool initialized = false;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("3rd Person Controller").transform;
	}

	public void Initialize(GameObject go)
	{
		owner = go.transform;
		sprite.SetAnchor(go);
		initialized = true;
	}

	// Update is called once per frame
	void Update () 
	{
		if (!initialized) return;

		float distance = Vector3.Distance(player.position, owner.position);
		if (distance > 20f)
		{
			if (sprite.gameObject.activeSelf)
			{
				NGUITools.SetActive(sprite.gameObject, false);
			}
		}
		else// (distance < 10f)
		{
			if (!sprite.gameObject.activeSelf)
			{
				NGUITools.SetActive(sprite.gameObject, true);
			}
		}
	}
}
