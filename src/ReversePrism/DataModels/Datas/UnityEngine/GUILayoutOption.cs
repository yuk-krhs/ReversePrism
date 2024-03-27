using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866E0E10 ModelEnumType Type Type Type Int32
    // 018 value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class GUILayoutOption
    {
        public Type                                     Type                                    { get; set; }

        public static GUILayoutOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUILayoutOption();

            value.Type                                      = (Type)GetInt32(new IntPtr(p + 0x010)); // 027006927478 0x10 Type                        ( 0001866E0E10 ModelEnumType Type Type Type Int32 )

            return value;
        }
    }
}
