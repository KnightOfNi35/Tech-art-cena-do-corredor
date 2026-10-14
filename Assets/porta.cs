
using UnityEngine;
using System.Collections;

public class Porta : MonoBehaviour
{
    public float altura = 3f;
    public float velocidade = 5f;
    public float tempoAberta = 2f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.localPosition;
    }

    public void AbrirPorta()
    {
        StopAllCoroutines();
        StartCoroutine(MoverPorta());
    }

    IEnumerator MoverPorta()
    {
        Vector3 destino = posicaoInicial + Vector3.up * altura;

        // Abre
        while (Vector3.Distance(transform.localPosition, destino) > 0.01f)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition, destino,
                velocidade * Time.deltaTime);
            yield return null;
        }

        // Espera
        yield return new WaitForSeconds(tempoAberta);

        // Fecha
        while (Vector3.Distance(transform.localPosition, posicaoInicial) > 0.01f)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition, posicaoInicial,
                velocidade * Time.deltaTime);
            yield return null;
        }
    }
}