using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour
{
    private Animator anim;
    private float time = 1;
        // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.Play("ChestAnimation");
            Destroy(gameObject, 1f);

           // SceneManager.LoadScene("Menu");
        }
    }

    bool Timer()
    {
        if(time< 0) { return true; }
        time -= Time.deltaTime;
        return false;
    }
}
