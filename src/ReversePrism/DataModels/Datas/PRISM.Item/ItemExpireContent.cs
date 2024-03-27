using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 UigreadSystem                            0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer
    // 068 Product                                  000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 070 ExpireList                               000185B869D0 ModelClassListType IExpireDateStatus[] IExpireDateStatus[] List<IExpireDateStatus> Pointer
    // 078 ListLength                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ItemExpireContent
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public IHavingProductStatus?                    Product                                 { get; set; }
        public List<IExpireDateStatus>?                 ExpireList                              { get; set; }
        public int                                      ListLength                              { get; set; }

        public static ItemExpireContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemExpireContent();

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0270D52D9818 0x60 UigreadSystem               ( 0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.Product                                   = GetObject<IHavingProductStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D52D9838 0x68 Product                     ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.ExpireList                                = GetObjectList<IExpireDateStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IExpireDateStatus.FromPointer); // 0270D52D9858 0x70 ExpireList                  ( 000185B869D0 ModelClassListType IExpireDateStatus[] IExpireDateStatus[] List<IExpireDateStatus> Pointer )
            value.ListLength                                = GetInt32(new IntPtr(p + 0x078)); // 0270D52D9878 0x78 ListLength                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
