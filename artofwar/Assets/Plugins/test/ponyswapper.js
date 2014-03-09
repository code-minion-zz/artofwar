#pragma strict

public var character : int;

function Start () {
	character = 0;
}

function Update () {
	if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
		GameObject.Find("ab").GetComponent(MeshFilter).mesh=Resources.Load("ab", Mesh);
		GameObject.Find("ab").GetComponent(MeshRenderer).material.mainTexture = Resources.Load("Materials/cylinder", Texture2D);
		character = 0;
	}
	if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
		GameObject.Find("ab").GetComponent(MeshFilter).mesh=Resources.Load("sb", Mesh);
		GameObject.Find("ab").GetComponent(MeshRenderer).material.mainTexture = Resources.Load("Materials/cylinder 1", Texture2D);
		character = 1;
	}
	if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
		GameObject.Find("ab").GetComponent(MeshFilter).mesh=Resources.Load("sl", Mesh);
		GameObject.Find("ab").GetComponent(MeshRenderer).material.mainTexture = Resources.Load("Materials/sl", Texture2D);
		character = 2;
	}
}