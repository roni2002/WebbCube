// Förslagsvis lägg detta som ett nytt skript på en 3D cube objekt

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    void Start()
    {
        //StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        while (true)
        {
            Debug.Log("Time: " + Time.time);
            UpdateHTMLDOM();
            yield return new WaitForSeconds(1f);

        }

    }

    void UpdateHTMLDOM()
    {
        Debug.Log("Time: " + Time.time);
        // Anropa HTML5 DOM komponenten genom att använda
        // https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html


    }

    // Update is called once per frame
    void Update()
    {

    }
}