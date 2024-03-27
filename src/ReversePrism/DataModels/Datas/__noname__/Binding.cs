using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 <Value>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    // 020 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Binding
    {
        public string                                   Name                                    { get; set; }
        public int                                      Index                                   { get; set; }

        public static Binding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Binding();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027003D47D20 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 027003D47D60 0x20 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
