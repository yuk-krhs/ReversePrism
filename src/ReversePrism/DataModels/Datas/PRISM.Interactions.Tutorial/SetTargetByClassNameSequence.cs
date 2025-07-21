using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClassName                                ModelPrimitiveType string string string String
    // 018 IncludeInactive                          ModelPrimitiveType bool bool bool Bool
    // 01C Index                                    ModelPrimitiveType int int int Int32
    public partial class SetTargetByClassNameSequence : DataModel
    {
        public string                                   ClassName                               { get; set; }
        public bool                                     IncludeInactive                         { get; set; }
        public int                                      Index                                   { get; set; }

        public static SetTargetByClassNameSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTargetByClassNameSequence() { Pointer= p0 };

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ClassName                   ( ModelPrimitiveType string string string String )
            value.IncludeInactive                           = GetBool(new IntPtr(p + 0x018)); // 0x18 IncludeInactive             ( ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
