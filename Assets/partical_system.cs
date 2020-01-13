using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class partical_system : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
    		gameObject.GetComponent<ParticleSystem>().Play();
    }

    public void SwitchScene()
    {
    	SceneManager.LoadScene("finalscene");
    }
}

