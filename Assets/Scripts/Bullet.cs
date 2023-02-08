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
        private float speed = 10.0f;
        public GameObject player;
        private Vector3 moveDirection;
        public GameObject Canvas;
        private bool BulletGameOver;
        //public GameObject menu;

        [HideInInspector] public Vector3 direction=new Vector3(0,0,1);

        private void Start()
        {
            player = GameObject.Find("Player");
            moveDirection = (player.transform.position - this.transform.position).normalized;
            moveDirection.y = 0;
            Destroy(gameObject,6);
            BulletGameOver = false;
           
        }

        private void Update()
        {
            //Debug.Log("BulletUpdate");
            transform.Translate(moveDirection * Time.deltaTime * speed);
           
        }

        public void OnTriggerEnter(Collider other)
        {
            //Debug.Log("OnCollisionEnter!");
            //Debug.Log("OnCollisionEnter!");
            if (!BulletGameOver)
            {
                if (other.GetComponent<Collider>().CompareTag("Player"))
                {
                    //Debug.Log("Player get shooted!");
                    player.GetComponent<PlayerController>().GameOver();
                }
                else if (other.GetComponent<Collider>().CompareTag("Wall"))
                {
                    Destroy(gameObject);
                    //Debug.Log("Wall get shooted!");
                }
            }
            
        }

      
    }
}
