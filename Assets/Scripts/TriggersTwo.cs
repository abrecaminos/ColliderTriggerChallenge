using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersTwo : MonoBehaviour
{
    // Start is called before the first frame update

    private bool escala = false;

    private PlayerSize playerSize;

      private float timerSize = 0;


    void Start()
    {
        playerSize = GetComponent<PlayerSize>();
    }

    private void Update()
    {
        timerSize += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (timerSize >= 0.2f)
        {
            playerSize.changeScale(!escala, other.gameObject);
            escala = !escala;
            timerSize = 0;

        }
    }
}
