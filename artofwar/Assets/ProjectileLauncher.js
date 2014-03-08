#pragma strict

public var chickencount : int = 5;

function Update () {
	if(Input.GetKeyDown("space")) {
		if(chickencount > 0) {
			chickencount=chickencount-1;
			Instantiate(GameObject.Find("Chicken Projectile"),transform.position + Vector3(0,3,0), Quaternion.identity);
			
		}
	}
}