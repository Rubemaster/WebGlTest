using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLOBAL : MonoBehaviour
{
  public class BlockData{
    public bool active;
    public string host;
    public string value;
    public BlockData(bool activeIn,string hostIn, string valueIn){
      active=activeIn;
      host=hostIn;
      value=valueIn;
    }
  }
  public static List<BlockData> blockData;
  void Start(){
    blockData=new List<BlockData>();
  }
}
