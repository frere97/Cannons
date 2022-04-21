using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float MaxRotatez = 90f;
    Vector3 rotation;
    protected float rotationModifier = 1;
    Vector3 LastFrameRotation;
    public GameObject CannonBall;
    public Transform CannonBallSpawnPoint;
    public bool Stunned;
    public float CannonBallSpeed = 1f;
    public bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teste");
    }

    // Update is called once per frame
    void Update()
    {

         rotation =  new Vector3(0, 0, rotationModifier * Time.deltaTime * 90f * ModifiersValues.cannonSpeedModifierValue);

        //rotate the cannon with time having rotation as a parameter
       if(!Stunned){ transform.Rotate(rotation);}
        

        if(transform.localEulerAngles.z > MaxRotatez ){
           transform.localEulerAngles = LastFrameRotation;
            rotationModifier *= -1;
        }
        
    }


    void LateUpdate()
    {
        LastFrameRotation = transform.localEulerAngles;
    }

    public void Shoot(){
        if(!Stunned && this.gameObject.activeSelf && canShoot){
            GameObject cannonBall = Instantiate(CannonBall, CannonBallSpawnPoint.position, Quaternion.identity);
            cannonBall.GetComponent<Rigidbody2D>().AddForce(CannonBallSpawnPoint.up * CannonBallSpeed);
            cannonBall.GetComponent<CannonBall>().parent = this;
            canShoot = false;
            StartCoroutine(WaitToShoot());
        }
    }

    IEnumerator WaitToShoot(){
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }

    public void Stun(float time){
        Stunned = true;
        StartCoroutine(StunnedTimer(time));
    }

    IEnumerator StunnedTimer(float time){
        yield return new WaitForSeconds(time);
        Stunned = false;
    }
    
}
