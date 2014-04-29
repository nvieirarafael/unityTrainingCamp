using UnityEngine;
using System.Collections;

/// <summary>
/// A simple character input. Arrows to move, left SHIFT to run, SPACE to jump.
/// </summary>
public class MySimpleCharacterInput : RaycastCharacterInput
{

	/// <summary>
	/// IF true always run.
	/// </summary>
	public bool alwaysRun;

	/// <summary>
	/// If true dropping from a passthrough platform requires user to press down and then jump.
	/// </summary>
	public bool jumpAndDownForDrop;

	private int movingDirection;

	void Update ()
	{
		if (Input.GetButton("Restart")) {
			Application.LoadLevel(0);
		}

		jumpButtonHeld = false;
		jumpButtonDown = false;
		dropFromPlatform = false;

		x = 0.5f * Input.GetAxis("Horizontal");
		y = (Input.GetButton("Down")) ? -1 : 1;

		// Left Shift to run
		if (alwaysRun || Input.GetButton("Speed")) x *= 2;

		if (!jumpAndDownForDrop) dropFromPlatform = true;

		if (Input.GetButton("Jump")) {
			jumpButtonHeld = true;
			if (Input.GetButtonDown("Jump")) {
				if (jumpAndDownForDrop && Input.GetKey("down")) {
					dropFromPlatform = true;
				} else {
					jumpButtonDown = true;
				}
				swimButtonDown = true;
			} else {
				jumpButtonDown = false;
				swimButtonDown = false;
			}
		} else {
			jumpButtonDown = false;
			swimButtonDown = false;
		}
	}
}
