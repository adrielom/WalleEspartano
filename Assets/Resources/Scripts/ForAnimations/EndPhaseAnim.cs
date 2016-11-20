using UnityEngine;
using System.Collections;

public class EndPhaseAnim : MonoBehaviour {

	Animator a;

	void Start () {
		a = GetComponent <Animator> ();

    }

    public void EndPhaseOn () {
        a.SetBool ("EndPhase", true);

    }

    public void EndPhaseOff () {
        a.SetBool ("EndPhase", false);
    }
}
