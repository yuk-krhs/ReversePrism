using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Writer                                   000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer
    public partial class WriteBase64AsyncResult
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Count                                   { get; set; }
        public XmlDictionaryWriter?                     Writer                                  { get; set; }

        public static WriteBase64AsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteBase64AsyncResult();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x070)); // 0270D7C64278 0x70 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x078)); // 0270D7C64298 0x78 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x07C)); // 0270D7C642B8 0x7C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Writer                                    = GetObject<XmlDictionaryWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlDictionaryWriter.FromPointer); // 0270D7C642D8 0x80 Writer                      ( 000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer )

            return value;
        }
    }
}
