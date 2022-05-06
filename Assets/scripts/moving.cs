using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	private Vector3 moveDirection = Vector3.zero;

	public float speed = 60.0F;
	public float torque =10F;

	public Rigidbody motorcycle;
	//public Vector3 teleportPoint;
	//public Transform target;
	//public Quaternion Myrotation = Quaternion.Euler(0,30, 0);
	public Vector3 eulerAngleVelocity;



	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().rotation = Quaternion.identity;
		motorcycle = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

		if (Input.GetKey ("w")) {

		
			//motorcycle.MovePosition(transform.position + transform.forward* speed * Time.deltaTime);
			motorcycle.AddForce(transform.forward* speed);


			//moveDirection *= speed;

			Debug.Log("pressed");
		}

		
		if (Input.GetKey ("s")) {
			
			
			//motorcycle.MovePosition(transform.position + transform.forward* speed * Time.deltaTime);
			motorcycle.AddForce(transform.forward* -1 *speed);
			
			
			//moveDirection *= speed;
			
			Debug.Log("pressed");
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			
			//float angle = Quaternion.Angle(transform.rotation, target.rotation);
			//motorcycle.MoveRotation(motorcycle.rotation + speed * Time.fixedDeltaTime);
			//motorcycle.MoveRotation(transform.rotation.y.)
			//motorcycle.MovePosition(transform.Myrotation + transform.right* speed * Time.deltaTime);
			//motorcycle.MoveRotation(transform.rotation.eulerAngles.Equals(Myrotation));
			//moveDirection *= speed;
			//Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
			//motorcycle.MoveRotation(motorcycle.rotation.eulerAngles.y* deltaRotation);

			float turn = Input.GetAxis("Horizontal");
			motorcycle.AddTorque(transform.forward*-1 * torque * turn);
			motorcycle.AddTorque(transform.up * torque * turn);

			
			Debug.Log("right");
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			
			
			//motorcycle.MovePosition(transform.position + transform.right* -1 * speed * Time.deltaTime);
			float turn = Input.GetAxis("Horizontal");

			motorcycle.AddTorque(transform.forward*-1 * torque * turn);
			motorcycle.AddTorque(transform.up * torque * turn);


			//moveDirection *= speed;
			
			Debug.Log("left");
		}
	}
}
