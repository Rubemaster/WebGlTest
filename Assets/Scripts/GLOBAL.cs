using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLOBAL : MonoBehaviour
{
  public class BlockData{
    public bool active;
    public string host;
    public string value;
    public int id;
    public BlockData(bool activeIn,string hostIn, string valueIn,int idIn){
      active=activeIn;
      host=hostIn;
      value=valueIn;
      id=idIn;
    }
  }
  public static List<BlockData> blockData;
  public static int id;
  void Start(){
    blockData=new List<BlockData>();
  }
}
