using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjetcs : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset=gameObject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePoint);
        double x = Math.Round(worldPos.x, 0);
        double y = Math.Round(worldPos.y, 0);
        double z = Math.Round(worldPos.z, 0);
        return new Vector3((float)x / 2, (float)y / 2, (float)z / 2);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}