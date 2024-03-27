using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellGroupPrefab                          0001866C57E0 ModelClassType IdolStoryFirstCategoryCellGroup IdolStoryFirstCategoryCellGroup IdolStoryFirstCategoryCellGroup Pointer
    // 028 CellGroupPos                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 038 onClickCellSubject                       Subject`1<IdolStoryFirstCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 040 CellGroups                               000185CEABA8 ModelClassListType List`1<IdolStoryFirstCategoryCellGroup> List`1<IdolStoryFirstCategoryCellGroup> List<IdolStoryFirstCategoryCellGroup> Pointer
    // 048 UnreadCellExists                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IdolStoryFirstCategoryCellGroupList
    {
        public IdolStoryFirstCategoryCellGroup?         CellGroupPrefab                         { get; set; }
        public Transform?                               CellGroupPos                            { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public List<IdolStoryFirstCategoryCellGroup>?   CellGroups                              { get; set; }
        public bool                                     UnreadCellExists                        { get; set; }

        public static IdolStoryFirstCategoryCellGroupList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellGroupList();

            value.CellGroupPrefab                           = GetObject<IdolStoryFirstCategoryCellGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStoryFirstCategoryCellGroup.FromPointer); // 0270DB9990E8 0x20 CellGroupPrefab             ( 0001866C57E0 ModelClassType IdolStoryFirstCategoryCellGroup IdolStoryFirstCategoryCellGroup IdolStoryFirstCategoryCellGroup Pointer )
            value.CellGroupPos                              = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB999108 0x28 CellGroupPos                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 0270DB999128 0x30 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.CellGroups                                = GetObjectList<IdolStoryFirstCategoryCellGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolStoryFirstCategoryCellGroup.FromPointer); // 0270DB999168 0x40 CellGroups                  ( 000185CEABA8 ModelClassListType List`1<IdolStoryFirstCategoryCellGroup> List`1<IdolStoryFirstCategoryCellGroup> List<IdolStoryFirstCategoryCellGroup> Pointer )
            value.UnreadCellExists                          = GetBool(new IntPtr(p + 0x048)); // 0270DB999188 0x48 UnreadCellExists            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
