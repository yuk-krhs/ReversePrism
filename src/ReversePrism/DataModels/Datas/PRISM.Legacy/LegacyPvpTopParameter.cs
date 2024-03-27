using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    public partial class LegacyPvpTopParameter
    {
        public int                                      EventId                                 { get; set; }

        public static LegacyPvpTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyPvpTopParameter();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D5E3E3C8 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
