using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float HPplayer;
    public float MaxHPplayer = 10;
    public HealthbarPlayer hb;

    void Start()
    {
        HPplayer = MaxHPplayer;
        hb.SetHealth(HPplayer, MaxHPplayer);
    }

    // Update is called once per frame
    public void kehit(float damage)
    {
        HPplayer -= damage;
        hb.SetHealth(HPplayer, MaxHPplayer);

        if (HPplayer <= 0)
            Destroy(gameObject);
    }
}
