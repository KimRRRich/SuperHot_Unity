using UnityEngine;

namespace Digital.Weapons
{
    public class Bullet : MonoBehaviour
    {
        //public enum Type
        //{
        //    PLAYER, ENEMY
        //}
        //public Type type;

        [SerializeField] private float force;
        private Rigidbody rb;
        public float speed = 8.0f;
        public GameObject player;
        private Vector3 moveDirection;

        [HideInInspector] public Vector3 direction=new Vector3(0,0,1);

        private void Start()
        {
            player = GameObject.Find("Player");
            moveDirection = (player.transform.position - this.transform.position).normalized;
            moveDirection.y = 0;
            Destroy(gameObject,6);
            //rb = GetComponent<Rigidbody>();

            //rb.AddForce(moveDirection * Time.fixedUnscaledDeltaTime * 100, ForceMode.Force);
        }

        private void Update()
        {
            //Debug.Log("BulletUpdate");
            transform.Translate(moveDirection * Time.deltaTime * speed);
        }

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("OnCollisionEnter!");
            //Debug.Log("OnCollisionEnter!");
            if (other.GetComponent<Collider>().CompareTag("Player"))
            {
                Debug.Log("Player get shooted!");
            }
            else if (other.GetComponent<Collider>().CompareTag("Wall"))
            {
                Destroy(gameObject);
                Debug.Log("Wall get shooted!");
            }
        }
    }
}
