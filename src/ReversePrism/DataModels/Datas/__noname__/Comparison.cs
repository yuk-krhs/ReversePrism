using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Terminates                               ModelPrimitiveType bool bool bool Bool
    // 014 Result                                   ModelPrimitiveType int int int Int32
    public partial class Comparison : DataModel
    {
        public bool                                     Terminates                              { get; set; }
        public int                                      Result                                  { get; set; }

        public static Comparison? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Comparison() { Pointer= p0 };

            value.Terminates                                = GetBool(new IntPtr(p + 0x010)); // 0x10 Terminates                  ( ModelPrimitiveType bool bool bool Bool )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Result                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
