using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Color randomSelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomSelectedColor;
    }

    private Color GetRandomColor()
    {
        return new Color(r: UnityEngine.Random.Range(0f, 1f),
                         g: UnityEngine.Random.Range(0f, 1f),
                         b: UnityEngine.Random.Range(0f, 1f));
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}