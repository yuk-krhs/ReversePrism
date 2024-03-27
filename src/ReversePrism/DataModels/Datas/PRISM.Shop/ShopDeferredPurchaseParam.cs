using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforePaidJewel                          0001865F7700 ModelPrimitiveType long long long Int64
    // 018 BeforeFreeJewel                          0001865F7700 ModelPrimitiveType long long long Int64
    // 020 StoreItems                               000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 028 SeasonPassItems                          000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 030 LoginBonusPassItems                      000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    public partial class ShopDeferredPurchaseParam
    {
        public long                                     BeforePaidJewel                         { get; set; }
        public long                                     BeforeFreeJewel                         { get; set; }
        public List<IStoreItemStatus>?                  StoreItems                              { get; set; }
        public List<IStoreItemStatus>?                  SeasonPassItems                         { get; set; }
        public List<IStoreItemStatus>?                  LoginBonusPassItems                     { get; set; }

        public static ShopDeferredPurchaseParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopDeferredPurchaseParam();

            value.BeforePaidJewel                           = GetInt64(new IntPtr(p + 0x010)); // 0270D5536550 0x10 BeforePaidJewel             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeFreeJewel                           = GetInt64(new IntPtr(p + 0x018)); // 0270D5536570 0x18 BeforeFreeJewel             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.StoreItems                                = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D5536590 0x20 StoreItems                  ( 000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.SeasonPassItems                           = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D55365B0 0x28 SeasonPassItems             ( 000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.LoginBonusPassItems                       = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D55365D0 0x30 LoginBonusPassItems         ( 000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )

            return value;
        }
    }
}
