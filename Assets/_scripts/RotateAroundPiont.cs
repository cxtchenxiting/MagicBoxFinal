using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPixot : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotObject;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }
}