using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Memo
// https://qiita.com/4_mio_11/items/e7b0a5e65c89ac9d6d7f#こんな時はどうすれば
// https://www.crossroad-tech.com/entry/Unity_VisualStudioCode4#２The-NET-CLI-Tools-cannot-be-located-が出る

public class Armadillidiidae : MonoBehaviour
{
    public double direction = 0.0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0);
    }
}
