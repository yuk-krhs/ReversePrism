using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeId                                   000186671910 ModelPrimitiveType string string string String
    // 018 Reloadable                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 SerializerTypeName                       000186672F10 ModelPrimitiveType string string string String
    // 028 SerializerBaseTypeName                   000186672F10 ModelPrimitiveType string string string String
    public partial class RootDesignerSerializerAttribute
    {
        public string                                   TypeId                                  { get; set; }
        public bool                                     Reloadable                              { get; set; }
        public string                                   SerializerTypeName                      { get; set; }
        public string                                   SerializerBaseTypeName                  { get; set; }

        public static RootDesignerSerializerAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RootDesignerSerializerAttribute();

            value.TypeId                                    = GetString(new IntPtr(p + 0x010)); // 0270D7B3F3C0 0x10 TypeId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Reloadable                                = GetBool(new IntPtr(p + 0x018)); // 0270D7B3F3E0 0x18 Reloadable                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.SerializerTypeName                        = GetString(new IntPtr(p + 0x020)); // 0270D7B3F400 0x20 SerializerTypeName          ( 000186672F10 ModelPrimitiveType string string string String )
            value.SerializerBaseTypeName                    = GetString(new IntPtr(p + 0x028)); // 0270D7B3F420 0x28 SerializerBaseTypeName      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
