using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IdolView                                 ModelClassType LiveUnitEditCarouselIdolView LiveUnitEditCarouselIdolView LiveUnitEditCarouselIdolView Pointer
    // 040 SupportMemberView                        ModelClassType GameObject GameObject GameObject Pointer
    // 048 SupportMemberPanels                      ModelClassListType LiveUnitEditSupportMemberPanel[] LiveUnitEditSupportMemberPanel[] List<LiveUnitEditSupportMemberPanel> Pointer
    // 050 LiveUnit                                 ModelClassType LiveUnit LiveUnit LiveUnit Pointer
    // 058 IdolIconCanceller                        ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 060 SupportMemberCanceller                   ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 068 IconDragHandler                          ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer
    public partial class LiveUnitEditCarouselCell : DataModel
    {
        public LiveUnitEditCarouselIdolView?            IdolView                                { get; set; }
        public GameObject?                              SupportMemberView                       { get; set; }
        public List<LiveUnitEditSupportMemberPanel>?    SupportMemberPanels                     { get; set; }
        public LiveUnit?                                LiveUnit                                { get; set; }
        public AutoCancellationTokenSource              IdolIconCanceller                       { get; set; }
        public AutoCancellationTokenSource              SupportMemberCanceller                  { get; set; }
        public IdolIconDragHandler?                     IconDragHandler                         { get; set; }

        public static LiveUnitEditCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarouselCell() { Pointer= p0 };

            value.IdolView                                  = GetObject<LiveUnitEditCarouselIdolView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveUnitEditCarouselIdolView.FromPointer); // 0x38 IdolView                    ( ModelClassType LiveUnitEditCarouselIdolView LiveUnitEditCarouselIdolView LiveUnitEditCarouselIdolView Pointer )
            value.SupportMemberView                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 SupportMemberView           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportMemberPanels                       = GetObjectList<LiveUnitEditSupportMemberPanel>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveUnitEditSupportMemberPanel.FromPointer); // 0x48 SupportMemberPanels         ( ModelClassListType LiveUnitEditSupportMemberPanel[] LiveUnitEditSupportMemberPanel[] List<LiveUnitEditSupportMemberPanel> Pointer )
            value.LiveUnit                                  = GetObject<LiveUnit>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveUnit.FromPointer); // 0x50 LiveUnit                    ( ModelClassType LiveUnit LiveUnit LiveUnit Pointer )
            value.IdolIconCanceller                         = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x058)); // 0x58 IdolIconCanceller           ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SupportMemberCanceller                    = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 SupportMemberCanceller      ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IconDragHandler                           = GetObject<IdolIconDragHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.IdolIconDragHandler.FromPointer); // 0x68 IconDragHandler             ( ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer )

            return value;
        }
    }
}
