using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TestSingleton : MonoBehaviour
{
    private int score;
    Text str_score;

    void Awake()
    {
        score = CGameManager._instance.Score;
        str_score = GameObject.Find("ScoreTxt").GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        CGameManager._instance.initializeScene();

        str_score.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score : "+score);//verification du score

        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(LoadingLevel());
            
        }
    }

    IEnumerator LoadingLevel()
    {

        while (score < 100)
        {
            score += 10;
            yield return new WaitForSeconds(1);//pour que score s'incrémente à chaque frame, la coroutine restart à l'update suivant
            
            str_score.text = score.ToString();
        }

        print("Inc score");


        yield return new WaitForSeconds(10);

        SceneManager.LoadScene(1, LoadSceneMode.Single);

        CGameManager._instance.Score = score;

        print("Ma coroutine est fini");
    }
}
