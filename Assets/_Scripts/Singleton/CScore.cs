using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Test récupération du score dans level 2
        if(CGameManager._instance!=null)
            GameObject.Find("ScoreTxt").GetComponent<Text>().text = CGameManager._instance.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
