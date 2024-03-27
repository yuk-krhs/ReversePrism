using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  0001866F7F90 ModelClassType Builder Builder Builder Pointer
    // 018 Index                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ControlBuilder
    {
        public Builder?                                 Builder                                 { get; set; }
        public int                                      Index                                   { get; set; }

        public static ControlBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlBuilder();

            value.Builder                                   = GetObject<Builder>(new IntPtr(p + 0x010), ReversePrism.DataModels.Builder.FromPointer); // 0270D783E948 0x10 Builder                     ( 0001866F7F90 ModelClassType Builder Builder Builder Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D783E968 0x18 Index                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
