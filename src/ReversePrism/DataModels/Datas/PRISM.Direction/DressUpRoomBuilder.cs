using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186704080 ModelClassType DressUpRoomView DressUpRoomView DressUpRoomView Pointer
    // 028 UiView                                   0001867038C0 ModelClassType DressUpRoomUIView DressUpRoomUIView DressUpRoomUIView Pointer
    // 030 DressUpRoom3DViewer                      0001866FCC40 ModelClassType DressUpRoom3DViewer DressUpRoom3DViewer DressUpRoom3DViewer Pointer
    // 038 CostumeChangeView                        0001866FE980 ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer
    // 040 HomeSettingsIdolSelectPopupViewFactory   0001866CE8C0 ModelClassType HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory Pointer
    // 048 CostumeDetailPopupViewFactory            00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    public partial class DressUpRoomBuilder : DataModel
    {
        public DressUpRoomView?                         View                                    { get; set; }
        public DressUpRoomUIView?                       UiView                                  { get; set; }
        public DressUpRoom3DViewer?                     DressUpRoom3DViewer                     { get; set; }
        public DressUpRoomCostumeChangeView?            CostumeChangeView                       { get; set; }
        public HomeSettingsIdolSelectPopupViewFactory?  HomeSettingsIdolSelectPopupViewFactory  { get; set; }
        public CostumeDetailPopupViewFactory?           CostumeDetailPopupViewFactory           { get; set; }

        public static DressUpRoomBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomBuilder() { Pointer= p0 };

            value.View                                      = GetObject<DressUpRoomView>(new IntPtr(p + 0x020), ReversePrism.DataModels.DressUpRoomView.FromPointer); // 02466B6D1590 0x20 View                        ( 000186704080 ModelClassType DressUpRoomView DressUpRoomView DressUpRoomView Pointer )
            value.UiView                                    = GetObject<DressUpRoomUIView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomUIView.FromPointer); // 02466B6D15B0 0x28 UiView                      ( 0001867038C0 ModelClassType DressUpRoomUIView DressUpRoomUIView DressUpRoomUIView Pointer )
            value.DressUpRoom3DViewer                       = GetObject<DressUpRoom3DViewer>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressUpRoom3DViewer.FromPointer); // 02466B6D15D0 0x30 DressUpRoom3DViewer         ( 0001866FCC40 ModelClassType DressUpRoom3DViewer DressUpRoom3DViewer DressUpRoom3DViewer Pointer )
            value.CostumeChangeView                         = GetObject<DressUpRoomCostumeChangeView>(new IntPtr(p + 0x038), ReversePrism.DataModels.DressUpRoomCostumeChangeView.FromPointer); // 02466B6D15F0 0x38 CostumeChangeView           ( 0001866FE980 ModelClassType DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView DressUpRoomCostumeChangeView Pointer )
            value.HomeSettingsIdolSelectPopupViewFactory    = GetObject<HomeSettingsIdolSelectPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSettingsIdolSelectPopupViewFactory.FromPointer); // 02466B6D1610 0x40 HomeSettingsIdolSelectPopupViewFactory ( 0001866CE8C0 ModelClassType HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 02466B6D1630 0x48 CostumeDetailPopupViewFactory ( 00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
