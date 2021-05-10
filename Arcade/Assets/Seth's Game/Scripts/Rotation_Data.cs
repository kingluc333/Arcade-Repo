using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Rotation_Data
{
    static Vector2[] main_vector_array = new Vector2[4];

    static Dictionary<Vector2, Vector2[]> rot_arrays = new Dictionary<Vector2, Vector2[]>();

    #region Red
    //Rotation 1
    static Vector2 r1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 r1_2 = new Vector2(0.2f, 0.6f);
    static Vector2 r1_3 = new Vector2(0.6f, 0.2f);
    static Vector2 r1_4 = new Vector2(-0.2f, 0.6f);
    static Vector2[] r1 = { r1_1, r1_2, r1_3, r1_4 };
    //Rotation 2
    static Vector2 r2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 r2_2 = new Vector2(0.6f, 0.2f);
    static Vector2 r2_3 = new Vector2(0.2f, -0.2f);
    static Vector2 r2_4 = new Vector2(0.6f, 0.6f);
    static Vector2[] r2 = { r2_1, r2_2, r2_3, r2_4 };
    //Rotation 3
    static Vector2 r3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 r3_2 = new Vector2(0.2f, -0.2f);
    static Vector2 r3_3 = new Vector2(-0.2f, 0.2f);
    static Vector2 r3_4 = new Vector2(0.6f, -0.2f);
    static Vector2[] r3 = { r3_1, r3_2, r3_3, r3_4 };
    //Rotation 4
    static Vector2 r4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 r4_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 r4_3 = new Vector2(0.2f, 0.6f);
    static Vector2 r4_4 = new Vector2(-0.2f, -0.2f);
    static Vector2[] r4 = { r4_1, r4_2, r4_3, r4_4 };
    #endregion
    #region Green
    #endregion
    #region Blue
    #endregion
    #region Orange
    #endregion
    #region Purple
    #endregion
    #region Yellow
    #endregion
    #region Cyan
    #endregion

    public static Vector2[] GiveRotationData (int block_id, int rotation)
    {
        main_vector_array = rot_arrays[new Vector2(block_id, rotation)];
        return main_vector_array;
    }

    //Adding all data to dictionary
    public static void PopulateDictionary ()
    {
        //Red
        rot_arrays.Add(new Vector2(1, 1), r1);
        rot_arrays.Add(new Vector2(1, 2), r2);
        rot_arrays.Add(new Vector2(1, 3), r3);
        rot_arrays.Add(new Vector2(1, 4), r4);
        //Green
        //Blue
        //Orange
        //Purple
        //Yellow
        //Cyan
    }
}
