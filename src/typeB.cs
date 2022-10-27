using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typeB : MonoBehaviour
{

  //public characterController notificar;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    //notificar.Orientar +=  miRespuesta; 
  }

  /*void miRespuesta(){
    gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
  }*/

  private void OnCollisionEnter(Collision colission) {
    if (colission.gameObject.tag == "Player") {
      gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
      GameObject[] tipoA = GameObject.FindGameObjectsWithTag("tipoA");
      for (int i = 0; i < tipoA.Length; i++) {
        tipoA[i].transform.LookAt(GameObject.FindWithTag("tipoC").transform);
        Vector3 directions = GameObject.FindWithTag("tipoC").transform.position - tipoA[i].GetComponent<Transform>().position;
        //Debug.DrawRay(gameObject.GetComponent<Transform>().position, directions, Color.red);
        tipoA[i].GetComponent<Rigidbody>().velocity = directions * Time.deltaTime * 10f;             // forward
      }
    }
  }

  
}
