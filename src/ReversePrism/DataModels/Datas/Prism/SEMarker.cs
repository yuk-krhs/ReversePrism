using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Id                                       000186648E00 ModelEnumType PropertyName PropertyName PropertyName Int32
    public partial class SEMarker : DataModel
    {
        public PropertyName                             Id                                      { get; set; }

        public static SEMarker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SEMarker() { Pointer= p0 };

            value.Id                                        = (PropertyName)GetInt32(new IntPtr(p + 0x028)); // 024664E73C20 0x28 Id                          ( 000186648E00 ModelEnumType PropertyName PropertyName PropertyName Int32 )

            return value;
        }
    }
}
