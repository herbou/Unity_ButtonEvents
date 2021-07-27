using UnityEngine ;
using EasyUI.Toast ;

public class Demo : MonoBehaviour {

   public void Print_Message (string message) {
      Debug.Log (message) ;
      Toast.Show (message, 1.5f) ;
   }

}
