using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 TitleCellPrefab                          00018674AEE0 ModelClassType EtcetetaTitleCellView EtcetetaTitleCellView EtcetetaTitleCellView Pointer
    // 030 RowCellPrefab                            00018674AA20 ModelClassType EtcetetaRowCellView EtcetetaRowCellView EtcetetaRowCellView Pointer
    // 038 ViewModels                               000185CEF108 ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer
    // 040 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 048 Context                                  000186748BA0 ModelClassType EtceteraCellListContext EtceteraCellListContext EtceteraCellListContext Pointer
    // 050 onSelect                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    public partial class EtceteraCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public EtcetetaTitleCellView?                   TitleCellPrefab                         { get; set; }
        public EtcetetaRowCellView?                     RowCellPrefab                           { get; set; }
        public List<EtceteraListCellViewModel>?         ViewModels                              { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public EtceteraCellListContext?                 Context                                 { get; set; }

        public static EtceteraCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466A2FBD60 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.TitleCellPrefab                           = GetObject<EtcetetaTitleCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EtcetetaTitleCellView.FromPointer); // 02466A2FBD80 0x28 TitleCellPrefab             ( 00018674AEE0 ModelClassType EtcetetaTitleCellView EtcetetaTitleCellView EtcetetaTitleCellView Pointer )
            value.RowCellPrefab                             = GetObject<EtcetetaRowCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EtcetetaRowCellView.FromPointer); // 02466A2FBDA0 0x30 RowCellPrefab               ( 00018674AA20 ModelClassType EtcetetaRowCellView EtcetetaRowCellView EtcetetaRowCellView Pointer )
            value.ViewModels                                = GetObjectList<EtceteraListCellViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.EtceteraListCellViewModel.FromPointer); // 02466A2FBDC0 0x38 ViewModels                  ( 000185CEF108 ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A2FBDE0 0x40 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Context                                   = GetObject<EtceteraCellListContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.EtceteraCellListContext.FromPointer); // 02466A2FBE00 0x48 Context                     ( 000186748BA0 ModelClassType EtceteraCellListContext EtceteraCellListContext EtceteraCellListContext Pointer )

            return value;
        }
    }
}
