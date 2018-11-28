using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointstext : MonoBehaviour
{
    public TextMesh textMesh;

    void Start()
    {
        point();
    }
    public void point()
    {
        crystal[] crystals = Component.FindObjectsOfType<crystal>();
        textMesh.text = crystals.Length.ToString();
    }

}