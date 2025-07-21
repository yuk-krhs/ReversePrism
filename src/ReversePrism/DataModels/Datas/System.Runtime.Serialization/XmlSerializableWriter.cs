using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 XmlWriter                                ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 Depth                                    ModelPrimitiveType int int int Int32
    // 028 obj                                      <object> IL2CPP_TYPE_OBJECT
    public partial class XmlSerializableWriter : DataModel
    {
        public XmlWriter?                               XmlWriter                               { get; set; }
        public int                                      Depth                                   { get; set; }

        public static XmlSerializableWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableWriter() { Pointer= p0 };

            value.XmlWriter                                 = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x18 XmlWriter                   ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Depth                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
