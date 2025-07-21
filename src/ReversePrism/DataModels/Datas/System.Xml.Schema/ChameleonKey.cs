using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetNS                                 ModelPrimitiveType string string string String
    // 018 ChameleonLocation                        ModelClassType Uri Uri Uri Pointer
    // 020 OriginalSchema                           ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 028 HashCode                                 ModelPrimitiveType int int int Int32
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

            value.TargetNS                                  = GetString(new IntPtr(p + 0x010)); // 0x10 TargetNS                    ( ModelPrimitiveType string string string String )
            value.ChameleonLocation                         = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0x18 ChameleonLocation           ( ModelClassType Uri Uri Uri Pointer )
            value.OriginalSchema                            = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x20 OriginalSchema              ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 HashCode                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
