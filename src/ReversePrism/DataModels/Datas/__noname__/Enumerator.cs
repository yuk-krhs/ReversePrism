using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Outer                                  0001866B1B90 ModelClassType Animation Animation Animation Pointer
    // 018 M_CurrentIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Enumerator : DataModel
    {
        public Animation?                               M_Outer                                 { get; set; }
        public int                                      M_CurrentIndex                          { get; set; }

        public static Enumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Enumerator() { Pointer= p0 };

            value.M_Outer                                   = GetObject<Animation>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animation.FromPointer); // 0245A68F4BB8 0x10 M_Outer                     ( 0001866B1B90 ModelClassType Animation Animation Animation Pointer )
            value.M_CurrentIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0245A68F4BD8 0x18 M_CurrentIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
