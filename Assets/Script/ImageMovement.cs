using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMovement : MonoBehaviour
{
    public Joystick joystick;

    public float runSpeed = 40f;
    public float horizontalMove = 0f;
    public float verticalMove = 0f;

    void Start()
    {

        
    }

    
    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        verticalMove = joystick.Vertical * runSpeed;
        transform.position += new Vector3(horizontalMove * Time.deltaTime, verticalMove * Time.deltaTime, 0);
    }

	
	


	// The following methods are meant to be set up as "mappings" in the inspector panel of an OscIn object.

	public void OnReceiveFloat(float value)
	{
		//floatInputSlider.value = value * 0.5f + 0.5f;
		//floatInputLabel.text = value.ToString();
	}


	public void OnReceiveDouble(double value)
	{
		//doubleInputSlider.value = (float)(value * 0.5d + 0.5d);
		//doubleInputLabel.text = value.ToString();
	}


	public void OnReceiveInt(int value)
	{
		//intInputSlider.value = Mathf.InverseLerp(int.MinValue, int.MaxValue, value);
		//intInputLabel.text = value.ToString();
	}


	public void OnReceiveLong(long value)
	{
		//longInputSlider.value = (float)((value / (double)long.MaxValue) * 0.5f + 0.5f);
		//longInputLabel.text = value.ToString();
	}


	public void OnReceiveString(string value)
	{
		//stringInputField.text = value;
	}


	public void OnReceiveChar(char value)
	{
		//charInputField.text = value.ToString();
	}


	public void OnReceiveBool(bool value)
	{
		//boolInputToggle.isOn = value;
		//boolInputLabel.text = value.ToString();
	}


	public void OnReceiveColor(Color32 value)
	{
		//colorInputImage.color = value;
	}

	/*
	public void OnReceiveBlob(byte[] value)
	{
		// Presuming we are receiving a image in png or jpeg format.
		if (_blobInputTexture == null) _blobInputTexture = new Texture2D(2, 2);
		_blobInputTexture.LoadImage(value);
		blobInputRawImage.texture = _blobInputTexture;
	}


	public void OnReceiveTimeTag(OscTimeTag timetag)
	{
		timetagYearInputField.text = timetag.time.Year.ToString();
		timetagMonthInputField.text = timetag.time.Month.ToString();
		timetagDayInputField.text = timetag.time.Day.ToString();
		timetagHourInputField.text = timetag.time.Hour.ToString();
		timetagMinuteInputField.text = timetag.time.Minute.ToString();
		timetagSecondInputField.text = timetag.time.Second.ToString();
		timetagMillisecondInputField.text = timetag.time.Millisecond.ToString();
		timetagImmediateIinputToggle.isOn = timetag.immediately;
	}


	public void OnReceiveImpulse()
	{
		StartCoroutine(FlashImageCoroutine(impulseInputImage));
	}


	public void OnReceiveNull()
	{
		StartCoroutine(FlashImageCoroutine(nullInputImage));
	}


	public void OnReceiveEmpty()
	{
		StartCoroutine(FlashImageCoroutine(emptyInputImage));
	}


	public void OnReceiveMidi(OscMidiMessage message)
	{
		midiPortInputField.text = message.port.ToString();
		midiStatusInputField.text = message.status.ToString();
		midiData1InputField.text = message.data1.ToString();
		midiData2InputField.text = message.data2.ToString();
	}
	*/
}
