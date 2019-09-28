using UnityEngine;

public class CharacterController : MonoBehaviour {
    public GameManager myGm;

	public float MoveSpeed;
	public enum CharacterState
	{
		Idle,
		Walk,
		Attack,
		Behit
	}

	public CharacterState curState;
    
	public enum FaceDirection
	{
		Right,
		Left
	}

	public FaceDirection curDirection;

    void Start()
    {
		Debug.Log(GameManager.instance.Setting);
        MoveSpeed = GameManager.instance.Setting.CharacterMoveSpeed;
        NewMethod();
    }

    private void NewMethod()
    {
        Debug.Log(MoveSpeed.ToString());
    }

    // Update is called once per frame
    void Update()
    {
			MoveByInput();


			// if (Input.GetKey(KeyCode.Space))
			// {
			// 	MoveByDirection(new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)));
			// }
    }

	private void OnCollisionEnter(Collision other) {
		Debug.Log("haha");
	}

	void MoveByInput()
	{
		if (Input.GetKey(KeyCode.W))
		{
			curState = CharacterState.Walk;
			transform.Translate(Vector2.up * Time.deltaTime * MoveSpeed);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			curState = CharacterState.Walk;
			transform.Translate(Vector2.left * Time.deltaTime * MoveSpeed);
			curDirection = FaceDirection.Left;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			curState = CharacterState.Walk;
			transform.Translate(Vector2.down * Time.deltaTime * MoveSpeed);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			curState = CharacterState.Walk;
			transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
			curDirection = FaceDirection.Right;
		}
		else if (Input.GetKey(KeyCode.Space))
		{
			curState = CharacterState.Attack;
		}
		else
		{
			curState = CharacterState.Idle;
		}
		
	}

	void MoveByDirection(Vector2 vector2)
	{
		transform.Translate(vector2 * Time.deltaTime * MoveSpeed);
	}
}