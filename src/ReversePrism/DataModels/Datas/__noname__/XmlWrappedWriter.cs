using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Prefix                                   0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 024667CBC3E8 0x18 Writer                      ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 024667CBC408 0x20 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Prefix                                    = GetInt32(new IntPtr(p + 0x024)); // 024667CBC428 0x24 Prefix                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
