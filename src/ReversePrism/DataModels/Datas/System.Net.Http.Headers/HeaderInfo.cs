using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllowsMany                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 HeaderKind                               0001866DF200 ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32
    // 018 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 020 <CustomToString>k__BackingField          Func`2<<object>, string> IL2CPP_TYPE_GENERICINST
    public partial class HeaderInfo : DataModel
    {
        public bool                                     AllowsMany                              { get; set; }
        public HttpHeaderKind                           HeaderKind                              { get; set; }
        public string                                   Name                                    { get; set; }

        public static HeaderInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderInfo() { Pointer= p0 };

            value.AllowsMany                                = GetBool(new IntPtr(p + 0x010)); // 02466B8E7750 0x10 AllowsMany                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HeaderKind                                = (HttpHeaderKind)GetInt32(new IntPtr(p + 0x014)); // 02466B8E7770 0x14 HeaderKind                  ( 0001866DF200 ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466B8E7790 0x18 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
