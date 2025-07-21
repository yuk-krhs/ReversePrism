using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TrailBuffer                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 TrailCount                               ModelPrimitiveType int int int Int32
    // 020 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Offset                                   ModelPrimitiveType int int int Int32
    // 02C Count                                    ModelPrimitiveType int int int Int32
    public partial class XmlNodeWriterWriteBase64TextArgs : DataModel
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
            var value   = new XmlNodeWriterWriteBase64TextArgs() { Pointer= p0 };

            value.TrailBuffer                               = GetSByteList(new IntPtr(p + 0x010)); // 0x10 TrailBuffer                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TrailCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 TrailCount                  ( ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
