using UnityEngine;

public class Animation : MonoBehaviour
{
    private float timerBullets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerBullets += Time.deltaTime;
        transform.position += new Vector3(0f, 0f, 0.05f);

        if (timerBullets >= 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
