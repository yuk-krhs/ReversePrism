using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FieldInfo                              000186573AB0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class FieldMember : DataModel
    {
        public FieldInfo?                               M_FieldInfo                             { get; set; }

        public static FieldMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldMember() { Pointer= p0 };

            value.M_FieldInfo                               = GetObject<FieldInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.FieldInfo.FromPointer); // 0245A68FED00 0x10 M_FieldInfo                 ( 000186573AB0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}
