using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    public GameObject GameOverText;

    public static bool GameOverState = false;

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        Eat eat = Player.GetComponent<Eat>();
        
        GameObject Enemy1 = GameObject.Find("Enemy1");
        Eat eat2 = Enemy1.GetComponent<Eat>();

        GameObject Spawner = GameObject.Find("Spawner");
        Spawn spawn = Spawner.GetComponent<Spawn>();

        if (GameOverState == false)
        {
            if (eat.FoodEaten + eat2.FoodEaten >= spawn.FoodPoolMax) // Level won
            {
                if (eat.FoodEaten >= Eat.FoodNeeded)
                {
                    LoadNextLevel();
                }
                else // Game over
                {
                    GameOver();
                }
            }
        }

    }

    void OnDestroy()
    {
        GameOverState = false;
    }

    void GameOver()
    {
        UnityEngine.Debug.Log("GAME OVER");
        GameOverText.SetActive(true);
        Time.timeScale = 0f;
        GameOverState = true;

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }



}
