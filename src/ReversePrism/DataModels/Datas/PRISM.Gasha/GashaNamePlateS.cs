using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniNamePlate                             ModelClassType Animator Animator Animator Pointer
    // 028 ConditionName                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 TxtNickName                              ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 TxtName                                  ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 040 GoNew                                    ModelClassType GameObject GameObject GameObject Pointer
    // 048 PieceItem                                ModelClassType RewardItem RewardItem RewardItem Pointer
    // 050 PieceAmountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtPieceDetail                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RainbowItem                              ModelClassType RewardItem RewardItem RewardItem Pointer
    // 068 GashaSign                                ModelClassType GashaSign GashaSign GashaSign Pointer
    public partial class GashaNamePlateS : DataModel
    {
        public Animator?                                AniNamePlate                            { get; set; }
        public List<string>?                            ConditionName                           { get; set; }
        public List<UITextMeshProUGUI>?                 TxtNickName                             { get; set; }
        public List<UITextMeshProUGUI>?                 TxtName                                 { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public RewardItem?                              PieceItem                               { get; set; }
        public UITextMeshProUGUI?                       PieceAmountText                         { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }
        public RewardItem?                              RainbowItem                             { get; set; }
        public GashaSign?                               GashaSign                               { get; set; }

        public static GashaNamePlateS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNamePlateS() { Pointer= p0 };

            value.AniNamePlate                              = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 AniNamePlate                ( ModelClassType Animator Animator Animator Pointer )
            value.ConditionName                             = GetStringList(new IntPtr(p + 0x028)); // 0x28 ConditionName               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TxtNickName                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtNickName                 ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtName                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtName                     ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoNew                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceItem                                 = GetObject<RewardItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardItem.FromPointer); // 0x48 PieceItem                   ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceAmountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 PieceAmountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtPieceDetail              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RainbowItem                               = GetObject<RewardItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.RewardItem.FromPointer); // 0x60 RainbowItem                 ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.GashaSign                                 = GetObject<GashaSign>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaSign.FromPointer); // 0x68 GashaSign                   ( ModelClassType GashaSign GashaSign GashaSign Pointer )

            return value;
        }
    }
}
