using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config
{
    public enum ERotType : byte
    {
        F,
        U,
        D,
        R,
        L,
        B,
        Rays,
        BU,
        LU,
        FLU, FL, FU, FD, FLD, FRD, RD, FRU, RU, FR, BLD, RB, BLU, LD, LB, BRU, BD, RBD,
    }
    public static Dictionary<ERotType, Vector3> Pos = new Dictionary<ERotType, Vector3>
        {
                { ERotType.F, new Vector3(-1,0,0) },
                { ERotType.U, new Vector3(0,1,0)},
                { ERotType.D, new Vector3(0,-1,0)},
                { ERotType.R, new Vector3(0,0,-1)},
                { ERotType.L, new Vector3(0,0,-90)},
                { ERotType.B, new Vector3(1,0,0)},
                { ERotType.BU, new Vector3(1,1,1)},
                { ERotType.LU, new Vector3(1,0,1)},
                { ERotType.FLU, new Vector3(1,1,1)},
                { ERotType.FL, new Vector3(1.192093F,1,1.02f)},
                { ERotType.FU, new Vector3(1,-1,2.3F)},
                { ERotType.FD, new Vector3(1.192093F,-1,1)},
                { ERotType.FLD, new Vector3(1.02F,-1,1)},
                { ERotType.FRD, new Vector3(1,1,-1)},
                { ERotType.RD, new Vector3(1,1.7484F,-1)},
                { ERotType.FRU, new Vector3(1,-1,-1)},
                { ERotType.RU, new Vector3(-1.748F,1,-1)},
                { ERotType.FR, new Vector3(-1.827F,-1,-1)},
                { ERotType.BLD, new Vector3(-1,1.02F,1)},
                { ERotType.RB, new Vector3(-1,1,-4.768F)},
                { ERotType.BLU, new Vector3(-1,1,-1.02F)},
                { ERotType.LD, new Vector3(-1.02F,0,1)},
                { ERotType.LB, new Vector3(-1,0,-1.02F)},
                { ERotType.BRU, new Vector3(-1,-1,1)},

                { ERotType.BD, new Vector3(-1,-1,3.57F)},
                { ERotType.RBD, new Vector3(-1,-1,-1)},
                //{ EType.F, new Vector3(-1,0,0)),
        };
    //public static Dictionary<ERotType, Vector3> Rot = new Dictionary<ERotType, Vector3>
    //    {
    //            { ERotType.F, new Vector3(270,0,0)},
    //            { ERotType.U, new Vector3(0,0,0)},
    //            { ERotType.D, new Vector3(0,90,0)},
    //            { ERotType.R, new Vector3(0,0,0)},
    //            { ERotType.L, new Vector3(0,0,270)},
    //            { ERotType.B, new Vector3(0,0,0)},
    //            { ERotType.BU, new Vector3(0,0,0)},
    //            { ERotType.LU, new Vector3(0,0,270)},
    //            { ERotType.FLU, new Vector3(0,0,270)},
    //            { ERotType.FL, new Vector3(0,0,270)},
    //            { ERotType.FU, new Vector3(0,180,90)},
    //            { ERotType.FD, new Vector3(0,90,0)},
    //            { ERotType.FLD, new Vector3(0,90,0)},
    //            { ERotType.FRD, new Vector3(0,270,270)},
    //            { ERotType.RD, new Vector3(0,270,270)},
    //            { ERotType.FRU, new Vector3(270,0,270)},
    //            { ERotType.RU, new Vector3(0,0,0)},
    //            { ERotType.FR, new Vector3(270,0,270)},
    //            { ERotType.BLD, new Vector3(270,270,0)},//{ ERotType.BLD, new Vector3(270,0,270)},
    //            { ERotType.RB, new Vector3(0,90,90)},
    //            { ERotType.BLU, new Vector3(0,180,0)},
    //            { ERotType.LD, new Vector3(0,270,90)},
    //            { ERotType.LB, new Vector3(0,180,0)},

    //            { ERotType.BRU, new Vector3(0,180,270)},
    //            { ERotType.BD, new Vector3(0,180,0)},
    //            { ERotType.RBD, new Vector3(0,90,0)},
    //    };
    public static Dictionary<ERotType, Vector3> Rot = new Dictionary<ERotType, Vector3>
        {
                { ERotType.F, new Vector3(1,0,0)},
                { ERotType.U, new Vector3(0,1,0)},
                { ERotType.D, new Vector3(0,1,0)},
                { ERotType.R, new Vector3(0,0,0)},
                { ERotType.L, new Vector3(0,0,1)},
                { ERotType.B, new Vector3(0,0,0)},
                { ERotType.BU, new Vector3(0,0,0)},
                { ERotType.LU, new Vector3(0,0,1)},
                { ERotType.FLU, new Vector3(0,0,1)},
                { ERotType.FL, new Vector3(0,0,1)},
                { ERotType.FU, new Vector3(0,.9f,.4f)},
                { ERotType.FD, new Vector3(0,1,0)},
                { ERotType.FLD, new Vector3(0,1,0)},
                { ERotType.FRD, new Vector3(0,.7f,.7f)},
                { ERotType.RD, new Vector3(0,.7f,.7f)},
                { ERotType.FRU, new Vector3(.7f,.7f,0)},
                { ERotType.RU, new Vector3(0,1,0)},
                { ERotType.FR, new Vector3(.7f,.7f,0)},
                { ERotType.BLD, new Vector3(.7f,.7f,0)},
                { ERotType.RB, new Vector3(0,.7f,.7f)},
                { ERotType.BLU, new Vector3(0,1,0)},
                { ERotType.LD, new Vector3(0,.9f,.3f)},
                { ERotType.LB, new Vector3(0,1,0)},

                { ERotType.BRU, new Vector3(0,.6f,.8f)},
                { ERotType.BD, new Vector3(0,1,0)},
                { ERotType.RBD, new Vector3(0,1,0)},
        };
}
