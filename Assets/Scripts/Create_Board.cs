using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Create_Board : MonoBehaviour
{
    public GameObject prefab;
    private float spacer = 8.0f;
    public int[,] board;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=1;i<=8;i++)
        {
            for (int j=1;j<=8;j++)
            {
                Instantiate(prefab, new Vector3((float)i * spacer, 20.0f-(float) j*spacer, 0.0f), Quaternion.identity);
                Debug.Log(i.ToString());
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
