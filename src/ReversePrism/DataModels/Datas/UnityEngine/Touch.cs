using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FingerId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Position                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C M_RawPosition                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 M_PositionDelta                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C M_TimeDelta                              0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_TapCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 M_Phase                                  0001866902E0 ModelEnumType TouchPhase TouchPhase TouchPhase Int32
    // 038 M_Type                                   000186694970 ModelEnumType TouchType TouchType TouchType Int32
    // 03C M_Pressure                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_maximumPossiblePressure                0001866656B0 ModelPrimitiveType float float float Single
    // 044 M_Radius                                 0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_RadiusVariance                         0001866656B0 ModelPrimitiveType float float float Single
    // 04C M_AltitudeAngle                          0001866656B0 ModelPrimitiveType float float float Single
    // 050 M_AzimuthAngle                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class Touch
    {
        public int                                      M_FingerId                              { get; set; }
        public Vector2                                  M_Position                              { get; set; }
        public Vector2                                  M_RawPosition                           { get; set; }
        public Vector2                                  M_PositionDelta                         { get; set; }
        public float                                    M_TimeDelta                             { get; set; }
        public int                                      M_TapCount                              { get; set; }
        public TouchPhase                               M_Phase                                 { get; set; }
        public TouchType                                M_Type                                  { get; set; }
        public float                                    M_Pressure                              { get; set; }
        public float                                    M_maximumPossiblePressure               { get; set; }
        public float                                    M_Radius                                { get; set; }
        public float                                    M_RadiusVariance                        { get; set; }
        public float                                    M_AltitudeAngle                         { get; set; }
        public float                                    M_AzimuthAngle                          { get; set; }

        public static Touch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Touch();

            value.M_FingerId                                = GetInt32(new IntPtr(p + 0x010)); // 027006973B20 0x10 M_FingerId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Position                                = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 027006973B40 0x14 M_Position                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_RawPosition                             = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 027006973B60 0x1C M_RawPosition               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PositionDelta                           = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 027006973B80 0x24 M_PositionDelta             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_TimeDelta                               = GetSingle(new IntPtr(p + 0x02C)); // 027006973BA0 0x2C M_TimeDelta                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TapCount                                = GetInt32(new IntPtr(p + 0x030)); // 027006973BC0 0x30 M_TapCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Phase                                   = (TouchPhase)GetInt32(new IntPtr(p + 0x034)); // 027006973BE0 0x34 M_Phase                     ( 0001866902E0 ModelEnumType TouchPhase TouchPhase TouchPhase Int32 )
            value.M_Type                                    = (TouchType)GetInt32(new IntPtr(p + 0x038)); // 027006973C00 0x38 M_Type                      ( 000186694970 ModelEnumType TouchType TouchType TouchType Int32 )
            value.M_Pressure                                = GetSingle(new IntPtr(p + 0x03C)); // 027006973C20 0x3C M_Pressure                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_maximumPossiblePressure                 = GetSingle(new IntPtr(p + 0x040)); // 027006973C40 0x40 M_maximumPossiblePressure   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Radius                                  = GetSingle(new IntPtr(p + 0x044)); // 027006973C60 0x44 M_Radius                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_RadiusVariance                          = GetSingle(new IntPtr(p + 0x048)); // 027006973C80 0x48 M_RadiusVariance            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AltitudeAngle                           = GetSingle(new IntPtr(p + 0x04C)); // 027006973CA0 0x4C M_AltitudeAngle             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AzimuthAngle                            = GetSingle(new IntPtr(p + 0x050)); // 027006973CC0 0x50 M_AzimuthAngle              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
