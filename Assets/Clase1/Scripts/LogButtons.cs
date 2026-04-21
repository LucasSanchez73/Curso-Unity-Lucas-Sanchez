using UnityEngine;
using UnityEngine.UI;

public class LogButtons : MonoBehaviour
{
    // TAREA 1: Haz que este botón muestre un mensaje normal en consola (color blanco)
    public void ShowLogInfoMessage()
    {
        Debug.Log("Mira, no rompiste nada... Por ahora");
    }

    // TAREA 2: Haz que este botón muestre una ADVERTENCIA (triángulo amarillo)
    public void ShowLogWarningMessage()
    {
        Debug.LogWarning("Estas a punto de hacer cagadas... Te lo adverti");
    }

    // TAREA 3: Haz que este botón muestre un ERROR (octágono rojo)
    // PLUS: Investiga cómo hacer que Unity se PAUSE automáticamente al pulsar este botón.
    public void ShowLogErrorMessage()
    {
        Debug.LogError("La cagaste, te lo dije... Chernobyl un poroto al lado tuyo");
    
        Debug.Break();
    }

    
}

