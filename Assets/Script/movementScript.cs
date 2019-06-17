
using UnityEngine;

public class movementScript : MonoBehaviour {

	public float thrust;
 	public Rigidbody rb;
	public float vitesse;
	public GameObject deathParticles;
	public Transform[] spawnPoints;
	private int currentPoint;
	public AudioSource audio;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	private int life;
	public Camera[] cameras;
	private int currentCameraIndex;
	public Transform[] portalPoints;
	private int currentPoints;

	void Start() {
		AudioSource[] audiosource = GetComponents<AudioSource>();
		audio = audiosource [0];
		clip1 = audiosource [0].clip;
		clip2 = audiosource [1].clip;
		clip3 = audiosource [2].clip;
		//audio = GetComponent<AudioSource> ();
		currentPoint = 0;
		transform.position = spawnPoints[currentPoint].position;
		currentPoints = 0;
		life = 4;
		currentCameraIndex = 0;
		//Turn all cameras off, except the first default one
		for (int i=1; i<cameras.Length; i++) 
		{
			cameras[i].gameObject.SetActive(false);
		}

		//If any cameras were added to the controller, enable the first one
		if (cameras.Length>0)
		{
			cameras [0].gameObject.SetActive (true);

		}
	}

	void FixedUpdate(){

		if(Input.GetKey ("left"))
		{
			Physics.gravity = new Vector3 (-30, 0, 0);
		}


		if (Input.GetKey ("right")) {
			Physics.gravity = new Vector3 (30, 0, 0);

		}

		if (Input.GetKey ("down")) {
			Physics.gravity = new Vector3 (0, -30, 0);	

		}
		if (Input.GetKey ("up")) {
			Physics.gravity = new Vector3 (0, 30, 0);

		} 

	}
		void OnCollisionEnter(Collision collision){
	
		if (collision.transform.tag == "trap") {
			Instantiate (deathParticles, transform.position, Quaternion.identity);
			transform.position = spawnPoints[currentPoint].position;
			Physics.gravity = new Vector3 (0, -30, 0);	
			life = life -1 ;

			if (life == 3) {
				//AudioClip. (clip);
				audio.PlayOneShot(clip1);
			}

			if (life == 2) {
				audio.PlayOneShot(clip2);
			}

			if (life == 1) {
				audio.PlayOneShot(clip3);
			}

			if (life == 0) {
				Application.LoadLevel ("death");
			}
		}
			

		if (collision.transform.tag == "ball") {
			currentPoint += 1;
			Instantiate (deathParticles, transform.position, Quaternion.identity);
			Physics.gravity = new Vector3 (0, -30, 0);
			transform.position = spawnPoints[currentPoint].position;


			currentCameraIndex ++;

			if (currentCameraIndex < cameras.Length)
			{
				cameras[currentCameraIndex-1].gameObject.SetActive(false);
				cameras[currentCameraIndex].gameObject.SetActive(true);

			}
			else
			{
				cameras[currentCameraIndex-1].gameObject.SetActive(false);
				currentCameraIndex = 0;
				cameras[currentCameraIndex].gameObject.SetActive(true);

			}

		}

		if (collision.transform.tag == "portal+") {
			currentPoints += 1;
			Physics.gravity = new Vector3 (0, -30, 0);
			transform.position = portalPoints [currentPoints].position;
			
		}

		if (collision.transform.tag == "portal-") {
			currentPoints = currentPoints - 1;
			Physics.gravity = new Vector3 (0, -30, 0);
			transform.position = portalPoints [currentPoints].position;

		}



		if (currentPoint >= spawnPoints.Length-1) {
			Application.LoadLevel ("n");
		}
			
	

		}
		
	void OnCollisionExit(Collision boule){
	
	
}
}




