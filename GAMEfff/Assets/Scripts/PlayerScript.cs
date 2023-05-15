using UnityEngine;

public class PlayerScript : MonoCache
{
      public float zxc = 0.011f;
      private bool _moveRight, _moveLeft;

    public void MoveR(bool moveRight) => _moveRight = moveRight;  
    

    public void MoveL(bool moveLeft) => _moveLeft = moveLeft;
    
    
public override void OnTick (){
      
      if(zxc<0.1f){
            zxc=zxc+0.00001f;
      }
      else
            zxc = zxc - 0.0001f;
      
      Vector3 position = transform.position;
      if(position.x >= -4.67f)
            {
                  if(_moveLeft) transform.Translate(x:-zxc, y:0, z:0); 
            }
            
      if(position.x <= 3.659f)
            {
                  if(_moveRight) transform.Translate(x:zxc, y:0, z:0);            
            }
}           
}

