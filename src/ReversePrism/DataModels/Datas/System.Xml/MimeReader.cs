using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CRLFCRLF                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 BoundaryBytes                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Content                                  000186671910 ModelPrimitiveType string string string String
    // 020 CurrentStream                            000186670270 ModelClassType Stream Stream Stream Pointer
    // 028 MimeHeaderReader                         000186618070 ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer
    // 030 Reader                                   0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer
    // 038 Scratch                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MimeReader : DataModel
    {
        public List<sbyte>?                             BoundaryBytes                           { get; set; }
        public string                                   Content                                 { get; set; }
        public Stream?                                  CurrentStream                           { get; set; }
        public MimeHeaderReader?                        MimeHeaderReader                        { get; set; }
        public DelimittedStreamReader?                  Reader                                  { get; set; }
        public List<sbyte>?                             Scratch                                 { get; set; }

        public static MimeReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeReader() { Pointer= p0 };

            value.BoundaryBytes                             = GetSByteList(new IntPtr(p + 0x010)); // 024667CC2E00 0x10 BoundaryBytes               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Content                                   = GetString(new IntPtr(p + 0x018)); // 024667CC2E20 0x18 Content                     ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrentStream                             = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 024667CC2E40 0x20 CurrentStream               ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.MimeHeaderReader                          = GetObject<MimeHeaderReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MimeHeaderReader.FromPointer); // 024667CC2E60 0x28 MimeHeaderReader            ( 000186618070 ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer )
            value.Reader                                    = GetObject<DelimittedStreamReader>(new IntPtr(p + 0x030), ReversePrism.DataModels.DelimittedStreamReader.FromPointer); // 024667CC2E80 0x30 Reader                      ( 0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer )
            value.Scratch                                   = GetSByteList(new IntPtr(p + 0x038)); // 024667CC2EA0 0x38 Scratch                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
