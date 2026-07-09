using System.Collections;
using UnityEngine;
public class GameOverEffect : MonoBehaviour
{
    CanvasGroup canvasGroup;
    RectTransform rectTransform;
    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup.alpha = 0f;
        rectTransform.localScale = Vector3.zero;
    }
    void OnEnable()
    {
        StartCoroutine(PlayEffect());
    }
    IEnumerator PlayEffect()
    {
        float time = 0f;
        float duration = 0.5f;
        while (time < duration)
        {
            time += Time.unscaledDeltaTime;
            float t = time / duration;
            canvasGroup.alpha = t;
            rectTransform.localScale = Vector3.Lerp(
                Vector3.zero,
                Vector3.one,
                t);
            yield return null;
        }
        canvasGroup.alpha = 1f;
        rectTransform.localScale = Vector3.one;
    }
}
