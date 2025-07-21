using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyValue                                 ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer
    // 018 Params                                   ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer
    // 020 Oid                                      ModelClassType Oid Oid Oid Pointer
    // 000 Empty                                    sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class PublicKey : DataModel
    {
        public AsnEncodedData?                          KeyValue                                { get; set; }
        public AsnEncodedData?                          Params                                  { get; set; }
        public Oid?                                     Oid                                     { get; set; }

        public static PublicKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PublicKey() { Pointer= p0 };

            value.KeyValue                                  = GetObject<AsnEncodedData>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsnEncodedData.FromPointer); // 0x10 KeyValue                    ( ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer )
            value.Params                                    = GetObject<AsnEncodedData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AsnEncodedData.FromPointer); // 0x18 Params                      ( ModelClassType AsnEncodedData AsnEncodedData AsnEncodedData Pointer )
            value.Oid                                       = GetObject<Oid>(new IntPtr(p + 0x020), ReversePrism.DataModels.Oid.FromPointer); // 0x20 Oid                         ( ModelClassType Oid Oid Oid Pointer )

            return value;
        }
    }
}
