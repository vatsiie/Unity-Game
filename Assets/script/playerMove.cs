using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerMove : MonoBehaviour
{
    public float speed;
    private int count;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI winnerText;
    
    private Rigidbody rb;
     private void Start()
     {
       rb = GetComponent<Rigidbody>();
      count=0;
      displayText();
     }
    
    private void  FixedUpdate()
    {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveh,0.0f, movev);
        rb.AddForce(movement*speed);
    } 
    private void OnTriggerEnter(Collider other)
    {

      if(other.gameObject.CompareTag("PickUp"))
      {
      //Destroy(other.gameObject);
    other.gameObject.SetActive(false);
        count= count+1;
        displayText();
        
      }
     
    }
    void displayText()
     {
      countText.text= "Count: "+ count.ToString();
      if (count==5)
      {
        winnerText.gameObject.SetActive(true);
      }

     }
}
