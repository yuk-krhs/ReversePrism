using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 source                                   <object> IL2CPP_TYPE_OBJECT
    // 018 Ids                                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Callback                                 ModelClassType XmlSerializationFixupCallback XmlSerializationFixupCallback XmlSerializationFixupCallback Pointer
    public partial class Fixup : DataModel
    {
        public List<string>?                            Ids                                     { get; set; }
        public XmlSerializationFixupCallback?           Callback                                { get; set; }

        public static Fixup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Fixup() { Pointer= p0 };

            value.Ids                                       = GetStringList(new IntPtr(p + 0x018)); // 0x18 Ids                         ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Callback                                  = GetObject<XmlSerializationFixupCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSerializationFixupCallback.FromPointer); // 0x20 Callback                    ( ModelClassType XmlSerializationFixupCallback XmlSerializationFixupCallback XmlSerializationFixupCallback Pointer )

            return value;
        }
    }
}
