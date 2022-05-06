using UnityEngine;
using System.Collections;

public class CarMovementScript : MonoBehaviour {

	public float MotorForce; 
	public WheelCollider wheelcolfl;
	public WheelCollider wheelcolfr;
	public WheelCollider wheelcolrl;
	public WheelCollider wheelcolrr;
	public float SteerForce;
	public float BrakeForce;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float v = Input.GetAxis ("Vertical") * MotorForce;
		float h = Input.GetAxis ("Horizontal") * SteerForce;
		wheelcolrl.motorTorque = v; 
		wheelcolrr.motorTorque = v;

		wheelcolfl.steerAngle = h; 
		wheelcolfr.steerAngle = h;

		if (Input.GetKey(KeyCode.Space))  { 
			wheelcolrr.brakeTorque = BrakeForce;
			wheelcolrl.brakeTorque = BrakeForce; 

		} 
		if (Input.GetKeyUp(KeyCode.Space)) 
		
		{
			wheelcolrr.brakeTorque = 0;
		    wheelcolrl.brakeTorque = 0; 
		} 
	} 
	
}
