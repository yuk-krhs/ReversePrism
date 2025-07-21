using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 Status                                   ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 020 ExpireDateTime                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 ExpireDetailViewModels                   ModelClassListType ItemListExpireDetailListViewModel[] ItemListExpireDetailListViewModel[] List<ItemListExpireDetailListViewModel> Pointer
    // 038 IsUseButtonEnable                        ModelPrimitiveType bool bool bool Bool
    public partial class ItemListOverlayContentListViewModel : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public IHavingProductStatus?                    Status                                  { get; set; }
        public DateTime                                 ExpireDateTime                          { get; set; }
        public List<ItemListExpireDetailListViewModel>? ExpireDetailViewModels                  { get; set; }
        public bool                                     IsUseButtonEnable                       { get; set; }

        public static ItemListOverlayContentListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayContentListViewModel() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelected                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Status                                    = GetObject<IHavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x18 Status                      ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.ExpireDateTime                            = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ExpireDateTime              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExpireDetailViewModels                    = GetObjectList<ItemListExpireDetailListViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ItemListExpireDetailListViewModel.FromPointer); // 0x30 ExpireDetailViewModels      ( ModelClassListType ItemListExpireDetailListViewModel[] ItemListExpireDetailListViewModel[] List<ItemListExpireDetailListViewModel> Pointer )
            value.IsUseButtonEnable                         = GetBool(new IntPtr(p + 0x038)); // 0x38 IsUseButtonEnable           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
