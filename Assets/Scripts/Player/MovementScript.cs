using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //Vari�veis
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        //Define as vari�veis para quando se aperta as setinhas do teclado ou WASD
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove);//define uma variavel de movimenta��o apenas nos eixos X e Z, juntando as variaveis criadas anteriormente 
        transform.Translate(moveDirection * speed * Time.deltaTime);//Utiliza a vari�vel para que o objeto se mova dentro do jogo ao apertar as teclas
    }
}
