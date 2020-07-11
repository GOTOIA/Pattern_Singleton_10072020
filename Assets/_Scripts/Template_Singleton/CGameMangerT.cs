using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManagerT : TSingleton<CGameManagerT>
{

    [SerializeField] int score = 100;

    public static CGameManagerT _instance;

    public void InitializeGame()
    {

        Debug.Log("Initialisation");
    }

    /*public override void Awake()
    {
        Debug.Log("Score" + score);

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }*/
}
