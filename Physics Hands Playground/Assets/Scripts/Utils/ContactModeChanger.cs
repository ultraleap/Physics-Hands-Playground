using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.PhysicalHands;
using TMPro;

public class ContactModeChanger : MonoBehaviour
{
    [SerializeField]
    private PhysicalHandsButton _button;
    private PhysicalHandsManager _physicalHandsManager;

    private bool _softContact = false;

    [SerializeField]
    private TextMeshPro _text;

    private void OnValidate()
    {
        if(_button == null)
        {
            _button = GetComponent<PhysicalHandsButton>();
        }
        if(_text == null)
        {
            _text = GetComponentInChildren<TextMeshPro>();
        }
    }

    private void Awake()
    {
        if(_button != null )
        {
            _button.OnButtonPressed.AddListener(ButtonPressed);
        }
    }

    private void ButtonPressed()
    {
        _softContact = !_softContact;
        if (_softContact)
        {
            _text.text = "Change to Hard Contact";
        }
        else
        {
            _text.text = "Change to Soft Contact";
        }

        if(_physicalHandsManager == null)
        {
            _physicalHandsManager = FindAnyObjectByType<PhysicalHandsManager>();
        }

        if(_physicalHandsManager != null)
        {
            if (_softContact)
            {
                _physicalHandsManager.SetContactMode(PhysicalHandsManager.ContactMode.SoftContact);
            }
            else
            {
                _physicalHandsManager.SetContactMode(PhysicalHandsManager.ContactMode.HardContact);
            }
        }
    }
}
