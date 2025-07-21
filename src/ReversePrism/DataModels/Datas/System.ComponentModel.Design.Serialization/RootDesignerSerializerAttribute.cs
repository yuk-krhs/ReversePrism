using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeId                                   ModelPrimitiveType string string string String
    // 018 Reloadable                               ModelPrimitiveType bool bool bool Bool
    // 020 SerializerTypeName                       ModelPrimitiveType string string string String
    // 028 SerializerBaseTypeName                   ModelPrimitiveType string string string String
    public partial class RootDesignerSerializerAttribute : DataModel
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
            var value   = new RootDesignerSerializerAttribute() { Pointer= p0 };

            value.TypeId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 TypeId                      ( ModelPrimitiveType string string string String )
            value.Reloadable                                = GetBool(new IntPtr(p + 0x018)); // 0x18 Reloadable                  ( ModelPrimitiveType bool bool bool Bool )
            value.SerializerTypeName                        = GetString(new IntPtr(p + 0x020)); // 0x20 SerializerTypeName          ( ModelPrimitiveType string string string String )
            value.SerializerBaseTypeName                    = GetString(new IntPtr(p + 0x028)); // 0x28 SerializerBaseTypeName      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
