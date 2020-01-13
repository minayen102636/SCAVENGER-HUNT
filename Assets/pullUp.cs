using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullUp : MonoBehaviour
{
    public bool can_pull = false ;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (can_pull)
        {
            float height = Mathf.Clamp(transform.localPosition.y + 1f, 0, 320) ;
            transform.localPosition = new Vector3(transform.position.x , height , transform.position.z) ;
        }
    }

    public void pull()
    {
        can_pull = true ;
    }

    public void end()
    {
        Time.timeScale = 0;
    }
}

