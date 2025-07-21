using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Request                                  ModelClassType FtpWebRequest FtpWebRequest FtpWebRequest Pointer
    // 030 NetworkStream                            ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    // 038 Writeable                                ModelPrimitiveType bool bool bool Bool
    // 039 Readable                                 ModelPrimitiveType bool bool bool Bool
    // 03A IsFullyRead                              ModelPrimitiveType bool bool bool Bool
    // 03B Closing                                  ModelPrimitiveType bool bool bool Bool
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

            value.Request                                   = GetObject<FtpWebRequest>(new IntPtr(p + 0x028), ReversePrism.DataModels.FtpWebRequest.FromPointer); // 0x28 Request                     ( ModelClassType FtpWebRequest FtpWebRequest FtpWebRequest Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.NetworkStream.FromPointer); // 0x30 NetworkStream               ( ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.Writeable                                 = GetBool(new IntPtr(p + 0x038)); // 0x38 Writeable                   ( ModelPrimitiveType bool bool bool Bool )
            value.Readable                                  = GetBool(new IntPtr(p + 0x039)); // 0x39 Readable                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsFullyRead                               = GetBool(new IntPtr(p + 0x03A)); // 0x3A IsFullyRead                 ( ModelPrimitiveType bool bool bool Bool )
            value.Closing                                   = GetBool(new IntPtr(p + 0x03B)); // 0x3B Closing                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
