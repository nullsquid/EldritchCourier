using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CharStats : MonoBehaviour {
    #region unchanging variables
    public float walkSpeed = 2.5f;
    public float runSpeed = 3.5f;
    #endregion

    #region changing variables
    public float hunger;
    public float fatigue;
    public float needToPee;
    #endregion
}
