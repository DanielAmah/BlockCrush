#pragma strict
var doorObject:GameObject;
var openedDoor:boolean;
function Start () {
	openedDoor=true;
}

function Update () {
	
}

//function OnTriggerEnter(other:Collider){
//	if (openedDoor){
//		doorObject.GetComponent.<Animation>().Play();
//		openedDoor=false;
//		Debug.Log("open");
//	}
//}

function OnTriggerStay(other:Collider){
	if (openedDoor){
		doorObject.GetComponent.<Animation>().Play();
		openedDoor=false;
		Debug.Log("open");
	}
}