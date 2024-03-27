using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaProductItem                         000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 028 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Stars                                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 Raritys                                  000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 TxtVolue                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ExtraProductItems                        000185B81C10 ModelClassListType GashaProductItemPresenter[] GashaProductItemPresenter[] List<GashaProductItemPresenter> Pointer
    // 050 ExtraProductItemAmount                   000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 058 TxtPieceDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaHistoryDetailCell
    {
        public GashaProductItemPresenter?               GashaProductItem                        { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public List<GameObject>?                        Stars                                   { get; set; }
        public List<GameObject>?                        Raritys                                 { get; set; }
        public UITextMeshProUGUI?                       TxtVolue                                { get; set; }
        public List<GashaProductItemPresenter>?         ExtraProductItems                       { get; set; }
        public List<UITextMeshProUGUI>?                 ExtraProductItemAmount                  { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }

        public static GashaHistoryDetailCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryDetailCell();

            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0270D5307378 0x20 GashaProductItem            ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5307398 0x28 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Stars                                     = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53073B8 0x30 Stars                       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Raritys                                   = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53073D8 0x38 Raritys                     ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TxtVolue                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53073F8 0x40 TxtVolue                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExtraProductItems                         = GetObjectList<GashaProductItemPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0270D5307418 0x48 ExtraProductItems           ( 000185B81C10 ModelClassListType GashaProductItemPresenter[] GashaProductItemPresenter[] List<GashaProductItemPresenter> Pointer )
            value.ExtraProductItemAmount                    = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5307438 0x50 ExtraProductItemAmount      ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5307458 0x58 TxtPieceDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
