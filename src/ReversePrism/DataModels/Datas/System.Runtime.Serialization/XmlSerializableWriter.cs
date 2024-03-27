using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 XmlWriter                                0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 obj                                      <object> IL2CPP_TYPE_OBJECT
    public partial class XmlSerializableWriter
    {
        public XmlWriter?                               XmlWriter                               { get; set; }
        public int                                      Depth                                   { get; set; }

        public static XmlSerializableWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableWriter();

            value.XmlWriter                                 = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0270D7D724C0 0x18 XmlWriter                   ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D7D724E0 0x20 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
