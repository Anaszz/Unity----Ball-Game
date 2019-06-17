using UnityEngine;

public class FollowMouse : MonoBehaviour {

	public float thrust1;
	public Rigidbody rb1;
	public bool JeMeTouche1;
	public float vitesse1;



	void FixedUpdate(){

		if(Input.GetKey ("left"))
		{
			Physics.gravity = new Vector3 (30, 0, 0);
		}


		if (Input.GetKey ("right")) {
			Physics.gravity = new Vector3 (-30, 0, 0);

		}

		if (Input.GetKey ("down")) {
			Physics.gravity = new Vector3 (0, 30, 0);	

		}
		if (Input.GetKey ("up")) {
			Physics.gravity = new Vector3 (0, -30, 0);

		} 



	}
	void OnCollisionEnter(Collision letrucquejetouche1){

		JeMeTouche1 = true;
	}
	void OnCollisionExit(Collision letrucquejetouche1){

		JeMeTouche1 = false;


	}
}




