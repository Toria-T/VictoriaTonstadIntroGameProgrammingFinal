using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseView : MonoBehaviour
{
    public enum RotationAxes {MouseXandY = 0, MouseX = 1, MouseY = 2}
    public RotationAxes axes = RotationAxes.MouseXandY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            //insert code here
        }
        else
            if(axes == RotationAxes.MouseY)
        {
            //insert code here
        }
        else
        {
            //insert code here
        }
    }
}
