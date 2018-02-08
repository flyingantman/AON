using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour {

    public int rotationSpeed;
    public int player;
    string[] inputs = { "Horizontal2", "Vertical2" };

    void Start()
    {
        if (player == 2)
        {
            for (int i = 0; i < 2; i++)
                inputs[i] = inputs[i] + "-" + player.ToString();
        }
    }
    // Update is called once per frame
    void Update () {
        Shooting();
	}

    void Shooting()
    {
        Vector2 shotDirection = new Vector2(Input.GetAxis(inputs[0]), Input.GetAxis(inputs[1])).normalized;
        float shotAngle = Mathf.Atan2(shotDirection.y, shotDirection.x) * Mathf.Rad2Deg+90;

        if (shotDirection.sqrMagnitude > .3f)
        {
            Vector3 newAngle = Vector2.zero;
            float step = rotationSpeed * Time.deltaTime;
            newAngle.z = Mathf.LerpAngle(transform.eulerAngles.z, shotAngle, step);
            transform.eulerAngles = newAngle;
        }
    }
}
