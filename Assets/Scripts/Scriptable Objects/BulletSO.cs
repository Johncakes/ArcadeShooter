using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "Player/Bullet") ]
public class BulletSO : ScriptableObject 
{
   public List <GameObject> Bullets = new List<GameObject>();

   public GameObject ReturnBullet(int lvl)
   {
       return Bullets[lvl];
   }
}
