using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{

    private float escalita = 1.3f;

    public void changeScale(bool masomenos, GameObject gameobject)
    {
        if (masomenos)
        {
            gameobject.transform.localScale /= escalita;
        } else { 
          gameobject.transform.localScale *= escalita;
        }
    }





}
