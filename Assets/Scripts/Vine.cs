using UnityEngine;

public class Vine : MonoBehaviour
{
    public HingeJoint2D hangJoint;
    public HingeJoint2D grabJoint;
    public GameObject grabSpot;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponentInParent<Frog>() != null)
        {
            col.gameObject.GetComponentInParent<Frog>().GrabVine(gameObject);
        }
    }

    private void Start()
    {
        grabJoint.anchor = new Vector2(0, -GetComponent<SpriteRenderer>().size.y / 2);
        hangJoint.anchor = new Vector2(0, GetComponent<SpriteRenderer>().size.y / 2);
    }
}