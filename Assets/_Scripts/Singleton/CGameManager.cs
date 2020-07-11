using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour
{
    public static CGameManager _instance;

    [SerializeField] int score;

    public int Score { get => score; set => score = value; }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);//L'objet gameManager ne sera pas détruit lors du chargement de second level
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
        score = 0;
        Debug.Log("Loading...");
    }
}
