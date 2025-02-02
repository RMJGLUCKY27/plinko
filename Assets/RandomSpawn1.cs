using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawn1 : MonoBehaviour
{

    Vector2 posicionrandom;
    public float xrango = 5f;
    public float yrango = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float xposicion = Random.Range(0 - xrango, 0 + xrango);
        float yposicion = Random.Range(4.7f - yrango, 4.7f + yrango);
        posicionrandom = new Vector2(xposicion, yposicion);
        transform.position = posicionrandom;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);

        }
    }
}
