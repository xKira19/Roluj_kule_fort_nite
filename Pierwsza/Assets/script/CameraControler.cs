using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {

    public Transform Sphere;

	void Update () {
        Rigidbody rigidbody = Sphere.GetComponent<Rigidbody>();
        Vector3 vector = new Vector3(0, 2f, -3f);
        float velocity = rigidbody.velocity.sqrMagnitude;

        vector = vector * (1f + velocity / 25f);
        Vector3 newPosition = Sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*2f);
        transform.LookAt(Sphere);

        
		
	}
}
