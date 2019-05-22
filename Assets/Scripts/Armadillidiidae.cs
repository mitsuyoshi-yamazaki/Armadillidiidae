using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Memo
// https://qiita.com/4_mio_11/items/e7b0a5e65c89ac9d6d7f#こんな時はどうすれば
// https://www.crossroad-tech.com/entry/Unity_VisualStudioCode4#２The-NET-CLI-Tools-cannot-be-located-が出る

public class Armadillidiidae : MonoBehaviour
{
    public float speed = 0.01f;
    public Vector3 direction = new Vector3();

    public float fatigure = 0.0f;
    public float fatigureDecreasement = 0.0008f;
    // public float drowsiness = 0.0f;

    private RandomWalk randomWalk = new RandomWalk();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RandomWalk.Output output = this.randomWalk.Run();
        this.Move(output.direction, output.speed);

        this.fatigure -= this.fatigureDecreasement;
        this.fatigure = Mathf.Max(this.fatigure, 0f);

        this.Animate();
    }

    private void Move(Vector3 direction, float speed)
    {
        float actualSpeed = speed;  // FixMe:

        this.transform.position += actualSpeed * direction;

        this.fatigure += Mathf.Pow(actualSpeed, 2f);
    }

    private void Animate()
    {
        float angle = 120.0f;
        Vector3 axis = new Vector3(0, 0, 1);

        this.transform.RotateAround(this.transform.position, axis, angle * Time.deltaTime);
    }
}

class RandomWalk
{
    private float distance = 0.0f;
    private float speed = 0.03f;
    private Vector3 direction = new Vector3();

    public struct Output
    {
        public float speed;
        public Vector3 direction;

        public Output(float speed, Vector3 direction)
        {
            this.speed = speed;
            this.direction = direction;
        }
    }

    public Output Run()
    {
        if (this.distance <= 0.0f)
        {
            if (this.direction.x == 0)
            {
                switch ((int)Random.Range(0, 2))
                {
                    case 0:
                        this.direction = new Vector3(1, 0, 0);
                        break;
                    default:
                        this.direction = new Vector3(-1, 0, 0);
                        break;
                }
            }
            else
            {
                switch ((int)Random.Range(0, 2))
                {
                    case 0:
                        this.direction = new Vector3(0, 0, 1);
                        break;
                    default:
                        this.direction = new Vector3(0, 0, -1);
                        break;
                }
            }

            this.distance = Random.Range(1, 5) + Random.Range(1, 5);
        }

        this.distance -= speed;

        return new Output(this.speed, this.direction);
    }
}