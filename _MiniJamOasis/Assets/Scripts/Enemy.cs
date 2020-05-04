using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public float speed;
    public float distanceControl;
    public float distance;
    public bool Chase;
    private bool face;
    public bool attacking;
    [SerializeField]private int life;
    private SpriteRenderer _sr;
    private Animator _anim;
    // Start is called before the first frame update
    void Awake(){
        _sr = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        distance = Vector2.Distance(Player.transform.position , this.gameObject.transform.position);

    }
    void Dying(){
        if(life <= 0){
            Destroy(this.gameObject);
        }
    }
    /*void ChaseYes(){
        if(Chase){
            if((Player.transform.position.x > this.transform.position.x) ){
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
            _anim.SetBool("Run", true);
            _anim.SetBool("Idle", false);
            if(!face){
                flip(); 
            }        
        }
            else if((Player.transform.position.x < this.transform.position.x) ){
                transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
                 _anim.SetBool("Run", true);
                _anim.SetBool("Idle", false);
                if(face){
                    flip();
                }
            }
        }
        
    }*/
    void Attack(){
        if(distance < distanceControl){
            _anim.SetBool("Attack", true);
             _anim.SetBool("Run", false);
             _anim.SetBool("Idle", false);
             
             attacking = true;
        }
    }
    void EndAttack(){
        if(attacking){
            _anim.SetBool("Run", true);
            _anim.SetBool("Attack", false);
            attacking = false;
        }
    }

    void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.CompareTag("Attack")){
            life--;
            Dying();
        }
        if(outro.gameObject.CompareTag("Player")){
            Chase = true;
            Attack();
        }
    }
    void flip(){
        face = !face; 
        Vector3 scala = this.transform.localScale;

        scala.x *= -1;

        this.transform.localScale = scala;
    }
     
}
