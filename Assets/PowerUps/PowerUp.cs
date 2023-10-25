using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private List<PowerUp> _powerupList;
    protected float scaleUpSize = 0.7f;
    protected float ScaleDownSize = 0.2f;
    protected float speed = 2;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _powerupList[Random.Range(0, _powerupList.Count)].Activate(collision);
        Destroy(gameObject);
    }

    public virtual void Activate(Collision collision)
    {

    }
}
