using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour {

    public static FloatText popupTextPrefab;
    private static GameObject canvas;

    public static void Intialize()
    {
        canvas = GameObject.Find("Canvas");

    }


    public static void CreateFloatingText(string text, Transform location)
    {
        FloatText instance = Instantiate(popupTextPrefab);

        instance.transform.SetParent(canvas.transform, false);
        instance.SetText(text);
    }
}
