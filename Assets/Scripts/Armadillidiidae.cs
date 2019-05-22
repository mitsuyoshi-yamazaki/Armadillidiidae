using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Memo
// https://qiita.com/4_mio_11/items/e7b0a5e65c89ac9d6d7f#こんな時はどうすれば
// https://www.crossroad-tech.com/entry/Unity_VisualStudioCode4#２The-NET-CLI-Tools-cannot-be-located-が出る

public class Armadillidiidae : MonoBehaviour
{
    public float speed = 0.03f;
    public float distance = 0.0f;
    public Vector3 direction = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.Move();
        this.Animate();
    }

    void Move()
    {
        if (this.distance <= 0.0f)
        {
            switch ((int)Random.Range(0, 4))
            {
                case 0:
                    this.direction = new Vector3(1, 0, 0);
                    break;
                case 1:
                    this.direction = new Vector3(-1, 0, 0);
                    break;
                case 2:
                    this.direction = new Vector3(0, 0, 1);
                    break;
                default:
                    this.direction = new Vector3(0, 0, -1);
                    break;
            }

            this.distance = Random.Range(1, 5) + Random.Range(1, 5);
        }


        this.transform.position += speed * direction;
        this.distance -= speed;
    }

    void Animate()
    {
        float angle = 120.0f;
        Vector3 axis = new Vector3(0, 0, 1);

        this.transform.RotateAround(this.transform.position, axis, angle * Time.deltaTime);
    }
}
