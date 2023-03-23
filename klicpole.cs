using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klicpole : MonoBehaviour
{

    public GameObject WhoPerent = null;
    public int CoordX, CoordY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (WhoPerent != null)
        {
            WhoPerent.GetComponent<gamepole>().WhoClick(CoordX, CoordY);
        }
    }
   
}
