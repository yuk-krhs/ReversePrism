using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaProductItem                         ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 028 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Stars                                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 Raritys                                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 TxtVolue                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ExtraProductItems                        ModelClassListType GashaProductItemPresenter[] GashaProductItemPresenter[] List<GashaProductItemPresenter> Pointer
    // 050 ExtraProductItemAmount                   ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 058 TxtPieceDetail                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaHistoryDetailCell : DataModel
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
            var value   = new GashaHistoryDetailCell() { Pointer= p0 };

            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x20 GashaProductItem            ( ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Stars                                     = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Stars                       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Raritys                                   = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 Raritys                     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TxtVolue                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtVolue                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExtraProductItems                         = GetObjectList<GashaProductItemPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x48 ExtraProductItems           ( ModelClassListType GashaProductItemPresenter[] GashaProductItemPresenter[] List<GashaProductItemPresenter> Pointer )
            value.ExtraProductItemAmount                    = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ExtraProductItemAmount      ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtPieceDetail              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
