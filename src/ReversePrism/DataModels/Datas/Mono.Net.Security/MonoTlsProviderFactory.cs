using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 008 initialized                              bool IL2CPP_TYPE_BOOLEAN
    // 010 DefaultProvider                          ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 018 providerRegistration                     Dictionary`2<string, Tuple`2<Guid, string>> IL2CPP_TYPE_GENERICINST
    // 020 providerCache                            Dictionary`2<Guid, MobileTlsProvider> IL2CPP_TYPE_GENERICINST
    // 028 UnityTlsId                               ModelEnumType Guid Guid Guid Int32
    // 038 AppleTlsId                               ModelEnumType Guid Guid Guid Int32
    // 048 BtlsId                                   ModelEnumType Guid Guid Guid Int32
    public partial class MonoTlsProviderFactory : DataModel
    {
        public MobileTlsProvider?                       DefaultProvider                         { get; set; }
        public Guid                                     UnityTlsId                              { get; set; }
        public Guid                                     AppleTlsId                              { get; set; }
        public Guid                                     BtlsId                                  { get; set; }

        public static MonoTlsProviderFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTlsProviderFactory() { Pointer= p0 };

            value.DefaultProvider                           = GetObject<MobileTlsProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0x10 DefaultProvider             ( ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.UnityTlsId                                = (Guid)GetInt32(new IntPtr(p + 0x028)); // 0x28 UnityTlsId                  ( ModelEnumType Guid Guid Guid Int32 )
            value.AppleTlsId                                = (Guid)GetInt32(new IntPtr(p + 0x038)); // 0x38 AppleTlsId                  ( ModelEnumType Guid Guid Guid Int32 )
            value.BtlsId                                    = (Guid)GetInt32(new IntPtr(p + 0x048)); // 0x48 BtlsId                      ( ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
