using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforePaidJewel                          ModelPrimitiveType long long long Int64
    // 018 BeforeFreeJewel                          ModelPrimitiveType long long long Int64
    // 020 StoreItems                               ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 028 SeasonPassItems                          ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 030 LoginBonusPassItems                      ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    public partial class ShopDeferredPurchaseParam : DataModel
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
            var value   = new ShopDeferredPurchaseParam() { Pointer= p0 };

            value.BeforePaidJewel                           = GetInt64(new IntPtr(p + 0x010)); // 0x10 BeforePaidJewel             ( ModelPrimitiveType long long long Int64 )
            value.BeforeFreeJewel                           = GetInt64(new IntPtr(p + 0x018)); // 0x18 BeforeFreeJewel             ( ModelPrimitiveType long long long Int64 )
            value.StoreItems                                = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x20 StoreItems                  ( ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.SeasonPassItems                           = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x28 SeasonPassItems             ( ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.LoginBonusPassItems                       = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x30 LoginBonusPassItems         ( ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )

            return value;
        }
    }
}
