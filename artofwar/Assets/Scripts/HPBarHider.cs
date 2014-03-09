using UnityEngine;
using System.Collections;

public class HPBarHider : MonoBehaviour {
	
	public UISprite BarContainerSprite;
	public UISlider Slider;
	Transform player;
	Transform owner;
	bool initialized = false;
	int maxHealth = 3;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("3rd Person Controller").transform;
		Slider = BarContainerSprite.GetComponent<UISlider>();
	}

	public void Initialize(GameObject go)
	{
		owner = go.transform;
		BarContainerSprite.SetAnchor(go);
		initialized = true;
	}

	// Update is called once per frame
	void Update () 
	{
		if (!initialized) return;

		float distance = Vector3.Distance(player.position, owner.position);
		if (distance > 20f)
		{
			if (BarContainerSprite.gameObject.activeSelf)
			{
				NGUITools.SetActive(BarContainerSprite.gameObject, false);
			}
		}
		else// (distance < 10f)
		{
			if (!BarContainerSprite.gameObject.activeSelf)
			{
				NGUITools.SetActive(BarContainerSprite.gameObject, true);
			}
		}
	}
	
	public void SetHealth(int value)
	{
		Slider.value = (float)value/(float)maxHealth;
	}

	public void SetHealthMax(int value)
	{
		
	}
}
