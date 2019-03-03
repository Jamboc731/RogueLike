using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

    //shot prefab
    [SerializeField] GameObject shot;
    //last object shot
    GameObject lastShot;
    //is the player firing?
    bool firing = false;
    
    [SerializeField] float fireRate;
    //variable to stop the player firing too fast
    float tick = 0;

	public void Shoot (Vector2 dir)
    {
        //if tick is zero then the player can shoot
        if(tick == 0)
        {
            lastShot = Instantiate (shot, transform.position, Quaternion.identity);
            BasicShot shotScript = lastShot.GetComponent<BasicShot> ();
            shotScript.SetDir(dir);
            Destroy (lastShot, shotScript.GetLifetime());
        }
        //if the player isnt firing then call StartFire()
        if (!firing)
        {
            StartFire ();
        }
    }

    public void StartFire ()
    {
        StartCoroutine (Firing ());
    }

    IEnumerator Firing ()
    {
        //set firing to true so StartFire() isnt called again
        firing = true;
        while (true)
        {
            //increase tick by the amount necessary to make it so that it fires the correct amount of bullets / second
            tick += Time.deltaTime / (1 / fireRate);
            //if tick is 1 then set it back to 0 so that the player can fire again
            if (tick >= 1)
            {
                tick = 0;
            }
            //wait until the end of the frame so that its actually done in a second instead of as fast as dis bitch can go
            yield return new WaitForEndOfFrame ();
        }
    }

    public void EndFire ()
    {
        //if the player stops firing then stop the firing coroutine, set tick back to 0 so that the player fires straight away next time and set firing to false so the StartFire() can be called again
        StopCoroutine (Firing ());
        tick = 0;
        firing = false;
    }

}
