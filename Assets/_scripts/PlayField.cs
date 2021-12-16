using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayField : MonoBehaviour
{
    public static PlayField instance;

    public GameObject bottomPlane;
    public GameObject N, S, W, E;

    public int gridSizeX, gridSizeY, gridSizeZ;
    public Transform[,,] theGrid;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        theGrid = new Transform[gridSizeX, gridSizeY, gridSizeZ];
    }

    public Vector3 Round(Vector3 vec)
    {
        return new Vector3(Mathf.RoundToInt(vec.x),
                           Mathf.RoundToInt(vec.y),
                           Mathf.RoundToInt(vec.z));
    }

    public bool CheckInsideGrid(Vector3 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridSizeX &&
                (int)pos.z >= 0 && (int)pos.z < gridSizeZ &&
                (int)pos.y >= 0);
    }

    public void UpdateGrid(TetrisBlocks block)
    {
        for (int x =0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                for (int y = 0; y < gridSizeY; y++)
                {
                    if(theGrid[x,y,z].parent == block.transform)
                    {
                        theGrid[x, y, z] = null;
                    }
                }
            }
        }

        foreach(Transform child in block.transform)
        {
            Vector3 pos = Round(child.position);
            if (pos.y < gridSizeY)
            {
                theGrid[(int)pos.x, (int)pos.y, (int)pos.z] = child;
            }
        }
    }

    public Transform GetTransformOnGridPos(Vector3 pos)
    {
        if (pos.y > gridSizeY - 1)
        {
            return null;
        }
        else
        {
            return theGrid[(int)pos.x, (int)pos.y, (int)pos.z];
        }
    }


    private void OnDrawGizmos()
    {
        if (bottomPlane != null)
        {
            //resize bottom plane
            Vector3 scaler = new Vector3((float)gridSizeX / 10, 1, (float)gridSizeZ / 10);
            bottomPlane.transform.localScale = scaler;

            //reposition
            bottomPlane.transform.position = new Vector3(transform.position.x + (float)gridSizeX / 2-5,
                                                         transform.position.y - (float)gridSizeY/2,
                                                         transform.position.z + (float)gridSizeZ / 2-5);

            //retile material
            bottomPlane.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = new Vector2(gridSizeX, gridSizeZ);
        }

        if (N != null)
        {
            //resize bottom plane
            Vector3 scaler = new Vector3((float)gridSizeX / 10, 1, (float)gridSizeY / 10);
            N.transform.localScale = scaler;

            //reposition
            N.transform.position = new Vector3(transform.position.x + (float)gridSizeX / 2 - 5,
                                               transform.position.y + (float)gridSizeY / 2 - 5,
                                               transform.position.z + (float)gridSizeZ / 2);

            //retile material
            N.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = new Vector2(gridSizeX, gridSizeY);
        }

        if (S != null)
        {
            //resize bottom plane
            Vector3 scaler = new Vector3((float)gridSizeX / 10, 1, (float)gridSizeY / 10);
            S.transform.localScale = scaler;

            //reposition
            S.transform.position = new Vector3(transform.position.x + (float)gridSizeX / 2 - 5,
                                               transform.position.y + (float)gridSizeY / 2 - 5,
                                               transform.position.z - (float)gridSizeZ / 2);

            //retile material
            S.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = new Vector2(gridSizeX, gridSizeY);
        }

        if (E != null)
        {
            //resize bottom plane
            Vector3 scaler = new Vector3((float)gridSizeX / 10, 1, (float)gridSizeY / 10);
            E.transform.localScale = scaler;

            //reposition
            E.transform.position = new Vector3(transform.position.x + (float)gridSizeX / 2,
                                               transform.position.y + (float)gridSizeY / 2 - 5,
                                               transform.position.z + (float)gridSizeZ / 2 - 5);

            //retile material
            E.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = new Vector2(gridSizeZ, gridSizeY);
        }

        if (W != null)
        {
            //resize bottom plane
            Vector3 scaler = new Vector3((float)gridSizeX / 10, 1, (float)gridSizeY / 10);
            W.transform.localScale = scaler;

            //reposition
            W.transform.position = new Vector3(transform.position.x - (float)gridSizeX / 2,
                                               transform.position.y + (float)gridSizeY / 2 - 5,
                                               transform.position.z + (float)gridSizeZ / 2 - 5);

            //retile material
            W.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = new Vector2(gridSizeZ, gridSizeY);
        }
    }


}
