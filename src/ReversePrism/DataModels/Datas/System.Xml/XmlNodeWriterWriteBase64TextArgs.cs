using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TrailBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 TrailCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlNodeWriterWriteBase64TextArgs
    {
        public List<sbyte>?                             TrailBuffer                             { get; set; }
        public int                                      TrailCount                              { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static XmlNodeWriterWriteBase64TextArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeWriterWriteBase64TextArgs();

            value.TrailBuffer                               = GetSByteList(new IntPtr(p + 0x010)); // 0270D7C16BF0 0x10 TrailBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TrailCount                                = GetInt32(new IntPtr(p + 0x018)); // 0270D7C16C10 0x18 TrailCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x020)); // 0270D7C16C30 0x20 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D7C16C50 0x28 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x02C)); // 0270D7C16C70 0x2C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
