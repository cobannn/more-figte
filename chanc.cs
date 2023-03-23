using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanc : MonoBehaviour
{

    public Sprite[] imgs;

    public int Index = 0;

    void ChangeImg()
    {
        if (imgs.Length > Index) 
        {
           GetComponent<SpriteRenderer>().sprite = imgs[Index];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeImg();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeImg();
    }
}
