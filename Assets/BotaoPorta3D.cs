
using UnityEngine;
using UnityEngine.InputSystem;

public class BotaoPorta3D : MonoBehaviour
{
    public Porta porta;

    void Update()
    {
        if (Mouse.current != null &&
            Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray raio = Camera.main.ScreenPointToRay(
                Mouse.current.position.ReadValue());

            if (Physics.Raycast(raio, out RaycastHit hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    porta.AbrirPorta();
                }
            }
        }
    }
}