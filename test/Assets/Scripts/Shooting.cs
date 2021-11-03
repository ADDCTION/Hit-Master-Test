using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private ObjectPooler.ObjectInfo.ObjectType _BulletType;
    [SerializeField]
    private Transform _SpawnPosition;


    private void Update()
    {
        ShootingPistol();
    }

    public void ShootingPistol()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            var pos = Input.mousePosition;
            var ray = Camera.main.ScreenPointToRay(new Vector3(pos.x, pos.y, 0));

            if (Physics.Raycast(ray, out hit))
            {
                var bullet = ObjectPooler._Instance.GetObject(_BulletType);
                bullet.GetComponent<Bullet>().OnCreate(hit.point, transform.rotation);
            }
            
        }
        
    }
   
}



  