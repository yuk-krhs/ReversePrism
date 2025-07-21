using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 TitleCellPrefab                          ModelClassType EtcetetaTitleCellView EtcetetaTitleCellView EtcetetaTitleCellView Pointer
    // 030 RowCellPrefab                            ModelClassType EtcetetaRowCellView EtcetetaRowCellView EtcetetaRowCellView Pointer
    // 038 ViewModels                               ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer
    // 040 Context                                  ModelClassType EtceteraCellListContext EtceteraCellListContext EtceteraCellListContext Pointer
    // 048 onSelect                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    public partial class EtceteraCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public EtcetetaTitleCellView?                   TitleCellPrefab                         { get; set; }
        public EtcetetaRowCellView?                     RowCellPrefab                           { get; set; }
        public List<EtceteraListCellViewModel>?         ViewModels                              { get; set; }
        public EtceteraCellListContext?                 Context                                 { get; set; }

        public static EtceteraCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.TitleCellPrefab                           = GetObject<EtcetetaTitleCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EtcetetaTitleCellView.FromPointer); // 0x28 TitleCellPrefab             ( ModelClassType EtcetetaTitleCellView EtcetetaTitleCellView EtcetetaTitleCellView Pointer )
            value.RowCellPrefab                             = GetObject<EtcetetaRowCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EtcetetaRowCellView.FromPointer); // 0x30 RowCellPrefab               ( ModelClassType EtcetetaRowCellView EtcetetaRowCellView EtcetetaRowCellView Pointer )
            value.ViewModels                                = GetObjectList<EtceteraListCellViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.EtceteraListCellViewModel.FromPointer); // 0x38 ViewModels                  ( ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer )
            value.Context                                   = GetObject<EtceteraCellListContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.EtceteraCellListContext.FromPointer); // 0x40 Context                     ( ModelClassType EtceteraCellListContext EtceteraCellListContext EtceteraCellListContext Pointer )

            return value;
        }
    }
}
