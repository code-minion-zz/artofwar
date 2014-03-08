#pragma strict

@script RequireComponent(CharacterController)

function Update () {
	var controller : CharacterController = GetComponent(CharacterController);
	var movement = Vector3(0,-1*Time.deltaTime,0);
	controller.Move(movement);
	transform.LookAt(Camera.main.transform.position, -Vector3.up);
}