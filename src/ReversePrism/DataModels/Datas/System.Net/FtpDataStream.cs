using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Request                                  0001865D1530 ModelClassType FtpWebRequest FtpWebRequest FtpWebRequest Pointer
    // 030 NetworkStream                            00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    // 038 Writeable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 Readable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A IsFullyRead                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03B Closing                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FtpDataStream : DataModel
    {
        public FtpWebRequest?                           Request                                 { get; set; }
        public NetworkStream?                           NetworkStream                           { get; set; }
        public bool                                     Writeable                               { get; set; }
        public bool                                     Readable                                { get; set; }
        public bool                                     IsFullyRead                             { get; set; }
        public bool                                     Closing                                 { get; set; }

        public static FtpDataStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FtpDataStream() { Pointer= p0 };

            value.Request                                   = GetObject<FtpWebRequest>(new IntPtr(p + 0x028), ReversePrism.DataModels.FtpWebRequest.FromPointer); // 024667A6AA48 0x28 Request                     ( 0001865D1530 ModelClassType FtpWebRequest FtpWebRequest FtpWebRequest Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.NetworkStream.FromPointer); // 024667A6AA68 0x30 NetworkStream               ( 00018669CD10 ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.Writeable                                 = GetBool(new IntPtr(p + 0x038)); // 024667A6AA88 0x38 Writeable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Readable                                  = GetBool(new IntPtr(p + 0x039)); // 024667A6AAA8 0x39 Readable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFullyRead                               = GetBool(new IntPtr(p + 0x03A)); // 024667A6AAC8 0x3A IsFullyRead                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Closing                                   = GetBool(new IntPtr(p + 0x03B)); // 024667A6AAE8 0x3B Closing                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
