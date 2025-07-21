using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 <Value>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    // 020 Index                                    ModelPrimitiveType int int int Int32
    public partial class Binding : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Index                                   { get; set; }

        public static Binding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Binding() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
