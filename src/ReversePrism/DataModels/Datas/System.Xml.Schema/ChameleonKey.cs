using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetNS                                 000186671BA0 ModelPrimitiveType string string string String
    // 018 ChameleonLocation                        0001866A44C0 ModelClassType Uri Uri Uri Pointer
    // 020 OriginalSchema                           0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 028 HashCode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChameleonKey : DataModel
    {
        public string                                   TargetNS                                { get; set; }
        public Uri?                                     ChameleonLocation                       { get; set; }
        public XmlSchema?                               OriginalSchema                          { get; set; }
        public int                                      HashCode                                { get; set; }

        public static ChameleonKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChameleonKey() { Pointer= p0 };

            value.TargetNS                                  = GetString(new IntPtr(p + 0x010)); // 024667559098 0x10 TargetNS                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ChameleonLocation                         = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0246675590B8 0x18 ChameleonLocation           ( 0001866A44C0 ModelClassType Uri Uri Uri Pointer )
            value.OriginalSchema                            = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 0246675590D8 0x20 OriginalSchema              ( 0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x028)); // 0246675590F8 0x28 HashCode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
