using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
  public delegate void mensaje();
  public event mensaje Salto;
  public event mensaje Orientar;

    // Start is called before the first frame update
  [Header("Personaje")]
  [Tooltip("velocidad del personaje")]
  public float velocidad = 2.0f;
  [Header("Con que teclas desea mover el personaje")]
  public bool wasd = true;
  public bool flechas = false;

  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    if (wasd) {
      if (Input.GetKey("s")) {
        //Debug.Log("s");
        gameObject.transform.Translate(0, 0, -7 * Time.deltaTime * velocidad);
      }
      if (Input.GetKey("w")) {
        //Debug.Log("w");
        gameObject.transform.Translate(0, 0, 7 * Time.deltaTime * velocidad);
      }
      if (Input.GetKey("a")) {
        //Debug.Log("a");
        gameObject.transform.Translate(-7 * Time.deltaTime * velocidad, 0, 0);
      }
      if (Input.GetKey("d")) {
        //Debug.Log("d");
        gameObject.transform.Translate(7 * Time.deltaTime * velocidad, 0, 0);
      }
    }
    if (flechas) {
      /*float horizontalInput = Input.GetAxis("Horizontal");
      gameObject.transform.Translate(horizontalInput * velocidad * Time.deltaTime * 7, 0, 0);
      float verticalInput = Input.GetAxis("Vertical");
      gameObject.transform.Translate(0, 0, verticalInput * velocidad * Time.deltaTime * 7);*/
      if (Input.GetKey("down")) {
        //Debug.Log("down");
        gameObject.transform.Translate(0, 0, -7 * Time.deltaTime * velocidad);
      }
      if (Input.GetKey("up")) {
        //Debug.Log("up");
        gameObject.transform.Translate(0, 0, 7 * Time.deltaTime * velocidad);
      }
      if (Input.GetKey("left")) {
        //Debug.Log("left");
        gameObject.transform.Translate(-7 * Time.deltaTime * velocidad, 0, 0);
      }
      if (Input.GetKey("right")) {
        //Debug.Log("right");
        gameObject.transform.Translate(7 * Time.deltaTime * velocidad, 0, 0);
      }
    }

    GameObject[] tipoC = GameObject.FindGameObjectsWithTag("tipoC");
    for (int i = 0; i < tipoC.Length; i++) {
      float distancia = Vector3.Distance(tipoC[i].transform.position, gameObject.transform.position);
      if (distancia < 3f) {
        GameObject[] tipoA = GameObject.FindGameObjectsWithTag("tipoA");
        GameObject[] tipoB = GameObject.FindGameObjectsWithTag("tipoB");
        /*for(int j = 0; j < tipoA.Length; j++) {
          tipoA[j].GetComponent<Renderer>().material.color = Random.ColorHSV();
          tipoA[j].GetComponent<Rigidbody>().AddForce(0,5,0);
        }*/
        /*for (int j = 0; j < tipoB.Length; j++) {
          tipoB[j].transform.LookAt(GameObject.FindWithTag("tipoC").transform);
        }*/
        Salto();
        Orientar();
      }
    }
  }
}
