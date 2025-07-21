using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VerifyFunc                               ModelClassType NativeVerifyFunc NativeVerifyFunc NativeVerifyFunc Pointer
    // 028 SelectFunc                               ModelClassType NativeSelectFunc NativeSelectFunc NativeSelectFunc Pointer
    // 030 ServerNameFunc                           ModelClassType NativeServerNameFunc NativeServerNameFunc NativeServerNameFunc Pointer
    // 038 verifyFuncPtr                            <int> IL2CPP_TYPE_I
    // 040 selectFuncPtr                            <int> IL2CPP_TYPE_I
    // 048 serverNameFuncPtr                        <int> IL2CPP_TYPE_I
    // 050 VerifyCallback                           ModelClassType MonoBtlsVerifyCallback MonoBtlsVerifyCallback MonoBtlsVerifyCallback Pointer
    // 058 SelectCallback                           ModelClassType MonoBtlsSelectCallback MonoBtlsSelectCallback MonoBtlsSelectCallback Pointer
    // 060 ServerNameCallback                       ModelClassType MonoBtlsServerNameCallback MonoBtlsServerNameCallback MonoBtlsServerNameCallback Pointer
    // 068 Store                                    ModelClassType MonoBtlsX509Store MonoBtlsX509Store MonoBtlsX509Store Pointer
    // 070 Instance                                 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 078 instancePtr                              <int> IL2CPP_TYPE_I
    public partial class MonoBtlsSslCtx : DataModel
    {
        public NativeVerifyFunc?                        VerifyFunc                              { get; set; }
        public NativeSelectFunc?                        SelectFunc                              { get; set; }
        public NativeServerNameFunc?                    ServerNameFunc                          { get; set; }
        public MonoBtlsVerifyCallback?                  VerifyCallback                          { get; set; }
        public MonoBtlsSelectCallback?                  SelectCallback                          { get; set; }
        public MonoBtlsServerNameCallback?              ServerNameCallback                      { get; set; }
        public MonoBtlsX509Store?                       Store                                   { get; set; }
        public GCHandle                                 Instance                                { get; set; }

        public static MonoBtlsSslCtx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsSslCtx() { Pointer= p0 };

            value.VerifyFunc                                = GetObject<NativeVerifyFunc>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeVerifyFunc.FromPointer); // 0x20 VerifyFunc                  ( ModelClassType NativeVerifyFunc NativeVerifyFunc NativeVerifyFunc Pointer )
            value.SelectFunc                                = GetObject<NativeSelectFunc>(new IntPtr(p + 0x028), ReversePrism.DataModels.NativeSelectFunc.FromPointer); // 0x28 SelectFunc                  ( ModelClassType NativeSelectFunc NativeSelectFunc NativeSelectFunc Pointer )
            value.ServerNameFunc                            = GetObject<NativeServerNameFunc>(new IntPtr(p + 0x030), ReversePrism.DataModels.NativeServerNameFunc.FromPointer); // 0x30 ServerNameFunc              ( ModelClassType NativeServerNameFunc NativeServerNameFunc NativeServerNameFunc Pointer )
            value.VerifyCallback                            = GetObject<MonoBtlsVerifyCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.MonoBtlsVerifyCallback.FromPointer); // 0x50 VerifyCallback              ( ModelClassType MonoBtlsVerifyCallback MonoBtlsVerifyCallback MonoBtlsVerifyCallback Pointer )
            value.SelectCallback                            = GetObject<MonoBtlsSelectCallback>(new IntPtr(p + 0x058), ReversePrism.DataModels.MonoBtlsSelectCallback.FromPointer); // 0x58 SelectCallback              ( ModelClassType MonoBtlsSelectCallback MonoBtlsSelectCallback MonoBtlsSelectCallback Pointer )
            value.ServerNameCallback                        = GetObject<MonoBtlsServerNameCallback>(new IntPtr(p + 0x060), ReversePrism.DataModels.MonoBtlsServerNameCallback.FromPointer); // 0x60 ServerNameCallback          ( ModelClassType MonoBtlsServerNameCallback MonoBtlsServerNameCallback MonoBtlsServerNameCallback Pointer )
            value.Store                                     = GetObject<MonoBtlsX509Store>(new IntPtr(p + 0x068), ReversePrism.DataModels.MonoBtlsX509Store.FromPointer); // 0x68 Store                       ( ModelClassType MonoBtlsX509Store MonoBtlsX509Store MonoBtlsX509Store Pointer )
            value.Instance                                  = (GCHandle)GetInt32(new IntPtr(p + 0x070)); // 0x70 Instance                    ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
