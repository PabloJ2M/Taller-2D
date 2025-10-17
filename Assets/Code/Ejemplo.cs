using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    [SerializeField] private int _numero;

    WaitUntil _yield;

    private void Awake()
    {
        if (Random.value > 0.5f)
            _yield = new WaitUntil(() => _numero > 40);
        else
            _yield = new WaitUntil(() => _numero < 40);
    }

    IEnumerator Comparacion()
    {
        yield return _yield;
        print("se presiono el boton");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Comparacion());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopAllCoroutines();
    }
}