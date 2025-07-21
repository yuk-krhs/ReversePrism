using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  ModelClassType Builder Builder Builder Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    public partial class ControlBuilder : DataModel
    {
        public Builder?                                 Builder                                 { get; set; }
        public int                                      Index                                   { get; set; }

        public static ControlBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlBuilder() { Pointer= p0 };

            value.Builder                                   = GetObject<Builder>(new IntPtr(p + 0x010), ReversePrism.DataModels.Builder.FromPointer); // 0x10 Builder                     ( ModelClassType Builder Builder Builder Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
