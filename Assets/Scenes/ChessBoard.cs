using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece
{
    public string name;
    public Color color;
    public string ability;

    public piece()
    {
        
    }
}

public class square
{
    public Color color;
    public piece pieceholder;
    public square(Color c)
    {

    }
}

public class gamecontroller
{

}
public class board
{
    public Dictionary<string, square> squares;

    public board()
    {
        //a board consists of files and ranks
        //Build from square A1 and end on H8
        //A1 is a black square
        Color cur_color;
        cur_color = Color.black;
        for(char c='a';c<='h';c++)
        {
            for (int i=1;i<=8;i++)
            {
                square s = new square(cur_color);
                if (cur_color == Color.black)
                {
                    cur_color = Color.white;
                }
                else cur_color = Color.black;

                squares.Add(c.ToString() + i.ToString(), s);
                s = null;
            }
        }
    }
}

public class ChessBoard : MonoBehaviour
{
    private void Start()
    {
        
    }
}
