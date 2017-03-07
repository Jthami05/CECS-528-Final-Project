using UnityEngine;
using System.Collections;

public class TheBall : MonoBehaviour
{

    public float speed;
    public float contactSpeed;
    public float speedCap;

    private Rigidbody ballRB;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        Vector3 startMovement = new Vector3(0.0f, 0.0f, 120.0f);
        ballRB.AddForce(startMovement * speed);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, -2.0f);

        ballRB.AddForce(movement * speed);
    }

    //void OnCollisionEnter(Collision info)
    //{
    //    if(info.gameObject.tag == "Bumper")
    //    {
    //        var localVelocity = transform.TransformDirection(ballRB.velocity);
    //        Vector3 contact = new Vector3(-localVelocity.x,0,-localVelocity.z);
    //        print("Ball hit bumper!");
    //        ballRB.AddForce(contact * contactSpeed);

    //    }
    //}
}
