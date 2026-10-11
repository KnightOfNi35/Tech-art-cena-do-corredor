using UnityEngine;
using UnityEngine.InputSystem;

public class PlayParticle : MonoBehaviour
{
    private ParticleSystem _particleSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            _particleSystem.Play();
        }
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particula colidiu!!!");
    }
}
