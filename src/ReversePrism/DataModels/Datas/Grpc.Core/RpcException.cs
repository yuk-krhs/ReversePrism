using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Status                                   000186585850 ModelEnumType Status Status Status Int32
    // 0A8 Trailers                                 00018660C830 ModelClassType Metadata Metadata Metadata Pointer
    public partial class RpcException : DataModel
    {
        public Status                                   Status                                  { get; set; }
        public Metadata?                                Trailers                                { get; set; }

        public static RpcException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RpcException() { Pointer= p0 };

            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x090)); // 024662FB7DF0 0x90 Status                      ( 000186585850 ModelEnumType Status Status Status Int32 )
            value.Trailers                                  = GetObject<Metadata>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Metadata.FromPointer); // 024662FB7E10 0xA8 Trailers                    ( 00018660C830 ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
