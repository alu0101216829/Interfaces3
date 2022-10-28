using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typeA : MonoBehaviour
{
  public characterController notificar;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    notificar.Salto += miRespuesta;
  }

  private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
      GameObject[] tipoB = GameObject.FindGameObjectsWithTag("tipoB");
      for (int i = 0; i < tipoB.Length; i++) {
        tipoB[i].transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
      }
    }
  }

  void miRespuesta() {
    gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    gameObject.GetComponent<Rigidbody>().AddForce(0, 0.01f, 0);
  }
}
