//Bibliotheken/Asembly Referenz/Namespaces

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Deklaration einer Klasse

    //public         -> acess modifier (Zugriffsreche / Keyword (vorreservierte )
    // class         -> keyword zur Deklaration einer Klasse
    // ExampleClass  -> identifier (Name der Klasse)
    // :MonoBehaviour->Erstellen eine Unterklasse von Monobehaviour
    // {}            -> Scope/Wirkungsbereich (Was ist alles in der Klasse erhalten)




    // int           -> Variablentyp (In diesem Fall Integer - Ganze Zahl)
    // ganzeZahlVariable -> identifier (Name der Variable)
    // ;             -> Ende des Statements (Deklaration der Variable)

    // Zuweisungsoperator (assigment operator) -> = (Istgleichzeichen)
    // Beide Seiten des Zuweisungsoperators müssen den GLEICHEN TYP haben


public class ExampleClass : MonoBehaviour
{
    // Deklaration von Variable
    // Variablen sind Container für Value (Werte) oder References (Verweise)



    // Variablen mit Werten             Wenn ich was mit = mache ist das der Fixwert und bei neuer Instanze angezeigt.
    public int ganzeZahlVariable = 4; // Ganze Zahlen             -Integer  - Instanzvariable (innerhalb der Klasse gültig (sehen im Inspector und ändern))
    public float gleitKommaVariable = 4.2f; // Gleitkommazahlen
    public string textVariable = "Do ist da Text"; // Text
    public bool boolVariable = true; // Binäre Entscheidung (Boolischer Wert)

    public Vector3 vectorVariable;  // Vector 3 hat float Variablen x,y,z;


    // Variablem mit Referenzen
    public Rigidbody rigiBodyVariable;
    public BoxCollider boxColliderVariable;
    public BoxCollider boxColliderVariable2;
    public Transform transformVariable;
    public GameObject gameObjectVariable;
    public ExampleClass ec;
    public Button btnVariable;


    // Deklaration von Funktionen       (Was soll Funktion machen)
    // public       -> access modifier (Wer darf die Funktion verwenden?)
    // void (kein Wert)        -> return type (Gibt die Funktion Wert zurückgegeben) (int, Transform, Button, Float,...)
    // TestFunktion             -> identifier (Name der Funktion)
    // ()                       -> Parameterliste (In diesem Fall ist sie leer)
    // {}                       -> Scope / Geltungsbereich (Was ist alles in der Funktion erhalten)
    public void TestFunktion()
    {
        //Aufruf einer Funktion - Teil 2 (Wann soll die Funktion ausgeführt werden)


        print();               // Kriagma von MonoBehavior
        //print             -> Name der Funktion
        // ()               -> Parameterliste
        // ;                -> Ende des Aufrufs

 
}
    // Automatisch von Unity aufgerufen im ersten Frame in der Szene. Bezieht sich aufs Objekt.
    public void Start()
    {
        TestFunktion();
    }

    public void Update()
    {
        TestFunktion();
    }
}
