using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 XNs                                      0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 028 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C prefixChar                               char IL2CPP_TYPE_CHAR
    public partial class Namespace
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Ns                                      { get; set; }
        public XmlDictionaryString?                     XNs                                     { get; set; }
        public int                                      Depth                                   { get; set; }

        public static Namespace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Namespace();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270D7C13A18 0x10 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0270D7C13A38 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.XNs                                       = GetObject<XmlDictionaryString>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7C13A58 0x20 XNs                         ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x028)); // 0270D7C13A78 0x28 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
