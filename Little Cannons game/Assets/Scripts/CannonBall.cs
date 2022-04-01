using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
   public Cannon parent;
   float StunTimer = 0.3f;

   void Start(){
    StartCoroutine(DestroyAfterTime());

   }

    IEnumerator DestroyAfterTime(){
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cannon")
        {
            Cannon hittedCanon = collision.gameObject.GetComponent<Cannon>();
            if(hittedCanon != parent){
                hittedCanon.Stun(StunTimer);
                Destroy(gameObject);
            }

        }
    }
}
