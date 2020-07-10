using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour
{
    public static CGameManager _instance;


    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
            

    }

    public void initializeScene()
    {
        //Charger les données persistantes game state données
        //Charger le system et dépendences 

        Debug.Log("Loading...");
    }
}
