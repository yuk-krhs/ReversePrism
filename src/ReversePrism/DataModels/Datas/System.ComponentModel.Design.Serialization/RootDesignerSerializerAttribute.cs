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

            value.TypeId                                    = GetString(new IntPtr(p + 0x010)); // 024667BA73C0 0x10 TypeId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Reloadable                                = GetBool(new IntPtr(p + 0x018)); // 024667BA73E0 0x18 Reloadable                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.SerializerTypeName                        = GetString(new IntPtr(p + 0x020)); // 024667BA7400 0x20 SerializerTypeName          ( 000186672F10 ModelPrimitiveType string string string String )
            value.SerializerBaseTypeName                    = GetString(new IntPtr(p + 0x028)); // 024667BA7420 0x28 SerializerBaseTypeName      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
