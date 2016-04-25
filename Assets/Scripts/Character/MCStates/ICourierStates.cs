using UnityEngine;
using System.Collections;

public interface ICourierStates {

    void UpdateState();

    void ToIdle();

    void ToWalking();

    void ToTalking();

    void ToDriving();
}
