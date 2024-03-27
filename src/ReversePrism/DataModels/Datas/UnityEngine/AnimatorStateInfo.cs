using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Path                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_FullPath                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_NormalizedTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Length                                 0001866656B0 ModelPrimitiveType float float float Single
    // 024 M_Speed                                  0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_SpeedMultiplier                        0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_Tag                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_Loop                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AnimatorStateInfo
    {
        public int                                      M_Name                                  { get; set; }
        public int                                      M_Path                                  { get; set; }
        public int                                      M_FullPath                              { get; set; }
        public float                                    M_NormalizedTime                        { get; set; }
        public float                                    M_Length                                { get; set; }
        public float                                    M_Speed                                 { get; set; }
        public float                                    M_SpeedMultiplier                       { get; set; }
        public int                                      M_Tag                                   { get; set; }
        public int                                      M_Loop                                  { get; set; }

        public static AnimatorStateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorStateInfo();

            value.M_Name                                    = GetInt32(new IntPtr(p + 0x010)); // 0270022253A8 0x10 M_Name                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Path                                    = GetInt32(new IntPtr(p + 0x014)); // 0270022253C8 0x14 M_Path                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FullPath                                = GetInt32(new IntPtr(p + 0x018)); // 0270022253E8 0x18 M_FullPath                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NormalizedTime                          = GetSingle(new IntPtr(p + 0x01C)); // 027002225408 0x1C M_NormalizedTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Length                                  = GetSingle(new IntPtr(p + 0x020)); // 027002225428 0x20 M_Length                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Speed                                   = GetSingle(new IntPtr(p + 0x024)); // 027002225448 0x24 M_Speed                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SpeedMultiplier                         = GetSingle(new IntPtr(p + 0x028)); // 027002225468 0x28 M_SpeedMultiplier           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Tag                                     = GetInt32(new IntPtr(p + 0x02C)); // 027002225488 0x2C M_Tag                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Loop                                    = GetInt32(new IntPtr(p + 0x030)); // 0270022254A8 0x30 M_Loop                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
