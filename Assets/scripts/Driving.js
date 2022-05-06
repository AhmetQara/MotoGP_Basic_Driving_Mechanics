
var leftWheel : WheelCollider;
var rightWheel : WheelCollider;
var maxTorque= 50.0;
var centerOfMass : Transform;

function Start () {	
	
	//rigidbody.centerOfMass.y = 0;	
	GetComponent.<Rigidbody>().centerOfMass = centerOfMass.localPosition; //Hier legen wir den Schwerpunkt des Autos/Rigidbodys auf die Position des Objektes centerOfMass.
	
}

function FixedUpdate () {
			
	leftWheel.motorTorque =  maxTorque * Input.GetAxis("Vertical");
	rightWheel.motorTorque = maxTorque * Input.GetAxis("Vertical");	
	
	leftWheel.steerAngle = 10 * Input.GetAxis("Horizontal");
	rightWheel.steerAngle = 10 *  Input.GetAxis("Horizontal");	
			
}

