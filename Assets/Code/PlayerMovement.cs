using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;   // Velocidad de movimiento del jugador
    public Transform cameraTransform;  // Transform de la cámara

    void Update()
    {
        // Captura la entrada horizontal y vertical
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calcula la dirección de movimiento en relación a la rotación de la cámara
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Asegura que el movimiento esté en el plano XZ
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        // Direcciona el movimiento basado en la cámara
        Vector3 moveDirection = forward * moveZ + right * moveX;

        // Aplica el movimiento al jugador
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
