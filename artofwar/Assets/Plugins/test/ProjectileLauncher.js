#pragma strict

public var chickencount : int = 5;

function Update () {
	if(Input.GetKeyDown("space")) {
		if(chickencount > 0) {
			chickencount=chickencount-1;
			var newchicken=Instantiate(GameObject.Find("Chicken Projectile"),transform.position + Vector3(0,2,0), transform.rotation);
			newchicken.rigidbody.AddForce(newchicken.transform.forward * 9000);
			newchicken.rigidbody.AddForce(newchicken.transform.up * 500);
			newchicken.rigidbody.AddForce(newchicken.transform.right * Random.Range(-100,100));
			newchicken.name="Chicken Clone";
		}
	}
}