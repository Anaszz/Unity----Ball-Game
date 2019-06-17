#pragma strict


 function start (){

 }
 function Update(){

 }


 function OnCollisionEnter(collision: Collision){

	 if(collision.gameObject.name == "boule1"){
	 	Application.LoadLevel("test");
	 }
 }









