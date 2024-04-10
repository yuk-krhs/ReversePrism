using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <ButtonLabels>k__BackingField            IEnumerable`1<string> IL2CPP_TYPE_GENERICINST
    // 018 subject                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 000 ItemMenuItemType                         string IL2CPP_TYPE_STRING
    // 000 ItemMenuScrollPosition                   string IL2CPP_TYPE_STRING
    // 020 ItemList                                 000185CE4BF8 ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer
    // 028 ItemTabType                              0001866E49E0 ModelEnumType ItemTabType ItemTabType ItemTabType Int32
    // 030 ItemListScrollPositions                  000185D0A168 ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer
    public partial class ViewItemModel : DataModel
    {
        public List<IHavingProductStatus>?              ItemList                                { get; set; }
        public ItemTabType                              ItemTabType                             { get; set; }
        public List<float>?                             ItemListScrollPositions                 { get; set; }

        public static ViewItemModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewItemModel() { Pointer= p0 };

            value.ItemList                                  = GetObjectList<IHavingProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 024664C295E0 0x20 ItemList                    ( 000185CE4BF8 ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer )
            value.ItemTabType                               = (ItemTabType)GetInt32(new IntPtr(p + 0x028)); // 024664C29600 0x28 ItemTabType                 ( 0001866E49E0 ModelEnumType ItemTabType ItemTabType ItemTabType Int32 )
            value.ItemListScrollPositions                   = GetSingleList(new IntPtr(p + 0x030)); // 024664C29620 0x30 ItemListScrollPositions     ( 000185D0A168 ModelPrimitiveListType List`1<float> List`1<float> List<float> Pointer )

            return value;
        }
    }
}
