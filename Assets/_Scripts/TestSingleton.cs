using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CGameManager._instance.initializeScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
