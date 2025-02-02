using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private static int score = 0; // Puntaje total (se mantiene entre Squares)

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que colisiona es el "Player" (el círculo)
        if (other.CompareTag("Player"))
        {
            int puntos = 0;

            // Comprobar el Tag del Square (el objeto donde está este script)
            switch (gameObject.tag)
            {
                case "puntos100":
                    puntos = 100;
                    break;
                case "puntos200":
                    puntos = 200;
                    break;
                case "puntos300":
                    puntos = 300;
                    break;
                case "puntos500":
                    puntos = 500;
                    break;
                case "puntos1000":
                    puntos = 1000;
                    break;
                default:
                    return; // Si el tag no coincide con ninguno, salimos sin hacer nada
            }

            // Sumar puntos al total
            score += puntos;

            // 📌 Mensaje en consola
            Debug.Log("Puntos ganados: " + puntos + " | Tienes en total: " + score);
        }
    }
}

