using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Symbol                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 particle                                 <object> IL2CPP_TYPE_OBJECT
    public partial class Position : DataModel
    {
        public int                                      Symbol                                  { get; set; }

        public static Position? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Position() { Pointer= p0 };

            value.Symbol                                    = GetInt32(new IntPtr(p + 0x010)); // 02466755CE08 0x10 Symbol                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
