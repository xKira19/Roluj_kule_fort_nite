using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    public GameObject ballPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;
    public GameObject levelBase;

    void Start()
    {
        GameObject Sphere = GameObject.Instantiate(ballPrefab);
        Sphere.name = "Sphere";
        Sphere.transform.position = transform.position + Vector3.up * 2f;


        Camera camera = GameObject.Instantiate(cameraPrefab);
        CameraControler cameraControler = camera.GetComponent<CameraControler>();
        cameraControler.Sphere = Sphere.transform;

        Light light = GameObject.Instantiate(lightPrefab);
        light.color = Color.white;
        light.intensity = 0.5f;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;
    }
	
	
	void Update () {
		
	}
}
