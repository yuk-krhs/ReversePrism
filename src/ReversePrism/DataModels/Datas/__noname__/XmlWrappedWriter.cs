using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 Depth                                    ModelPrimitiveType int int int Int32
    // 024 Prefix                                   ModelPrimitiveType int int int Int32
    public partial class XmlWrappedWriter : DataModel
    {
        public XmlWriter?                               Writer                                  { get; set; }
        public int                                      Depth                                   { get; set; }
        public int                                      Prefix                                  { get; set; }

        public static XmlWrappedWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWrappedWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x18 Writer                      ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.Prefix                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 Prefix                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
