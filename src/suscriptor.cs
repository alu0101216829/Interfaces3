using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suscriptor : MonoBehaviour
{
  public notificador notificar;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    notificar.OnMiEvento += miRespuesta;
  }

  void miRespuesta(){
    gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
  }

}
