using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoLoading : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 2f;
    public float waitAfterFade = 1f;
    public string nextScene = "SceneMenu";

    void Start()
    {
        StartCoroutine(FadeInAndLoad());
    }

    System.Collections.IEnumerator FadeInAndLoad()
    {
        canvasGroup.alpha = 0f;

        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(t / fadeDuration);
            yield return null;
        }

        yield return new WaitForSeconds(waitAfterFade);

        SceneManager.LoadScene(nextScene);
    }
}
