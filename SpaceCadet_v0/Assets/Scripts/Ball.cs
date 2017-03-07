using UnityEngine;
using System.Collections;

public class TheBall : MonoBehaviour
{

    public float speed;

    private Rigidbody ballRB;

    void Start()
    {
    	speed = 8.0f;
        ballRB = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, -2.0f);

        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
      //  ballRB.AddForce(movement * speed);
    }
}
