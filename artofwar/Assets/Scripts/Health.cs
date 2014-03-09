using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int max = 3;
	int current = 3;
	public HPBarHider hpBar;
	
	public void Add(int value)
	{
		current += value;
	}

	public void Subtract(int value)
	{
		current -= value;

		hpBar.SetHealth(current);

		Debug.Log (current);

		if (current <= 0)
		{
			Debug.Log("current <= 0");
			Die ();
		}
	}

	public int GetMax()
	{
		return max;
	}

	public int GetCurrent()
	{
		return current;
	}

	void Update()
	{

	}

	void Die()
	{
		Debug.Log ("DESTROYED");
		Destroy(hpBar.gameObject);
		Destroy(gameObject);
	}
}
