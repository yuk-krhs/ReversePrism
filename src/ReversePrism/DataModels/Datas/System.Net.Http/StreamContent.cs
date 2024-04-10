using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Content                                  000186670BE0 ModelClassType Stream Stream Stream Pointer
    // 030 BufferSize                               0001865F4260 ModelPrimitiveType int int int Int32
    // 038 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 040 StartPosition                            0001865F8300 ModelPrimitiveType long long long Int64
    // 048 ContentCopied                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StreamContent : DataModel
    {
        public Stream?                                  Content                                 { get; set; }
        public int                                      BufferSize                              { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public long                                     StartPosition                           { get; set; }
        public bool                                     ContentCopied                           { get; set; }

        public static StreamContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamContent() { Pointer= p0 };

            value.Content                                   = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 02466B8AC360 0x28 Content                     ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x030)); // 02466B8AC380 0x30 BufferSize                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x038)); // 02466B8AC3A0 0x38 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.StartPosition                             = GetInt64(new IntPtr(p + 0x040)); // 02466B8AC3C0 0x40 StartPosition               ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.ContentCopied                             = GetBool(new IntPtr(p + 0x048)); // 02466B8AC3E0 0x48 ContentCopied               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
