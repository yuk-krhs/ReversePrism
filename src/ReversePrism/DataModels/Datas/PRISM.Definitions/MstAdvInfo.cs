using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186672F10 ModelPrimitiveType string string string String
    // 018 UseIrregularSubTitle                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MstAdvInfo
    {
        public string                                   Id                                      { get; set; }
        public bool                                     UseIrregularSubTitle                    { get; set; }

        public static MstAdvInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstAdvInfo();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 02700466F788 0x10 Id                          ( 000186672F10 ModelPrimitiveType string string string String )
            value.UseIrregularSubTitle                      = GetBool(new IntPtr(p + 0x018)); // 02700466F7A8 0x18 UseIrregularSubTitle        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
