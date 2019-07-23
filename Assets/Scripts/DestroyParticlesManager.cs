using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticlesManager : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem particlesPrefab;
    [SerializeField]
    private float maxDuration;

    private Queue<ParticleSystem> pooled = new Queue<ParticleSystem>();


    public void Play(Vector2 position)
    {
        StartCoroutine(PlayParticle(position));
    }

    private IEnumerator PlayParticle(Vector2 position)
    {
        ParticleSystem system;
        if (pooled.Count > 0)
        {
            system = pooled.Dequeue();
            system.gameObject.SetActive(true);
        }
        else
        {
            system = Instantiate(particlesPrefab);
        }

        system.transform.position = position;
        system.Play();
        yield return new WaitForSeconds(maxDuration);
        system.gameObject.SetActive(false);
        pooled.Enqueue(system);
    }


}
