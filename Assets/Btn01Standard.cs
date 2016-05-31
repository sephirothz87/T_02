using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Btn01Standard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("click Btn01Standard");
        //Application.LoadLevel("scene_02");
        SceneManager.LoadScene("scene_02");
    }
}
