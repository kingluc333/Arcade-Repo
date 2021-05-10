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
    static Vector2 o1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 o1_2 = new Vector2(0.2f, -0.2f);
    static Vector2 o1_3 = new Vector2(0.2f, 0.6f);
    static Vector2 o1_4 = new Vector2(-0.2f, 0.6f);
    static Vector2[] o1 = { o1_1, o1_2, o1_3, o1_4 };
    //Rotation 2
    static Vector2 o2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 o2_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 o2_3 = new Vector2(0.6f, 0.2f);
    static Vector2 o2_4 = new Vector2(0.6f, 0.6f);
    static Vector2[] o2 = { o2_1, o2_2, o2_3, o2_4 };
    //Rotation 3
    static Vector2 o3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 o3_2 = new Vector2(0.2f, 0.6f);
    static Vector2 o3_3 = new Vector2(0.2f, -0.2f);
    static Vector2 o3_4 = new Vector2(0.6f, -0.2f);
    static Vector2[] o3 = { o3_1, o3_2, o3_3, o3_4 };
    //Rotation 4
    static Vector2 o4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 o4_2 = new Vector2(0.6f, 0.2f);
    static Vector2 o4_3 = new Vector2(-0.2f, 0.2f);
    static Vector2 o4_4 = new Vector2(-0.2f, -0.2f);
    static Vector2[] o4 = { o4_1, o4_2, o4_3, o4_4 };
    #endregion
    #region Purple
    static Vector2 p1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 p1_2 = new Vector2(0.6f, 0.2f);
    static Vector2 p1_3 = new Vector2(0.2f, 0.6f);
    static Vector2 p1_4 = new Vector2(-0.2f, 0.2f);
    static Vector2[] p1 = { p1_1, p1_2, p1_3, p1_4 };
    //Rotation 2
    static Vector2 p2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 p2_2 = new Vector2(0.2f, -0.2f);
    static Vector2 p2_3 = new Vector2(0.6f, 0.2f);
    static Vector2 p2_4 = new Vector2(0.2f, 0.6f);
    static Vector2[] p2 = { p2_1, p2_2, p2_3, p2_4 };
    //Rotation 3
    static Vector2 p3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 p3_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 p3_3 = new Vector2(0.2f, -0.2f);
    static Vector2 p3_4 = new Vector2(0.6f, 0.2f);
    static Vector2[] p3 = { p3_1, p3_2, p3_3, p3_4 };
    //Rotation 4
    static Vector2 p4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 p4_2 = new Vector2(0.2f, 0.6f);
    static Vector2 p4_3 = new Vector2(-0.2f, 0.2f);
    static Vector2 p4_4 = new Vector2(0.2f, -0.2f);
    static Vector2[] p4 = { p4_1, p4_2, p4_3, p4_4 };
    #endregion
    #region Yellow
    static Vector2 y1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 y1_2 = new Vector2(0.6f, 0.2f);
    static Vector2 y1_3 = new Vector2(0.6f, 0.6f);
    static Vector2 y1_4 = new Vector2(0.2f, 0.6f);
    static Vector2[] y1 = { y1_1, y1_2, y1_3, y1_4 };
    //Rotation 2
    static Vector2 y2_1 = new Vector2(0.2f, 0.2f);
    static Vector2 y2_2 = new Vector2(0.6f, 0.2f);
    static Vector2 y2_3 = new Vector2(0.6f, 0.6f);
    static Vector2 y2_4 = new Vector2(0.2f, 0.6f);
    static Vector2[] y2 = { y2_1, y2_2, y2_3, y2_4 };
    //Rotation 3
    static Vector2 y3_1 = new Vector2(0.2f, 0.2f);
    static Vector2 y3_2 = new Vector2(0.6f, 0.2f);
    static Vector2 y3_3 = new Vector2(0.6f, 0.6f);
    static Vector2 y3_4 = new Vector2(0.2f, 0.6f);
    static Vector2[] y3 = { y3_1, y3_2, y3_3, y3_4 };
    //Rotation 4
    static Vector2 y4_1 = new Vector2(0.2f, 0.2f);
    static Vector2 y4_2 = new Vector2(0.6f, 0.2f);
    static Vector2 y4_3 = new Vector2(0.6f, 0.6f);
    static Vector2 y4_4 = new Vector2(0.2f, 0.6f);
    static Vector2[] y4 = { y4_1, y4_2, y4_3, y4_4 };
    #endregion
    #region Cyan
    static Vector2 c1_1 = new Vector2(0.2f, 0.2f);
    static Vector2 c1_2 = new Vector2(-0.2f, 0.2f);
    static Vector2 c1_3 = new Vector2(0.6f, 0.2f);
    static Vector2 c1_4 = new Vector2(1f, 0.2f);
    static Vector2[] c1 = { c1_1, c1_2, c1_3, c1_4 };
    //Rotation 2
    static Vector2 c2_1 = new Vector2(0.2f, 0.6f);
    static Vector2 c2_2 = new Vector2(0.2f, 1f);
    static Vector2 c2_3 = new Vector2(0.2f, 0.2f);
    static Vector2 c2_4 = new Vector2(0.2f, -0.2f);
    static Vector2[] c2 = { c2_1, c2_2, c2_3, c2_4 };
    //Rotation 3
    static Vector2 c3_1 = new Vector2(0.6f, 0.6f);
    static Vector2 c3_2 = new Vector2(1f, 0.6f);
    static Vector2 c3_3 = new Vector2(0.2f, 0.6f);
    static Vector2 c3_4 = new Vector2(-0.2f, 0.6f);
    static Vector2[] c3 = { c3_1, c3_2, c3_3, c3_4 };
    //Rotation 4
    static Vector2 c4_1 = new Vector2(0.6f, 0.2f);
    static Vector2 c4_2 = new Vector2(0.6f, -0.2f);
    static Vector2 c4_3 = new Vector2(0.6f, 0.6f);
    static Vector2 c4_4 = new Vector2(0.6f, 1f);
    static Vector2[] c4 = { c4_1, c4_2, c4_3, c4_4 };
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
        rot_arrays.Add(new Vector2(4, 1), o1);
        rot_arrays.Add(new Vector2(4, 2), o2);
        rot_arrays.Add(new Vector2(4, 3), o3);
        rot_arrays.Add(new Vector2(4, 4), o4);
        //Purple
        rot_arrays.Add(new Vector2(5, 1), p1);
        rot_arrays.Add(new Vector2(5, 2), p2);
        rot_arrays.Add(new Vector2(5, 3), p3);
        rot_arrays.Add(new Vector2(5, 4), p4);
        //Yellow
        rot_arrays.Add(new Vector2(6, 1), y1);
        rot_arrays.Add(new Vector2(6, 2), y2);
        rot_arrays.Add(new Vector2(6, 3), y3);
        rot_arrays.Add(new Vector2(6, 4), y4);
        //Cyan
        rot_arrays.Add(new Vector2(7, 1), c1);
        rot_arrays.Add(new Vector2(7, 2), c2);
        rot_arrays.Add(new Vector2(7, 3), c3);
        rot_arrays.Add(new Vector2(7, 4), c4);
    }
}
