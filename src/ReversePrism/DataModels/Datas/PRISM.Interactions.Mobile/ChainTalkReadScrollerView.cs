using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 Scrollbar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 030 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ScrollButton                             0001865660C0 ModelClassType ChainTalkScrollButton ChainTalkScrollButton ChainTalkScrollButton Pointer
    // 048 TalkCellPrefabs                          000185B73B00 ModelClassListType ChainTalkCellForReadScroller[] ChainTalkCellForReadScroller[] List<ChainTalkCellForReadScroller> Pointer
    // 050 SeparatorCellPrefab                      0001865665A0 ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer
    // 058 ChainTextColor                           000186568B20 ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer
    // 060 ScrollingDurationRatio                   0001866656B0 ModelPrimitiveType float float float Single
    // 068 CellDataList                             000185D20958 ModelClassListType List`1<ChainTalkCellDataWithDisposables> List`1<ChainTalkCellDataWithDisposables> List<ChainTalkCellDataWithDisposables> Pointer
    // 070 onClickIconSubject                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onClickThumbnailSubject                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 088 IsScrolling                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkReadScrollerView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public Scrollbar?                               Scrollbar                               { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public ChainTalkScrollButton?                   ScrollButton                            { get; set; }
        public List<ChainTalkCellForReadScroller>?      TalkCellPrefabs                         { get; set; }
        public ChainTalkSeparatorCell?                  SeparatorCellPrefab                     { get; set; }
        public ChainTextColor?                          ChainTextColor                          { get; set; }
        public float                                    ScrollingDurationRatio                  { get; set; }
        public List<ChainTalkCellDataWithDisposables>?  CellDataList                            { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public bool                                     IsScrolling                             { get; set; }

        public static ChainTalkReadScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkReadScrollerView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466B14E408 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x028), ReversePrism.DataModels.Scrollbar.FromPointer); // 02466B14E428 0x28 Scrollbar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B14E448 0x30 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B14E468 0x38 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScrollButton                              = GetObject<ChainTalkScrollButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChainTalkScrollButton.FromPointer); // 02466B14E488 0x40 ScrollButton                ( 0001865660C0 ModelClassType ChainTalkScrollButton ChainTalkScrollButton ChainTalkScrollButton Pointer )
            value.TalkCellPrefabs                           = GetObjectList<ChainTalkCellForReadScroller>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkCellForReadScroller.FromPointer); // 02466B14E4A8 0x48 TalkCellPrefabs             ( 000185B73B00 ModelClassListType ChainTalkCellForReadScroller[] ChainTalkCellForReadScroller[] List<ChainTalkCellForReadScroller> Pointer )
            value.SeparatorCellPrefab                       = GetObject<ChainTalkSeparatorCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChainTalkSeparatorCell.FromPointer); // 02466B14E4C8 0x50 SeparatorCellPrefab         ( 0001865665A0 ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer )
            value.ChainTextColor                            = GetObject<ChainTextColor>(new IntPtr(p + 0x058), ReversePrism.DataModels.ChainTextColor.FromPointer); // 02466B14E4E8 0x58 ChainTextColor              ( 000186568B20 ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer )
            value.ScrollingDurationRatio                    = GetSingle(new IntPtr(p + 0x060)); // 02466B14E508 0x60 ScrollingDurationRatio      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellDataList                              = GetObjectList<ChainTalkCellDataWithDisposables>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChainTalkCellDataWithDisposables.FromPointer); // 02466B14E528 0x68 CellDataList                ( 000185D20958 ModelClassListType List`1<ChainTalkCellDataWithDisposables> List`1<ChainTalkCellDataWithDisposables> List<ChainTalkCellDataWithDisposables> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B14E588 0x80 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.IsScrolling                               = GetBool(new IntPtr(p + 0x088)); // 02466B14E5A8 0x88 IsScrolling                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
