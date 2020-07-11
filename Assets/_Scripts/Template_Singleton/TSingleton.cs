using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSingleton <T> : MonoBehaviour where T : Component
{
    //L'instance est accessible uniquement par le getter
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                //Etre sur qu'il n'y a pas une autre instance de ce type en mémoire
                _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    //Création de l'instance
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();

                }
                
            }
          return _instance;


        }
    }

    //Peut être override dans la classe dérivée
    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }



    }


}
