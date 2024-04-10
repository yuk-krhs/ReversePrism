using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetBufferArgs : DataModel
    {
        public int                                      Count                                   { get; set; }

        public static GetBufferArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetBufferArgs() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 024667D0A330 0x10 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
