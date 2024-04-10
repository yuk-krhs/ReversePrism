using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniNamePlate                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 TxtNickName                              000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 TxtName                                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 GoNew                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PieceItem                                0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 048 TxtPieceDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 RainbowItem                              0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 058 PidolsRarity                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 SidolsRarity                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 GashaSign                                00018661B650 ModelClassType GashaSign GashaSign GashaSign Pointer
    // 070 IsPlaySE                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GashaNamePlateEx : DataModel
    {
        public Animator?                                AniNamePlate                            { get; set; }
        public List<UITextMeshProUGUI>?                 TxtNickName                             { get; set; }
        public List<UITextMeshProUGUI>?                 TxtName                                 { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public CmnItem?                                 PieceItem                               { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }
        public CmnItem?                                 RainbowItem                             { get; set; }
        public List<GameObject>?                        PidolsRarity                            { get; set; }
        public List<GameObject>?                        SidolsRarity                            { get; set; }
        public GashaSign?                               GashaSign                               { get; set; }
        public bool                                     IsPlaySE                                { get; set; }

        public static GashaNamePlateEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNamePlateEx() { Pointer= p0 };

            value.AniNamePlate                              = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 024664E27A30 0x20 AniNamePlate                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TxtNickName                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27A50 0x28 TxtNickName                 ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtName                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27A70 0x30 TxtName                     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664E27A90 0x38 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceItem                                 = GetObject<CmnItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.CmnItem.FromPointer); // 024664E27AB0 0x40 PieceItem                   ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27AD0 0x48 TxtPieceDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RainbowItem                               = GetObject<CmnItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.CmnItem.FromPointer); // 024664E27AF0 0x50 RainbowItem                 ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.PidolsRarity                              = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024664E27B10 0x58 PidolsRarity                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SidolsRarity                              = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 024664E27B30 0x60 SidolsRarity                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.GashaSign                                 = GetObject<GashaSign>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaSign.FromPointer); // 024664E27B50 0x68 GashaSign                   ( 00018661B650 ModelClassType GashaSign GashaSign GashaSign Pointer )
            value.IsPlaySE                                  = GetBool(new IntPtr(p + 0x070)); // 024664E27B70 0x70 IsPlaySE                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
