using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

	public GameTrigger trapTrigger;
	public UITweener trapAction;
	public enum EState
	{
		Untriggered,
		Firing,
		Triggered,
		Resetting
	}
	public EState myState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (myState != EState.Untriggered && myState != EState.Triggered)
		{
			switch (myState)
			{
			case EState.Firing:
				if (trapAction.tweenFactor == 1f)
				{
					myState = EState.Triggered;
				}
				break;
			case EState.Resetting:
				if (trapAction.tweenFactor == 1f)
				{
					myState = EState.Untriggered;
				}
				break;
			}
		}
	}


	public void TrapHit(GameObject other)
	{
		if (myState == EState.Firing) Debug.Log(other + " Has Been Trapped!");
		CharacterController cc = other.GetComponent<CharacterController>();
		cc.enabled = false;
		StartCoroutine(Unfreeze(cc));
	}

	IEnumerator Unfreeze(CharacterController cc)
	{
		yield return new WaitForSeconds(3f);
		cc.enabled = true;
		Destroy(gameObject);
	}

	public void TrapTriggered()
	{
		if (myState == EState.Untriggered) FireAction();
	}

	void FireAction()
	{
		myState = EState.Firing;
		trapAction.PlayForward();
	}

	void ResetAction()
	{
		trapTrigger.GetComponent<GameTrigger>().Triggered = false;
		myState = EState.Resetting;
		trapAction.PlayReverse();
	}
}
