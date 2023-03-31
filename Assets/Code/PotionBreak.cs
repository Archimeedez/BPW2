using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotionBreak : MonoBehaviour
{
    Animator anim;
    //private Transform PotionBreakPoint;
    [SerializeField] GameObject PotionParticles;
    [SerializeField] GameObject Tornado;
    private Transform PotionBreakPoint;

    // Start is called before the first frame update
    void Start()
    {
        //PotionBreakPoint = GameObject.Find("PotionBreakPoint").transform;
        anim = GetComponent<Animator>();
        PotionBreakPoint = GameObject.Find("PotionBreakPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            //this.transform.position = PotionBreakPoint.position;
            //PotionParticles.SetActive(true);
            anim.SetBool("IsBroken", true);
            StartCoroutine(PlayTornado());
        }
    }

    IEnumerator PlayTornado()
    {
        yield return new WaitForSecondsRealtime(1);
        PotionParticles.SetActive(true);
        Tornado.SetActive(true);
        anim.SetBool("IsBroken", false);
        yield return new WaitForSecondsRealtime(4);
        PotionParticles.SetActive(false);
        Tornado.SetActive(false);
        this.transform.position = PotionBreakPoint.position;
        //anim.SetBool("IsBroken", false);
    }
}
