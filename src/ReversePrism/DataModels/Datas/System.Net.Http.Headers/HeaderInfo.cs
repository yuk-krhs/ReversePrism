using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllowsMany                               ModelPrimitiveType bool bool bool Bool
    // 014 HeaderKind                               ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32
    // 018 Name                                     ModelPrimitiveType string string string String
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

            value.AllowsMany                                = GetBool(new IntPtr(p + 0x010)); // 0x10 AllowsMany                  ( ModelPrimitiveType bool bool bool Bool )
            value.HeaderKind                                = (HttpHeaderKind)GetInt32(new IntPtr(p + 0x014)); // 0x14 HeaderKind                  ( ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
