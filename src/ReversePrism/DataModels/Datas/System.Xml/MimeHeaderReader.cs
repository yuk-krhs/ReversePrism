using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType string string string String
    // 018 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 MaxOffset                                ModelPrimitiveType int int int Int32
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 Offset                                   ModelPrimitiveType int int int Int32
    // 034 ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 038 Stream                                   ModelClassType Stream Stream Stream Pointer
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

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType string string string String )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MaxOffset                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxOffset                   ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x034)); // 0x34 ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x038), ReversePrism.DataModels.Stream.FromPointer); // 0x38 Stream                      ( ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
