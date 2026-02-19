using UnityEngine;

// INHERITANCE: Car eredita da Vehicle
public class Car : Vehicle 
{
    void Start() {
        StartEngine(); // Usa il metodo astratto della classe base
    }

    // POLYMORPHISM: Override del movimento (l'auto sterza anche)
    public override void Move() {
        base.Move(); // Muove in avanti
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * 50 * Time.deltaTime);
    }

    void Update() {
        Move();
    }
}