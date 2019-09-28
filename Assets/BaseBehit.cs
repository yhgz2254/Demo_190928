using UnityEngine;

public class BaseBehit : MonoBehaviour {
    int weight = 0;
    int power = 0;

    bool isBehitBackward = false;

    public enum Status
    {
        IDLE,
        MOVE,
        ATTACK,
        BEHIT
    }

    public Status curState;

    private void Awake() {
        this.curState = Status.IDLE;
    }
    private void Update() {
        if (this.curState == Status.IDLE)
        {
            
        }
        else if (this.curState == Status.BEHIT)
        {
            Debug.Log("");
        }
    }

    public void compareToBehit (int p, int w) {
        if (p - w > 0)
        {
            this.isBehitBackward = true;
        }
        else
        {
            this.isBehitBackward = false;
        }
    }
}