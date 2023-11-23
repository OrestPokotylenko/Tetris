using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public GameObject tetriminosI;
    public GameObject tetriminosJ;
    public GameObject tetriminosL;
    public GameObject tetriminosO;
    public GameObject tetriminosS;
    public GameObject tetriminosT;
    public GameObject tetriminosZ;

    public GameObject GetRandomTetriminos()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(0,7);

        switch (randomNumber)
        {
            case 0:
                return tetriminosI;
            case 1:
                return tetriminosJ;
            case 2:
                return tetriminosL;
            case 3:
                return tetriminosO;
            case 4:
                return tetriminosS;
            case 5:
                return tetriminosT;
            default:
                return tetriminosZ;
        }
    }
}
