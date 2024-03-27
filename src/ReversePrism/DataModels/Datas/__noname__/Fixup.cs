using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 source                                   <object> IL2CPP_TYPE_OBJECT
    // 018 Ids                                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Callback                                 0001865C6130 ModelClassType XmlSerializationFixupCallback XmlSerializationFixupCallback XmlSerializationFixupCallback Pointer
    public partial class Fixup
    {
        public List<string>?                            Ids                                     { get; set; }
        public XmlSerializationFixupCallback?           Callback                                { get; set; }

        public static Fixup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Fixup();

            value.Ids                                       = GetStringList(new IntPtr(p + 0x018)); // 0270D74C8F30 0x18 Ids                         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Callback                                  = GetObject<XmlSerializationFixupCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSerializationFixupCallback.FromPointer); // 0270D74C8F50 0x20 Callback                    ( 0001865C6130 ModelClassType XmlSerializationFixupCallback XmlSerializationFixupCallback XmlSerializationFixupCallback Pointer )

            return value;
        }
    }
}
