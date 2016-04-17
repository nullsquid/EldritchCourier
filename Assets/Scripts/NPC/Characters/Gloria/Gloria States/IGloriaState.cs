using UnityEngine;
using System.Collections;

public interface IGloriaState{

    void Update();

    void ToAcquaintedState();

    void ToFriendlyState();

    void ToUpsetState();
	
}
