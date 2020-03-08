using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    public GameObject player;
    private AudioSource soundsrc;
    private Animator anim;
    public AudioClip []clip;
    // Start is called before the first frame update
    void Start()
    {
        soundsrc = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.tag == "player1")
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log(clip.Length);
                
                anim.SetTrigger("Hit");
                
            }
        if (player.tag == "player2")
            if (Input.GetKeyDown(KeyCode.Period))
            {
                anim.SetTrigger("Hit");
               
            }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (player.tag == "player1")
        {
            soundsrc.PlayOneShot(clip[0]);
            ScoreManager.scoreIncrement1(1);
        }

        if (player.tag == "player2")
        {
            soundsrc.PlayOneShot(clip[1]);
            ScoreManager.scoreIncrement2(1);
        }
        if (other.gameObject.tag == "mole")
        {
            other.gameObject.SetActive(false);
            Debug.Log("Hit");
            //wait for 2 seconds then regenerate
            StartCoroutine(Regenerate(other));
        }
        Debug.Log(other);

    }

    IEnumerator Regenerate(Collider egg)
    {
        yield return new WaitForSeconds(2);
        egg.gameObject.SetActive(true);
    }
}
