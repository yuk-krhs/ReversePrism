using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniNamePlate                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 ConditionName                            000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 TxtNickName                              000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 TxtName                                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 040 GoNew                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PieceItem                                0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 050 TxtPieceDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 RainbowItem                              0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 060 GashaSign                                00018661B650 ModelClassType GashaSign GashaSign GashaSign Pointer
    public partial class GashaNamePlateS : DataModel
    {
        public Animator?                                AniNamePlate                            { get; set; }
        public List<string>?                            ConditionName                           { get; set; }
        public List<UITextMeshProUGUI>?                 TxtNickName                             { get; set; }
        public List<UITextMeshProUGUI>?                 TxtName                                 { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public CmnItem?                                 PieceItem                               { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }
        public CmnItem?                                 RainbowItem                             { get; set; }
        public GashaSign?                               GashaSign                               { get; set; }

        public static GashaNamePlateS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNamePlateS() { Pointer= p0 };

            value.AniNamePlate                              = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 024664E27BB0 0x20 AniNamePlate                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ConditionName                             = GetStringList(new IntPtr(p + 0x028)); // 024664E27BD0 0x28 ConditionName               ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TxtNickName                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27BF0 0x30 TxtNickName                 ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtName                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27C10 0x38 TxtName                     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024664E27C30 0x40 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceItem                                 = GetObject<CmnItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.CmnItem.FromPointer); // 024664E27C50 0x48 PieceItem                   ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664E27C70 0x50 TxtPieceDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RainbowItem                               = GetObject<CmnItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.CmnItem.FromPointer); // 024664E27C90 0x58 RainbowItem                 ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.GashaSign                                 = GetObject<GashaSign>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaSign.FromPointer); // 024664E27CB0 0x60 GashaSign                   ( 00018661B650 ModelClassType GashaSign GashaSign GashaSign Pointer )

            return value;
        }
    }
}
