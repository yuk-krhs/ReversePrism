using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaSimpleProduceIco                    00018661BD90 ModelClassType GashaSimpleProduceIco GashaSimpleProduceIco GashaSimpleProduceIco Pointer
    // 028 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtNameAlias                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoStars                                  000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 Btn                                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 050 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class GashaPickupProduceCell : DataModel
    {
        public GashaSimpleProduceIco?                   GashaSimpleProduceIco                   { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtNameAlias                            { get; set; }
        public List<GameObject>?                        GoStars                                 { get; set; }
        public ButtonBase?                              Btn                                     { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public CancellationToken                        Ct                                      { get; set; }

        public static GashaPickupProduceCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPickupProduceCell() { Pointer= p0 };

            value.GashaSimpleProduceIco                     = GetObject<GashaSimpleProduceIco>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaSimpleProduceIco.FromPointer); // 0246653C6698 0x20 GashaSimpleProduceIco       ( 00018661BD90 ModelClassType GashaSimpleProduceIco GashaSimpleProduceIco GashaSimpleProduceIco Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653C66B8 0x28 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNameAlias                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653C66D8 0x30 TxtNameAlias                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoStars                                   = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246653C66F8 0x38 GoStars                     ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Btn                                       = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653C6718 0x40 Btn                         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0246653C6738 0x48 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0246653C6758 0x50 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
