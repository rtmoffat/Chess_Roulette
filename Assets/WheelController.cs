using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public bool spinning;
    public int seconds;
    public int max_rotation_time;
    double time_to_stop;

   public void spin()
    {
        spinning = true;
        seconds = Random.Range(5, max_rotation_time);
        time_to_stop = Time.timeAsDouble;
        time_to_stop += (double)seconds;
    }
    // Start is called before the first frame update
    void Start()
    {
        max_rotation_time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.timeAsDouble<time_to_stop) & spinning) {
            transform.Rotate(new Vector3(0, 1, 0), Space.Self);
        }
        else { spinning = false; }
    }
}
