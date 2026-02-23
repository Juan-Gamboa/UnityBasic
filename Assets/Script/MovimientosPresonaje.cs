using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosPresonaje : MonoBehaviour
{
    //movimiento
    public CharacterController Controlador;

    public float Velocidad = 15f;
    public float Gravedad= -10f;
    public float Saltar = 3f;


    //salto
    public Transform EnElPiso;
    public float DistaciaDelPiso;
    public LayerMask MascaraDelPiso;




    Vector3 VelocidadAbajo;
    bool EstaEnElPiso;

      //camara
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 moveJugador;
    private Vector3 mover;
    void Start()
    {
        
    }

    
    void Update()
    {
        EstaEnElPiso = Physics.CheckSphere(EnElPiso.position, DistaciaDelPiso, MascaraDelPiso);

        if (EstaEnElPiso && VelocidadAbajo.y < 0)
        {
            VelocidadAbajo.y = -2;
        }



        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        mover = new Vector3 (x,0,z);
        moveJugador = Vector3.ClampMagnitude(moveJugador,1);
        moveJugador = mover.x * camRight + mover.z*camForward;
        Controlador.transform.LookAt(Controlador.transform.position + moveJugador);
        Controlador.Move(moveJugador * Velocidad * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && EstaEnElPiso)
        {
            VelocidadAbajo.y = Mathf.Sqrt(Saltar * -2f * Gravedad);
        }

        VelocidadAbajo.y += Gravedad * Time.deltaTime;

        Controlador.Move(VelocidadAbajo * Time.deltaTime);

        camDirection();
        

    }
    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
}
