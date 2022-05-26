using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Create_Board : MonoBehaviour
{
    public GameObject prefab;
    public GameObject new_Square;
    private float spacer = 8.0f;
    public int[,] board;
    public Material square_color;

    // Start is called before the first frame update
    void Start()
    {
        board = new int[9, 9];
        for (int i=1;i<=8;i++)
        {
            for (int j=1;j<=8;j++)
            {
                new_Square=Instantiate(prefab, new Vector3((float)i * spacer, 20.0f-(float) j*spacer, 0.0f), Quaternion.identity);
                square_color=new_Square.GetComponent<Renderer>().material;
                if (((j+i) % 2) == 0)
                {
                    square_color.color = Color.white;
                }
                else square_color.color = Color.black;
                this.board[i, j] = 0;
                Debug.Log(i.ToString());
            }
        }
        Debug.Log(this.board.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
