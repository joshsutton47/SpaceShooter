/**** 
 * Created by: Josh Sutton
 * Date Created: April 11, 2022
 * 
 * Last Edited by: N/A
 * Last Edited: April 14, 2022
 * 
 * Description: Returns objects to the pool
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    /*** VARIABLES ***/
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; //find the game manager
    }

    private void OnDisable()
    {
        //if the pool is not empty
        if (pool != null)
        {
            pool.ReturnObject(this.gameObject); //return to pool
        }//end if ( pool != null)
    }//end OnDisable()
}
