using UnityEngine;

public class Vehicle : MonoBehaviour 
{
    // ENCAPSULATION: Variabile privata con controllo logico nel Setter
    private float m_Speed = 5.0f;
    public float Speed {
        get { return m_Speed; }
        set {
            if (value < 0) Debug.LogError("Velocità negativa non ammessa!");
            else m_Speed = value;
        }
    }

    // ABSTRACTION: Metodo semplice che nasconde complessità interna
    public void StartEngine() {
        InjectFuel();
        IgniteSpark();
        Debug.Log("Motore avviato!");
    }

    private void InjectFuel() => Debug.Log("Iniezione carburante...");
    private void IgniteSpark() => Debug.Log("Scintilla!");

    // POLYMORPHISM: Metodo virtuale pronto per l'override
    public virtual void Move() {
        transform.Translate(Vector3.forward * Time.deltaTime * m_Speed);
    }
}