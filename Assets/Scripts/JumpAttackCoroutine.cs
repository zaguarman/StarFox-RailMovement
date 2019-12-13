using System.Collections;
using UnityEngine;

public class JumpAttackCoroutine : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(ThreeJumpAttack());
			//Jump();
		}
	}

	IEnumerator ThreeJumpAttack()
	{
		Jump(3f);
		yield return new WaitForSeconds(1.8f);
		Jump(3f);
		yield return new WaitForSeconds(1.8f);
		yield return WheelWindJump(5f);
	}

	void Jump(float height)
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 velocity = rb.velocity;
		velocity.y = Mathf.Sqrt(2.0f * 9.8f * height);
		rb.velocity = velocity;
		print("Jump");
	}

	IEnumerator WheelWindJump(float height)
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 velocity = rb.velocity;
		velocity.y = Mathf.Sqrt(2.0f * 9.8f * height);
		rb.velocity = velocity;

		rb.maxAngularVelocity = 100f;
		rb.angularVelocity = Vector3.up * 50f;
		print("WheelWindJump");
		yield return new WaitForSeconds(2.0f);

		rb.angularDrag = 2f;
		while (true)
		{
			print(rb.angularVelocity.magnitude);
			if (rb.angularVelocity.magnitude < 1)
				break;
			yield return null;
		}
		rb.angularVelocity = Vector3.zero;
		rb.angularDrag = 0.05f;
		print("WheelWindJump stopped");
	}
}
