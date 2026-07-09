using UnityEngine;
public class Meteor : MonoBehaviour
{
    public float speed = 2f;
    bool destroyedByMissile = false;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    public void HitByMissile()
    {
        destroyedByMissile = true;
    }
    private void OnBecameInvisible()
    {
        if (!destroyedByMissile)
        {
            GameManager.Instance.MeteorMiss();
        }
        Destroy(gameObject);
    }
}
