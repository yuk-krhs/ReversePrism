using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32
    // 018 Info                                     ModelPrimitiveType string string string String
    public partial class X509ChainStatus : DataModel
    {
        public X509ChainStatusFlags                     Status                                  { get; set; }
        public string                                   Info                                    { get; set; }

        public static X509ChainStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainStatus() { Pointer= p0 };

            value.Status                                    = (X509ChainStatusFlags)GetInt32(new IntPtr(p + 0x010)); // 0x10 Status                      ( ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32 )
            value.Info                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Info                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
