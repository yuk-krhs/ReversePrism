using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 loneValue                                <object> IL2CPP_TYPE_OBJECT
    // 018 Position                                 ModelPrimitiveType int int int Int32
    public partial class SingleObjectEnumerator : DataModel
    {
        public int                                      Position                                { get; set; }

        public static SingleObjectEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleObjectEnumerator() { Pointer= p0 };

            value.Position                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
