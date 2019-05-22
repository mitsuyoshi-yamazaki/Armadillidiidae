using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Memo
// https://qiita.com/4_mio_11/items/e7b0a5e65c89ac9d6d7f#こんな時はどうすれば
// https://www.crossroad-tech.com/entry/Unity_VisualStudioCode4#２The-NET-CLI-Tools-cannot-be-located-が出る

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(1, 0, 0);
    }
}
