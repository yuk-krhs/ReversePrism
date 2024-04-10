using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpirationDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LoginBonusPassStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsEffectiveFieldNumber                   int IL2CPP_TYPE_I4
    // 028 IsEffective                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ExpirationDateFieldNumber                int IL2CPP_TYPE_I4
    // 030 _ExpirationDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 StoreItemFieldNumber                     int IL2CPP_TYPE_I4
    // 038 StoreItem                                000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer
    public partial class LoginBonusPassStoreItemStatus : DataModel
    {
        public DateTime                                 ExpirationDate                          { get; set; }
        public bool                                     IsEffective                             { get; set; }
        public Timestamp?                               _ExpirationDate                         { get; set; }
        public StoreItemStatus?                         StoreItem                               { get; set; }

        public static LoginBonusPassStoreItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusPassStoreItemStatus() { Pointer= p0 };

            value.ExpirationDate                            = GetDateTime(new IntPtr(p + 0x010)); // 024662758560 0x10 ExpirationDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsEffective                               = GetBool(new IntPtr(p + 0x028)); // 0246627585E0 0x28 IsEffective                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._ExpirationDate                           = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 024662758620 0x30 _ExpirationDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.StoreItem                                 = GetObject<StoreItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 024662758660 0x38 StoreItem                   ( 000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer )
            value.ExpirationDate                = ToDateTime(value._ExpirationDate);

            return value;
        }
    }
}
