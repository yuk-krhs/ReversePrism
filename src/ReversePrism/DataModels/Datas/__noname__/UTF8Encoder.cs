using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SurrogateChar                            ModelPrimitiveType int int int Int32
    public partial class UTF8Encoder : DataModel
    {
        public int                                      SurrogateChar                           { get; set; }

        public static UTF8Encoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF8Encoder() { Pointer= p0 };

            value.SurrogateChar                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 SurrogateChar               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
