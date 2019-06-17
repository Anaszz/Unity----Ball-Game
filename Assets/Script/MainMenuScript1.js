#pragma strict


 function start (){

 }
 function Update(){

 }


 function OnCollisionEnter(collision: Collision){

	 if(collision.gameObject.name == "boule2"){
	 	Application.LoadLevel("n");
	 }
 }









