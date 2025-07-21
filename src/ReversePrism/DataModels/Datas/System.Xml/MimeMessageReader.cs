using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CRLFCRLF                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 GetContentStreamCalled                   ModelPrimitiveType bool bool bool Bool
    // 018 MimeHeaderReader                         ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer
    // 020 Reader                                   ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer
    public partial class MimeMessageReader : DataModel
    {
        public bool                                     GetContentStreamCalled                  { get; set; }
        public MimeHeaderReader?                        MimeHeaderReader                        { get; set; }
        public DelimittedStreamReader?                  Reader                                  { get; set; }

        public static MimeMessageReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeMessageReader() { Pointer= p0 };

            value.GetContentStreamCalled                    = GetBool(new IntPtr(p + 0x010)); // 0x10 GetContentStreamCalled      ( ModelPrimitiveType bool bool bool Bool )
            value.MimeHeaderReader                          = GetObject<MimeHeaderReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.MimeHeaderReader.FromPointer); // 0x18 MimeHeaderReader            ( ModelClassType MimeHeaderReader MimeHeaderReader MimeHeaderReader Pointer )
            value.Reader                                    = GetObject<DelimittedStreamReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.DelimittedStreamReader.FromPointer); // 0x20 Reader                      ( ModelClassType DelimittedStreamReader DelimittedStreamReader DelimittedStreamReader Pointer )

            return value;
        }
    }
}
