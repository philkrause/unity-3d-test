 using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;

	public Text winText;


	private Rigidbody rb;
    public GameObject planesObject;
    public Rigidbody playerRigidbody;
    public float movementSpeed; 

	public bool t;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		winText.text = "";
	}
	
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);

		if (Input.GetKeyDown("space"))
		{
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			rb.AddForce (jump);
		}
			

	}
	void Update()
	{
		// Call SetWinText to check if the conditions are met for "Level Complete"
		SetWinText();
	}


	// SetWinText checks if the player has reached the last child and if the player has stopped moving
    void SetWinText ()
	{
		if (HasPlayerReachedLastChild()) 
		{
			print("Level Complete");
			winText.text = "Level Complete";
		}
	}


    bool HasPlayerReachedLastChild()
    {
        Transform lastChild = planesObject.transform;
        bool t = Vector3.Distance(playerRigidbody.position, lastChild.position) < 1.0f; 
		print(this.t);
		return this.t;
    }


}