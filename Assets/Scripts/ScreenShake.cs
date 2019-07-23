using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField]
    private Camera camera = null;

    [SerializeField]
    private float duration = 0.2f;
    [SerializeField]
    private float force = 5;

    private Vector3 cameraLocalPosition;
    private float currentForce = 0;


    private void Awake()
    {
        cameraLocalPosition = camera.transform.localPosition;
    }


    [ContextMenu("Play Shake")]
    public void Play()
    {
        StartCoroutine(PlayShake());
    }

    private IEnumerator PlayShake()
    {
        float time = 0;
        currentForce += force;
        while (time < duration)
        {
            time += Time.deltaTime;
            Vector3 pos = camera.transform.localPosition;
            pos.x = Random.Range(-currentForce, +currentForce) * Time.deltaTime;
            pos.y = Random.Range(-currentForce, +currentForce) * Time.deltaTime;
            camera.transform.localPosition = pos;

            yield return null;
        }
        currentForce -= force;
        camera.transform.localPosition = cameraLocalPosition;
    }


}
