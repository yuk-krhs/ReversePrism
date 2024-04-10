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
    public partial class HandIKData : DataModel
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
            var value   = new HandIKData() { Pointer= p0 };

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0245A7093330 0x10 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LeftTarget                                = GetInt32(new IntPtr(p + 0x014)); // 0245A7093350 0x14 LeftTarget                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightTarget                               = GetInt32(new IntPtr(p + 0x018)); // 0245A7093370 0x18 RightTarget                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HandLerpFrame                             = GetInt32(new IntPtr(p + 0x01C)); // 0245A7093390 0x1C HandLerpFrame               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
