using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CRLFCRLF                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 GetContentStreamCalled                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 MimeHeaderReader                         000186618070 ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer
    // 020 Reader                                   0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer
    public partial class MimeMessageReader
    {
        public bool                                     GetContentStreamCalled                  { get; set; }
        public MimeHeaderReader?                        MimeHeaderReader                        { get; set; }
        public DelimittedStreamReader?                  Reader                                  { get; set; }

        public static MimeMessageReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeMessageReader();

            value.GetContentStreamCalled                    = GetBool(new IntPtr(p + 0x010)); // 0270D7C908B8 0x10 GetContentStreamCalled      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MimeHeaderReader                          = GetObject<MimeHeaderReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.MimeHeaderReader.FromPointer); // 0270D7C908D8 0x18 MimeHeaderReader            ( 000186618070 ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer )
            value.Reader                                    = GetObject<DelimittedStreamReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.DelimittedStreamReader.FromPointer); // 0270D7C908F8 0x20 Reader                      ( 0001866BDB70 ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer )

            return value;
        }
    }
}
