using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotTaking : MonoBehaviour
{
    [SerializeField] KeyCode _screenshotKey = KeyCode.C;
    int _screenshotIndex = 0;
	
	// Update is called once per frame
	void Update()
    {
		if (Input.GetKeyDown(_screenshotKey))
        {
            if (System.IO.File.Exists("Screenshot(" + _screenshotIndex + ").png"))
            {
                _screenshotIndex++;
            }
            ScreenCapture.CaptureScreenshot("Screenshot(" + _screenshotIndex + ").png");
            _screenshotIndex++;
        }
	}
}