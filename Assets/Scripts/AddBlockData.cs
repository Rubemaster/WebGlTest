using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBlockData : MonoBehaviour{
  public GameObject blockDataPrefab;
  public GameObject scrollContent;
  public GameObject eventSystem;
  public void addBlockData(string value){
    GLOBAL.blockData.Add(new GLOBAL.BlockData(true,"telecom",value,GLOBAL.id));
    GLOBAL.id++;
  }
  private GLOBAL.BlockData getBlockDataById(int idIn){
    for(int i=0;i<GLOBAL.blockData.Count;i++){
      if(GLOBAL.blockData[i].id==idIn){
        return GLOBAL.blockData[i];
      }
    }
    return new GLOBAL.BlockData(false,"N/A","Malfunction",-1);
  }
  private void makeDisplay(float y, int addressId){
    GameObject newDisplay=Instantiate(blockDataPrefab,scrollContent.transform);
    DisplayCommand displayCommand=newDisplay.GetComponent(typeof(DisplayCommand)) as DisplayCommand;
    
  }
}
