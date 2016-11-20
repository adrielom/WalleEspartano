using UnityEngine;
using System.Collections;

public class LauncherAnim : MonoBehaviour {

	Animator a;

	void Start () {
		a = GetComponent <Animator> ();

    }

    public void LauncherOn () {
        a.SetBool ("launcher", true);

    }

    public void LauncherOff () {
        a.SetBool ("launcher", false);
    }

}
