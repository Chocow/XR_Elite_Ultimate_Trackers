using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullets;
    private float shootRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootRate += Time.deltaTime;
        if(shootRate >= 2f)
        {
            Instantiate(bullets, transform.position + new Vector3(0.02f, 0.05f, 0.5f), transform.rotation);
            shootRate = 0f;
        }
    }
}
