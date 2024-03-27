using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyValue                                 0001866DCEA0 ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer
    // 018 Params                                   0001866DCEA0 ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer
    // 020 Oid                                      0001866D8390 ModelClassType Oid Oid Oid Pointer
    // 000 Empty                                    sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class PublicKey
    {
        public AsnEncodedData?                          KeyValue                                { get; set; }
        public AsnEncodedData?                          Params                                  { get; set; }
        public Oid?                                     Oid                                     { get; set; }

        public static PublicKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PublicKey();

            value.KeyValue                                  = GetObject<AsnEncodedData>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsnEncodedData.FromPointer); // 0270D79E2A08 0x10 KeyValue                    ( 0001866DCEA0 ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer )
            value.Params                                    = GetObject<AsnEncodedData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AsnEncodedData.FromPointer); // 0270D79E2A28 0x18 Params                      ( 0001866DCEA0 ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer )
            value.Oid                                       = GetObject<Oid>(new IntPtr(p + 0x020), ReversePrism.DataModels.Oid.FromPointer); // 0270D79E2A48 0x20 Oid                         ( 0001866D8390 ModelClassType Oid Oid Oid Pointer )

            return value;
        }
    }
}
