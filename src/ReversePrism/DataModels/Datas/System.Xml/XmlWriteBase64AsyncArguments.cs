using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlWriteBase64AsyncArguments
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      Offset                                  { get; set; }

        public static XmlWriteBase64AsyncArguments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWriteBase64AsyncArguments();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0270D7C175A0 0x10 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D7C175C0 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D7C175E0 0x1C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D7C17600 0x20 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
