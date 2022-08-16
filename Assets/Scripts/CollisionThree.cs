using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionThree : MonoBehaviour
{


    [SerializeField] private Transform newlocation;
    [SerializeField] private GameObject objeto;

    private float cooldown = 2;
private float timeInWall = 0; 



private void OnCollisionEnter(Collision other) {

GameObject itemCollide = other.gameObject;



Debug.Log(itemCollide.name);


/* 
if (itemCollide.transform.parent.GetComponent<PlayerSize>() != null)
{
    Debug.Log("tiene encogedor");
} else {Debug.Log("chau");} */


}

private void OnCollisionExit(Collision other) {
    timeInWall = 0;
    
}

private void OnCollisionStay(Collision other) {

        if (other.gameObject.CompareTag("Posicionador")){

            timeInWall += Time.deltaTime;

            if (timeInWall >= cooldown){
                transform.position = newlocation.position;
                transform.Rotate(0, 90, 0);
                }

               

    }
}
}
