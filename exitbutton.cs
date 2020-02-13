using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class cikis : MonoBehaviour {

	public void LoadsahneLevel (string sahne)
	{
		SceneManager.LoadScene(sahne);
	}

	public void sahneKapat ()
	{
		Application.Quit ();
	}
}