using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCommand : MonoBehaviour
{
  public GameObject displayText;
  public GameObject displayToggle;
  public int id;

  public void setText(string newText){
    Text thisText=displayText.GetComponent(typeof(Text)) as Text;
    thisText.text=newText;
  }
  public void setCheck(bool isOnIn){
    Toggle toggle=displayToggle.GetComponent(typeof(Toggle)) as Toggle;
    toggle.isOn=isOnIn;
  }
}
