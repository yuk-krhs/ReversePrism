using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_Path                                   ModelClassType CinemachinePathBase CinemachinePathBase CinemachinePathBase Pointer
    // 030 M_PathPosition                           ModelPrimitiveType float float float Single
    // 034 M_PositionUnits                          ModelEnumType PositionUnits PositionUnits PositionUnits Int32
    // 038 M_PathOffset                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 M_XDamping                               ModelPrimitiveType float float float Single
    // 048 M_YDamping                               ModelPrimitiveType float float float Single
    // 04C M_ZDamping                               ModelPrimitiveType float float float Single
    // 050 M_CameraUp                               ModelEnumType CameraUpMode CameraUpMode CameraUpMode Int32
    // 054 M_PitchDamping                           ModelPrimitiveType float float float Single
    // 058 M_YawDamping                             ModelPrimitiveType float float float Single
    // 05C M_RollDamping                            ModelPrimitiveType float float float Single
    // 060 M_AutoDolly                              ModelEnumType AutoDolly AutoDolly AutoDolly Int32
    // 070 M_PreviousPathPosition                   ModelPrimitiveType float float float Single
    // 074 M_PreviousOrientation                    ModelEnumType Quaternion Quaternion Quaternion Int32
    // 084 M_PreviousCameraPosition                 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CinemachineTrackedDolly : DataModel
    {
        public CinemachinePathBase?                     M_Path                                  { get; set; }
        public float                                    M_PathPosition                          { get; set; }
        public PositionUnits                            M_PositionUnits                         { get; set; }
        public Vector3                                  M_PathOffset                            { get; set; }
        public float                                    M_XDamping                              { get; set; }
        public float                                    M_YDamping                              { get; set; }
        public float                                    M_ZDamping                              { get; set; }
        public CameraUpMode                             M_CameraUp                              { get; set; }
        public float                                    M_PitchDamping                          { get; set; }
        public float                                    M_YawDamping                            { get; set; }
        public float                                    M_RollDamping                           { get; set; }
        public AutoDolly                                M_AutoDolly                             { get; set; }
        public float                                    M_PreviousPathPosition                  { get; set; }
        public Quaternion                               M_PreviousOrientation                   { get; set; }
        public Vector3                                  M_PreviousCameraPosition                { get; set; }

        public static CinemachineTrackedDolly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineTrackedDolly() { Pointer= p0 };

            value.M_Path                                    = GetObject<CinemachinePathBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.CinemachinePathBase.FromPointer); // 0x28 M_Path                      ( ModelClassType CinemachinePathBase CinemachinePathBase CinemachinePathBase Pointer )
            value.M_PathPosition                            = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_PathPosition              ( ModelPrimitiveType float float float Single )
            value.M_PositionUnits                           = (PositionUnits)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_PositionUnits             ( ModelEnumType PositionUnits PositionUnits PositionUnits Int32 )
            value.M_PathOffset                              = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_PathOffset                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_XDamping                                = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_XDamping                  ( ModelPrimitiveType float float float Single )
            value.M_YDamping                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_YDamping                  ( ModelPrimitiveType float float float Single )
            value.M_ZDamping                                = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_ZDamping                  ( ModelPrimitiveType float float float Single )
            value.M_CameraUp                                = (CameraUpMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_CameraUp                  ( ModelEnumType CameraUpMode CameraUpMode CameraUpMode Int32 )
            value.M_PitchDamping                            = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_PitchDamping              ( ModelPrimitiveType float float float Single )
            value.M_YawDamping                              = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_YawDamping                ( ModelPrimitiveType float float float Single )
            value.M_RollDamping                             = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_RollDamping               ( ModelPrimitiveType float float float Single )
            value.M_AutoDolly                               = (AutoDolly)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_AutoDolly                 ( ModelEnumType AutoDolly AutoDolly AutoDolly Int32 )
            value.M_PreviousPathPosition                    = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_PreviousPathPosition      ( ModelPrimitiveType float float float Single )
            value.M_PreviousOrientation                     = (Quaternion)GetInt32(new IntPtr(p + 0x074)); // 0x74 M_PreviousOrientation       ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_PreviousCameraPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_PreviousCameraPosition    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
