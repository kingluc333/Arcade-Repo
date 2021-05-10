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
    static Vector2 g1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 g1_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 g1_3 = new Vector2(0.2f, 0.6f);
    static Vector2 g1_4 = new Vector2(0.6f, 0.6f);
    static Vector2[] g1 = { g1_1, g1_2, g1_3, g1_4 };
    //Rotation 2
    static Vector2 g2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 g2_2 = new Vector2(0.2f, 0.6f);
    static Vector2 g2_3 = new Vector2(0.6f, 0.2f);
    static Vector2 g2_4 = new Vector2(0.6f, -0.2f);
    static Vector2[] g2 = { g2_1, g2_2, g2_3, g2_4 };
    //Rotation 3
    static Vector2 g3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 g3_2 = new Vector2(0.6f, 0.2f);
    static Vector2 g3_3 = new Vector2(0.2f, -0.2f);
    static Vector2 g3_4 = new Vector2(-0.2f, -0.2f);
    static Vector2[] g3 = { g3_1, g3_2, g3_3, g3_4 };
    //Rotation 4
    static Vector2 g4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 g4_2 = new Vector2(0.2f, -0.2f);
    static Vector2 g4_3 = new Vector2(-0.2f, 0.2f);
    static Vector2 g4_4 = new Vector2(-0.2f, 0.6f);
    static Vector2[] g4 = { g4_1, g4_2, g4_3, g4_4 };
    #endregion
    #region Blue
    static Vector2 b1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 b1_2 = new Vector2(0.2f, -0.2f);
    static Vector2 b1_3 = new Vector2(0.2f, 0.6f);
    static Vector2 b1_4 = new Vector2(0.6f, 0.6f);
    static Vector2[] b1 = { b1_1, b1_2, b1_3, b1_4 };
    //Rotation 2
    static Vector2 b2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 b2_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 b2_3 = new Vector2(0.6f, 0.2f);
    static Vector2 b2_4 = new Vector2(0.6f, -0.2f);
    static Vector2[] b2 = { b2_1, b2_2, b2_3, b2_4 };
    //Rotation 3
    static Vector2 b3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 b3_2 = new Vector2(0.2f, 0.6f);
    static Vector2 b3_3 = new Vector2(0.2f, -0.2f);
    static Vector2 b3_4 = new Vector2(-0.2f, -0.2f);
    static Vector2[] b3 = { b3_1, b3_2, b3_3, b3_4 };
    //Rotation 4
    static Vector2 b4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 b4_2 = new Vector2(0.6f, 0.2f);
    static Vector2 b4_3 = new Vector2(-0.2f, 0.2f);
    static Vector2 b4_4 = new Vector2(-0.2f, 0.6f);
    static Vector2[] b4 = { b4_1, b4_2, b4_3, b4_4 };
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
        rot_arrays.Add(new Vector2(2, 1), g1);
        rot_arrays.Add(new Vector2(2, 2), g2);
        rot_arrays.Add(new Vector2(2, 3), g3);
        rot_arrays.Add(new Vector2(2, 4), g4);
        //Blue
        rot_arrays.Add(new Vector2(3, 1), b1);
        rot_arrays.Add(new Vector2(3, 2), b2);
        rot_arrays.Add(new Vector2(3, 3), b3);
        rot_arrays.Add(new Vector2(3, 4), b4);
        //Orange
        //Purple
        //Yellow
        //Cyan
    }
}
