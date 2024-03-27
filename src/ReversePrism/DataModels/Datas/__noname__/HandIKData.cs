using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 LeftTarget                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 RightTarget                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C HandLerpFrame                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class HandIKData
    {
        public int                                      StartFrame                              { get; set; }
        public int                                      LeftTarget                              { get; set; }
        public int                                      RightTarget                             { get; set; }
        public int                                      HandLerpFrame                           { get; set; }

        public static HandIKData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HandIKData();

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0270D4D860F0 0x10 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LeftTarget                                = GetInt32(new IntPtr(p + 0x014)); // 0270D4D86110 0x14 LeftTarget                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightTarget                               = GetInt32(new IntPtr(p + 0x018)); // 0270D4D86130 0x18 RightTarget                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HandLerpFrame                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D4D86150 0x1C HandLerpFrame               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
