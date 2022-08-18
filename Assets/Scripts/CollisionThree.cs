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

if (itemCollide.transform.parent.GetComponentInParent<PlayerSize>() != null)
{
    Debug.Log("tiene encogedor");
} else {Debug.Log(itemCollide.name);}


}

private void OnCollisionExit(Collision other) {
    timeInWall = 0;
    
}

private void OnCollisionStay(Collision other) {

        if (other.gameObject.CompareTag("Posicionador")){

            timeInWall += Time.deltaTime;

            if (timeInWall >= cooldown){
                transform.position = newlocation.position;
                other.gameObject.transform.Rotate(0, 90, 0);
                }            

    }
}
}
