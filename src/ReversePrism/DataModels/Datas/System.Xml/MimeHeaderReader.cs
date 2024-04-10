using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671910 ModelPrimitiveType string string string String
    // 018 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 MaxOffset                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 ReadState                                0001867182F0 ModelEnumType ReadState ReadState ReadState Int32
    // 038 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    public partial class MimeHeaderReader : DataModel
    {
        public string                                   Value                                   { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      MaxOffset                               { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      Offset                                  { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public Stream?                                  Stream                                  { get; set; }

        public static MimeHeaderReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeHeaderReader() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 024667CF0D38 0x10 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 024667CF0D58 0x18 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MaxOffset                                 = GetInt32(new IntPtr(p + 0x020)); // 024667CF0D78 0x20 MaxOffset                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 024667CF0D98 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x030)); // 024667CF0DB8 0x30 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x034)); // 024667CF0DD8 0x34 ReadState                   ( 0001867182F0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x038), ReversePrism.DataModels.Stream.FromPointer); // 024667CF0DF8 0x38 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
