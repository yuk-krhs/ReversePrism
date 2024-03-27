using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 014 StackDepth                               0001865F4940 ModelPrimitiveType int int int Int32
    // 018 ContinuationStackDepth                   0001865F4940 ModelPrimitiveType int int int Int32
    public partial class RuntimeLabel
    {
        public int                                      Index                                   { get; set; }
        public int                                      StackDepth                              { get; set; }
        public int                                      ContinuationStackDepth                  { get; set; }

        public static RuntimeLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeLabel();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D9F873B0 0x10 Index                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.StackDepth                                = GetInt32(new IntPtr(p + 0x014)); // 0270D9F873D0 0x14 StackDepth                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ContinuationStackDepth                    = GetInt32(new IntPtr(p + 0x018)); // 0270D9F873F0 0x18 ContinuationStackDepth      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
