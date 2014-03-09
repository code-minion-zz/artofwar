#pragma strict

public var chickencount : int = 5;
public var slingcount : int = 5;
public var trapcount : int = 5;
public var ponies : ponyswapper;

function Start () {
	ponies = GetComponent(ponyswapper);
}

function Update () {
	if(Input.GetKeyDown("space")) 
	{
		switch (ponies.character)	
		{
		case 0: // trap
		if (trapcount > 0)
		{
			trapcount = trapcount -1;
			var newtrap : GameObject = Instantiate(Resources.Load("Prefabs/Trap"));
			newtrap.transform.position = transform.position + transform.forward;
			newtrap.name = "Trap Clone";
		}
		break;
		case 1: // chicken
		if(chickencount > 0) {
			chickencount=chickencount-1;
			var newchicken=Instantiate(GameObject.Find("Chicken Projectile"),transform.position + Vector3(0,2,0), transform.rotation);
			newchicken.rigidbody.AddForce(newchicken.transform.forward * 9000);
			newchicken.rigidbody.AddForce(newchicken.transform.up * 500);
			newchicken.rigidbody.AddForce(newchicken.transform.right * Random.Range(-100,100));
			newchicken.name="Chicken Clone";
		}
		break;
		case 2: // slingshot
		if (slingcount > 0)
		{
			slingcount = slingcount -1;
			var newbullet : GameObject= Instantiate(Resources.Load("Prefabs/Bullet"),transform.position, transform.rotation); 	
			newbullet.rigidbody.AddForce(newbullet.transform.forward * 9000);
			newbullet.name = "Bullet Clone";
		}
		break;
		}
	
	}
}