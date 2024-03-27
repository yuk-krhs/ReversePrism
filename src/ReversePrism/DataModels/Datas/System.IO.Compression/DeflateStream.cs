using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Base_stream                              000186670270 ModelClassType Stream Stream Stream Pointer
    // 030 Mode                                     0001865F52A0 ModelEnumType CompressionMode CompressionMode CompressionMode Int32
    // 034 LeaveOpen                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 035 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Native                                   0001866B8C70 ModelClassType DeflateStreamNative DeflateStreamNative DeflateStreamNative Pointer
    public partial class DeflateStream
    {
        public Stream?                                  Base_stream                             { get; set; }
        public CompressionMode                          Mode                                    { get; set; }
        public bool                                     LeaveOpen                               { get; set; }
        public bool                                     Disposed                                { get; set; }
        public DeflateStreamNative?                     Native                                  { get; set; }

        public static DeflateStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeflateStream();

            value.Base_stream                               = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0270D7BDBB18 0x28 Base_stream                 ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Mode                                      = (CompressionMode)GetInt32(new IntPtr(p + 0x030)); // 0270D7BDBB38 0x30 Mode                        ( 0001865F52A0 ModelEnumType CompressionMode CompressionMode CompressionMode Int32 )
            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x034)); // 0270D7BDBB58 0x34 LeaveOpen                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x035)); // 0270D7BDBB78 0x35 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Native                                    = GetObject<DeflateStreamNative>(new IntPtr(p + 0x038), ReversePrism.DataModels.DeflateStreamNative.FromPointer); // 0270D7BDBB98 0x38 Native                      ( 0001866B8C70 ModelClassType DeflateStreamNative DeflateStreamNative DeflateStreamNative Pointer )

            return value;
        }
    }
}
