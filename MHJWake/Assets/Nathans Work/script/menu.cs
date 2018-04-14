using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("with or without sound", 20);//with or without sound
    }

    // Update is called once per frame
    void Update () {
		
	}

    //vocal guide lead, solo guide lead
    public void VocalG() {
        SceneManager.LoadScene("SoloGuideLeadLead", LoadSceneMode.Single);
        Debug.Log("SoloGuideLeadLead Loading");
    }

    public void SoloG() {
        SceneManager.LoadScene("VocalGuideLeadLevel", LoadSceneMode.Single);
        Debug.Log("VocalGuideLeadLevel Loading");
    }
}
