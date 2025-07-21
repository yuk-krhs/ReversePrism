using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _object                                  <object> IL2CPP_TYPE_OBJECT
    // 018 Integer                                  ModelPrimitiveType int int int Int32
    public partial class SequencePosition : DataModel
    {
        public int                                      Integer                                 { get; set; }

        public static SequencePosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SequencePosition() { Pointer= p0 };

            value.Integer                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Integer                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
