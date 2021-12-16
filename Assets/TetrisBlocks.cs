using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlocks : MonoBehaviour
{
    
    bool CheckValidMove()
    {
        foreach(Transform child in transform)
        {
            Vector3 pos = PlayField.instance.Round(child.position);
            if (!PlayField.instance.CheckInsideGrid(pos))
            {
                return false;
            }
        }

        foreach (Transform child in transform)
        {
            Vector3 pos = PlayField.instance.Round(child.position);
            Transform t = PlayField.instance.GetTransformOnGridPos(pos);
            if(t!=null && t.parent != transform)
            {
                return false;
            }
        }

        return true;
    }
}
