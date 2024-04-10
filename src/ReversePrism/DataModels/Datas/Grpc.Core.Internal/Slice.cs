using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 dataPtr                                  <int> IL2CPP_TYPE_I
    // 018 Length                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Slice : DataModel
    {
        public int                                      Length                                  { get; set; }

        public static Slice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Slice() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 024662FBF4D0 0x18 Length                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
