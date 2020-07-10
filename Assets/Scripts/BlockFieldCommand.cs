using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockFieldCommand : MonoBehaviour{
  public GameObject blockField;
  public GameObject eventSystem;
  public void registerBlock(){
    AddBlockData addBlockData=eventSystem.GetComponent(typeof(AddBlockData)) as AddBlockData;
    InputField inputField=blockField.GetComponent(typeof(InputField)) as InputField;
    addBlockData.addBlockData(inputField.text);
  }
}
