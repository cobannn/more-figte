using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepole : MonoBehaviour
{

    public GameObject eLiters, eNums, ePole;

    GameObject[] Liters;
    GameObject[] Nums;
    GameObject[] Pole;

    int LengthPole = 10;

    void CreatePole()
    {
        Vector3 StarPoze = transform.position;

        float XX = StarPoze.x + 1;
        float YY = StarPoze.y - 1;

        Liters = new GameObject[LengthPole];
        Nums = new GameObject[LengthPole];

        for (int i = 0; i < LengthPole; i++)
        {
            Liters[i] = Instantiate(eLiters);
            Liters[i].transform.position = new Vector3(XX, StarPoze.y, StarPoze.z);
            Liters[i].GetComponent<chanc>().Index = i;
            XX++;

            Nums[i] = Instantiate(eNums);
            Nums[i].transform.position = new Vector3(StarPoze.x, YY, StarPoze.z);
            Nums[i].GetComponent<chanc>().Index = i;
            YY--;

        }

        XX = StarPoze.x + 1;
        YY = StarPoze.y - 1;

        Pole = new GameObject[LengthPole];

        for (int Y = 0; Y < LengthPole; Y++)
        {
            for (int X = 0; X < LengthPole; X++)
            {
                Pole[X] = Instantiate(ePole);
                Pole[X].GetComponent<chanc>().Index = 0;
                Pole[X].transform.position = new Vector3(XX, YY, StarPoze.z);

                Pole[X].GetComponent<klicpole>().WhoPerent = this.gameObject;

                Pole[X].GetComponent<klicpole>().CoordX = X;
                Pole[X].GetComponent<klicpole>().CoordY = Y;

                XX++;
            }
            XX = StarPoze.x + 1;
            YY--;
        }
    }

    void Start()
    {
        CreatePole();
    }
    void Update()
    {
        
    }

    public void WhoClick(int X, int Y)
    {
        Pole[X].GetComponent<chanc>().Index = 1;
    }
}
