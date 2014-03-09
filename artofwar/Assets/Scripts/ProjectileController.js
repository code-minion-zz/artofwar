#pragma strict
 
var _time:float = 3f;
 
function Update() {
	if(gameObject.name!="Chicken Clone") return;
	var sprr = GetComponent(SpriteRenderer);
	_time=_time-Time.deltaTime;
	if(_time>0 && _time<1) sprr.color.a=_time;
	if(_time<=0) Destroy(gameObject);
}