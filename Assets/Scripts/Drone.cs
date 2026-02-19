using UnityEngine;

public class Drone : Vehicle // INHERITANCE
{
    // POLYMORPHISM: Il drone vola (asse Y), l'auto no.
    public override void Move() {
        transform.Translate(Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime);
        Debug.Log("Il drone sta fluttuando...");
    }

    void Update() {
        Move();
    }
}