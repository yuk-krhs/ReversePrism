using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_version                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_list                                   00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 M_TimeStamp                              0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 M_has_other_versions                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_IsReadOnly                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CookieCollection
    {
        public int                                      M_version                               { get; set; }
        public ArrayList?                               M_list                                  { get; set; }
        public DateTime                                 M_TimeStamp                             { get; set; }
        public bool                                     M_has_other_versions                    { get; set; }
        public bool                                     M_IsReadOnly                            { get; set; }

        public static CookieCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CookieCollection();

            value.M_version                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D7A36DE0 0x10 M_version                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_list                                    = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D7A36E00 0x18 M_list                      ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.M_TimeStamp                               = GetDateTime(new IntPtr(p + 0x020)); // 0270D7A36E20 0x20 M_TimeStamp                 ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_has_other_versions                      = GetBool(new IntPtr(p + 0x028)); // 0270D7A36E40 0x28 M_has_other_versions        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsReadOnly                              = GetBool(new IntPtr(p + 0x029)); // 0270D7A36E60 0x29 M_IsReadOnly                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
