using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Memo
// https://qiita.com/4_mio_11/items/e7b0a5e65c89ac9d6d7f#こんな時はどうすれば
// https://www.crossroad-tech.com/entry/Unity_VisualStudioCode4#２The-NET-CLI-Tools-cannot-be-located-が出る

public class Armadillidiidae : MonoBehaviour
{
    public float speed = 0.03f;

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
        this.transform.position += new Vector3(-speed, 0, 0);
    }

    void Animate()
    {
        float angle = 120.0f;
        Vector3 axis = new Vector3(0, 0, 1);

        this.transform.RotateAround(this.transform.position, axis, angle * Time.deltaTime);
    }
}
