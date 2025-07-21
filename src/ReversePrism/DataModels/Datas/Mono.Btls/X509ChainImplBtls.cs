using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreCtx                                 ModelClassType MonoBtlsX509StoreCtx MonoBtlsX509StoreCtx MonoBtlsX509StoreCtx Pointer
    // 018 Chain                                    ModelClassType MonoBtlsX509Chain MonoBtlsX509Chain MonoBtlsX509Chain Pointer
    // 020 UntrustedChain                           ModelClassType MonoBtlsX509Chain MonoBtlsX509Chain MonoBtlsX509Chain Pointer
    // 028 Elements                                 ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer
    // 030 Untrusted                                ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 038 Certificates                             ModelClassListType X509Certificate2[] X509Certificate2[] List<X509Certificate2> Pointer
    // 040 Policy                                   ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer
    // 048 ChainStatusList                          ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer
    public partial class X509ChainImplBtls : DataModel
    {
        public MonoBtlsX509StoreCtx?                    StoreCtx                                { get; set; }
        public MonoBtlsX509Chain?                       Chain                                   { get; set; }
        public MonoBtlsX509Chain?                       UntrustedChain                          { get; set; }
        public X509ChainElementCollection?              Elements                                { get; set; }
        public X509Certificate2Collection?              Untrusted                               { get; set; }
        public List<X509Certificate2>?                  Certificates                            { get; set; }
        public X509ChainPolicy?                         Policy                                  { get; set; }
        public List<X509ChainStatus>?                   ChainStatusList                         { get; set; }

        public static X509ChainImplBtls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainImplBtls() { Pointer= p0 };

            value.StoreCtx                                  = GetObject<MonoBtlsX509StoreCtx>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoBtlsX509StoreCtx.FromPointer); // 0x10 StoreCtx                    ( ModelClassType MonoBtlsX509StoreCtx MonoBtlsX509StoreCtx MonoBtlsX509StoreCtx Pointer )
            value.Chain                                     = GetObject<MonoBtlsX509Chain>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonoBtlsX509Chain.FromPointer); // 0x18 Chain                       ( ModelClassType MonoBtlsX509Chain MonoBtlsX509Chain MonoBtlsX509Chain Pointer )
            value.UntrustedChain                            = GetObject<MonoBtlsX509Chain>(new IntPtr(p + 0x020), ReversePrism.DataModels.MonoBtlsX509Chain.FromPointer); // 0x20 UntrustedChain              ( ModelClassType MonoBtlsX509Chain MonoBtlsX509Chain MonoBtlsX509Chain Pointer )
            value.Elements                                  = GetObject<X509ChainElementCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509ChainElementCollection.FromPointer); // 0x28 Elements                    ( ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer )
            value.Untrusted                                 = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x030), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x30 Untrusted                   ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Certificates                              = GetObjectList<X509Certificate2>(new IntPtr(p + 0x038), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0x38 Certificates                ( ModelClassListType X509Certificate2[] X509Certificate2[] List<X509Certificate2> Pointer )
            value.Policy                                    = GetObject<X509ChainPolicy>(new IntPtr(p + 0x040), ReversePrism.DataModels.X509ChainPolicy.FromPointer); // 0x40 Policy                      ( ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer )
            value.ChainStatusList                           = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x048)); // 0x48 ChainStatusList             ( ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer )

            return value;
        }
    }
}
