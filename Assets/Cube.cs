// Förslagsvis lägg detta som ett nytt skript på en 3D cube objekt

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

  [DllImport("__Internal")]
  private static extern void Hello();

  [DllImport("__Internal")]
  private static extern void HelloString(string str);

  [DllImport("__Internal")]
  private static extern void PrintFloatArray(float[] array, int size);

  [DllImport("__Internal")]
  private static extern int AddNumbers(int x, int y);

  [DllImport("__Internal")]
  private static extern string StringReturnValueFunction();

  [DllImport("__Internal")]
  private static extern void BindWebGLTexture(int texture);

    void Start()
    {
      Hello();

      HelloString("This is a string.");

      float[] myArray = new float[10];
      PrintFloatArray(myArray, myArray.Length);

      int result = AddNumbers(5, 7);
      Debug.Log(result);

      Debug.Log(StringReturnValueFunction());

      var texture = new Texture2D(0, 0, TextureFormat.ARGB32, false);
      BindWebGLTexture(texture.GetNativeTextureID());
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
