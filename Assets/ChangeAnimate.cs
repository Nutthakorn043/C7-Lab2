using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
    public void getAnimatorDefeate() {
        this.GetComponent<Animator>().Play("Silly Dancing");
    }
    public void getAnimatorRumba() {
        this.GetComponent<Animator>().Play("mixamo_com");
    }
}
