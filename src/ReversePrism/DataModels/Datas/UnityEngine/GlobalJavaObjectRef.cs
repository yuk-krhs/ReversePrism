using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 m_jobject                                <int> IL2CPP_TYPE_I
    public partial class GlobalJavaObjectRef
    {
        public bool                                     M_disposed                              { get; set; }

        public static GlobalJavaObjectRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalJavaObjectRef();

            value.M_disposed                                = GetBool(new IntPtr(p + 0x010)); // 027006944890 0x10 M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
