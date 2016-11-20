using UnityEngine;
using System.Collections;
using System;

public class BoxManager : MonoBehaviour {

    //Singleton
    public static BoxManager instance = null;

    //Inicialização dos Objetos e variáveis
    public GameObject launcher;
    public GameObject box;
    public int wonBoxes, lostBoxes;

    void Awake () {
        //Settando Singleton
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy (gameObject);
        }

    }

	// Instacia a caixa ao digitar
	void LateUpdate () {
        if ((Input.anyKeyDown)) {
            InstantiateBox ();
            
        }
    }

    // Instacia a caixa ao clicar
    void OnMouseDown () {
        InstantiateBox ();
        

    }

    // Método de instaciar as caixas
    void InstantiateBox () {
        launcher.GetComponentInParent<LauncherAnim> ().LauncherOn ();
        Instantiate (box, launcher.transform.position, Quaternion.identity);
        StartCoroutine (ResetLauncher ());
    }

    IEnumerator ResetLauncher () {
        yield return new WaitForSeconds (1f);
        launcher.GetComponentInParent<LauncherAnim> ().LauncherOff ();
    }
}
