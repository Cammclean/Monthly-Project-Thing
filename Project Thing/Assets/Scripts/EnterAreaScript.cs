using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnterAreaScript : MonoBehaviour {
    public GameObject player;
    public int nextLevel;
    public int currLevel;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject == player)
        {
            SceneManager.LoadScene(nextLevel, LoadSceneMode.Additive);

            GameObject camera = Camera.main.gameObject;

            SceneManager.MoveGameObjectToScene(player, SceneManager.GetSceneAt(nextLevel));
            SceneManager.MoveGameObjectToScene(camera, SceneManager.GetSceneAt(nextLevel));

            StartCoroutine(UnloadScene());
        }

    }

    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.UnloadScene(currLevel);

        StartCoroutine(ClearScene());
    }

    IEnumerator ClearScene()
    {
        yield return new WaitForSeconds(1.0f);
        Resources.UnloadUnusedAssets();
    }
}
