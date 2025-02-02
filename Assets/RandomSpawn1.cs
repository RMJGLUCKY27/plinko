using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawn1 : MonoBehaviour
{
    // Variable para almacenar la nueva posición aleatoria
    Vector2 posicionrandom;
    
    // Rango en el que se puede mover el objeto en el eje X
    public float xrango = 5f;
    
    // Rango en el que se puede mover el objeto en el eje Y
    public float yrango = 0.5f;

    // Start se ejecuta una sola vez cuando el objeto se crea en la escena
    void Start()
    {
        // Genera una posición aleatoria en el eje X dentro del rango definido
        float xposicion = Random.Range(0 - xrango, 0 + xrango);
        
        // Genera una posición aleatoria en el eje Y dentro del rango definido, tomando como base 4.7f
        float yposicion = Random.Range(4.7f - yrango, 4.7f + yrango);
        
        // Asigna la posición aleatoria a la variable de posición
        posicionrandom = new Vector2(xposicion, yposicion);
        
        // Mueve el objeto a la nueva posición generada
        transform.position = posicionrandom;
    }

    // Update se ejecuta en cada frame (cada actualización del juego)
    void Update()
    {
        // Si el jugador presiona la tecla Espacio...
        if (Input.GetKey(KeyCode.Space))
        {
            // Reinicia la escena actual cargándola de nuevo
            SceneManager.LoadScene(0);
        }
    }
}
