#pragma strict

@script RequireComponent(CharacterController)

function FindClosestPlayer () : GameObject {
	// Find all game objects with tag Player
	var gos : GameObject[];
	gos = GameObject.FindGameObjectsWithTag("Player"); 
	var closest : GameObject; 
	var distance = 200.0; // <-- HOW FAR AWAY THE ENEMY WILL START CHASING FROM
	var position = transform.position; 
	// Iterate through them and find the closest one
	for (var go : GameObject in gos)  { 
		var diff = (go.transform.position - position);
		var curDistance = diff.sqrMagnitude; 
		if (curDistance < distance) { 
			closest = go;
			distance = curDistance;
		} 
	} 
	return closest;
}

function Update () {
	var controller : CharacterController = GetComponent(CharacterController);
	//get player position in relation to us
	var player = FindClosestPlayer();
	var movement = Vector3(0,-1,0);
	if(player == null) {
		controller.Move(movement);
		return;
	}
	//cheap non-mathsy way of doing movement
	var plPosDiff = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * -1);
	movement = Vector3(transform.position.x-plPosDiff.x,-1,transform.position.z-plPosDiff.z) * 5; //<- # at the end is enemy speed
	controller.Move(movement);
}