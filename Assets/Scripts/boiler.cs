using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boiler : MonoBehaviour{
  private GameObject parent;
  void Start(){
    parent=gameObject.transform.parent.gameObject;
  }
  void Update(){}
}
