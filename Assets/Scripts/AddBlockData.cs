using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBlockData : MonoBehaviour{
  public GameObject blockDataPrefab;
  public GameObject scrollContent;
  public GameObject eventSystem;
  public void addBlockData(string value){
    GLOBAL.blockData.Add(new GLOBAL.BlockData(true,"telecom",value));
  }
  private void makeDisplay(float y, int addressId){

  }
}
