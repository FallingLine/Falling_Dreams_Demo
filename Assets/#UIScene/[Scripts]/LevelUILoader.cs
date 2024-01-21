using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUILoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            LoadLevelUI();
        }
    }

    public void LoadLevelUI()
    {
        StartCoroutine(LoadUI(1));
    }

    IEnumerator LoadUI(int levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load LevelUI scene
        SceneManager.LoadScene(levelIndex);
    }
}
