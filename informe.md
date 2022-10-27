## Práctica 3: Delegados, Eventos

#### Ejercicio 1

Para la primera parte de este ejerciciose han añadido varios ficheros, entre ellos `typeB.cs`. En este fichero se ha añadido un `OnCollisionEnter` con una colision como parametro. En este momento miramos el tag de la colisión si esta es de `Player` en ese caso se hace un array de `GameObjects` con el tag **tipoA** y los acercamos al objeto **tipo C**.

```cs
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
```

En la segunda parte editamos el fichero `typeA.cs`. Hacemos como en el apartado anterior, miramos que la colision sea del **Player** y esta vez hacemos un array con objetos **tipoB**. Los recorremos mediante un bucle, y los vamos agrandando.

```cs
private void OnCollisionEnter(Collision collision) {
  if (collision.gameObject.tag == "Player") {
    gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    GameObject[] tipoB = GameObject.FindGameObjectsWithTag("tipoB");
    for (int i = 0; i < tipoB.Length; i++) {
      tipoB[i].transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
  }
}
```

**Video**

#### Ejercicio 2

Para este apartado se ha implementado en el `update` del fichero `characterController.cs` un apartado que va midiendo la distancia del **Player** al objeto **tipoC** en el caso de que el jugador se acerque, se harán dos arrays cada una de un objeto diferente. Los objetos **tipoA** saltan y cambiaran de color, y los objetos **tipoB** se orientaran.

```cs
GameObject[] tipoC = GameObject.FindGameObjectsWithTag("tipoC");
for (int i = 0; i < tipoC.Length; i++) {
  float distancia = Vector3.Distance(tipoC[i].transform.position, gameObject.transform.position);
  if (distancia < 3f) {
    GameObject[] tipoA = GameObject.FindGameObjectsWithTag("tipoA");
    GameObject[] tipoB = GameObject.FindGameObjectsWithTag("tipoB");
    for(int j = 0; j < tipoA.Length; j++) {
      tipoA[j].GetComponent<Renderer>().material.color = Random.ColorHSV();
      tipoA[j].GetComponent<Rigidbody>().AddForce(0,5,0);
    }
    for (int j = 0; j < tipoB.Length; j++) {
      tipoB[j].transform.LookAt(GameObject.FindWithTag("tipoC").transform);
    }
    //salto();
    //Orientar();
  }
}
```

**video**