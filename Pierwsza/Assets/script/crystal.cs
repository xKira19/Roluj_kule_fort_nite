using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crystal : MonoBehaviour {

    public GameObject particles;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            Destroy(gameObject);
            Instantiate(particles, transform.position, Quaternion.identity);

        }
            if (leaveCrystal() == 1) 
        {
            SceneManager.LoadScene("menu");
        }
    }
    int leaveCrystal()
    {
        crystal[] crystals = Component.FindObjectsOfType<crystal>();
        return crystals.Length;
    }
}
