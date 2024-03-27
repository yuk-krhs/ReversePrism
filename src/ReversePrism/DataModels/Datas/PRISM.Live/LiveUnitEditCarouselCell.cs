using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 LiveIdolView                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 IdolIcons                                000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 048 SupportMemberView                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 SupportMemberPanels                      000185B91D70 ModelClassListType LiveUnitEditSupportMemberPanel[] LiveUnitEditSupportMemberPanel[] List<LiveUnitEditSupportMemberPanel> Pointer
    // 058 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 060 FIdolDetailPopupCaller                   000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer
    // 068 LiveUnit                                 000186588310 ModelClassType LiveUnit LiveUnit LiveUnit Pointer
    // 070 IdolIconCanceller                        000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 078 SupportMemberCanceller                   000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 080 IconDragHandler                          0001866AEF70 ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer
    public partial class LiveUnitEditCarouselCell
    {
        public GameObject?                              LiveIdolView                            { get; set; }
        public List<LiveUnitEditCharacterIcon>?         IdolIcons                               { get; set; }
        public GameObject?                              SupportMemberView                       { get; set; }
        public List<LiveUnitEditSupportMemberPanel>?    SupportMemberPanels                     { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public FIdolDetailPopupCaller?                  FIdolDetailPopupCaller                  { get; set; }
        public LiveUnit?                                LiveUnit                                { get; set; }
        public AutoCancellationTokenSource              IdolIconCanceller                       { get; set; }
        public AutoCancellationTokenSource              SupportMemberCanceller                  { get; set; }
        public IdolIconDragHandler?                     IconDragHandler                         { get; set; }

        public static LiveUnitEditCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarouselCell();

            value.LiveIdolView                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52A6DF0 0x38 LiveIdolView                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolIcons                                 = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0270D52A6E10 0x40 IdolIcons                   ( 000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.SupportMemberView                         = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52A6E30 0x48 SupportMemberView           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportMemberPanels                       = GetObjectList<LiveUnitEditSupportMemberPanel>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveUnitEditSupportMemberPanel.FromPointer); // 0270D52A6E50 0x50 SupportMemberPanels         ( 000185B91D70 ModelClassListType LiveUnitEditSupportMemberPanel[] LiveUnitEditSupportMemberPanel[] List<LiveUnitEditSupportMemberPanel> Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x058), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D52A6E70 0x58 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.FIdolDetailPopupCaller                    = GetObject<FIdolDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.FIdolDetailPopupCaller.FromPointer); // 0270D52A6E90 0x60 FIdolDetailPopupCaller      ( 000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer )
            value.LiveUnit                                  = GetObject<LiveUnit>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveUnit.FromPointer); // 0270D52A6EB0 0x68 LiveUnit                    ( 000186588310 ModelClassType LiveUnit LiveUnit LiveUnit Pointer )
            value.IdolIconCanceller                         = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x070)); // 0270D52A6ED0 0x70 IdolIconCanceller           ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SupportMemberCanceller                    = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x078)); // 0270D52A6EF0 0x78 SupportMemberCanceller      ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IconDragHandler                           = GetObject<IdolIconDragHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.IdolIconDragHandler.FromPointer); // 0270D52A6F10 0x80 IconDragHandler             ( 0001866AEF70 ModelClassType IdolIconDragHandler IdolIconDragHandler IdolIconDragHandler Pointer )

            return value;
        }
    }
}
