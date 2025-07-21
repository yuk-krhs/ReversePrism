using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniNamePlate                             ModelClassType Animator Animator Animator Pointer
    // 028 TxtNickName                              ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 TxtName                                  ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 038 GoNew                                    ModelClassType GameObject GameObject GameObject Pointer
    // 040 PieceItem                                ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 PieceAmountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtPieceDetail                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 RainbowItem                              ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 PIdolsRarity                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 GashaSign                                ModelClassType GashaSign GashaSign GashaSign Pointer
    // 070 IsPlaySE                                 ModelPrimitiveType bool bool bool Bool
    public partial class GashaNamePlateP : DataModel
    {
        public Animator?                                AniNamePlate                            { get; set; }
        public List<UITextMeshProUGUI>?                 TxtNickName                             { get; set; }
        public List<UITextMeshProUGUI>?                 TxtName                                 { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public RewardItem?                              PieceItem                               { get; set; }
        public UITextMeshProUGUI?                       PieceAmountText                         { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetail                          { get; set; }
        public RewardItem?                              RainbowItem                             { get; set; }
        public List<GameObject>?                        PIdolsRarity                            { get; set; }
        public GashaSign?                               GashaSign                               { get; set; }
        public bool                                     IsPlaySE                                { get; set; }

        public static GashaNamePlateP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNamePlateP() { Pointer= p0 };

            value.AniNamePlate                              = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 AniNamePlate                ( ModelClassType Animator Animator Animator Pointer )
            value.TxtNickName                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtNickName                 ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TxtName                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtName                     ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoNew                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceItem                                 = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 0x40 PieceItem                   ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceAmountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 PieceAmountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtPieceDetail              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RainbowItem                               = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 0x58 RainbowItem                 ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PIdolsRarity                              = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 PIdolsRarity                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.GashaSign                                 = GetObject<GashaSign>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaSign.FromPointer); // 0x68 GashaSign                   ( ModelClassType GashaSign GashaSign GashaSign Pointer )
            value.IsPlaySE                                  = GetBool(new IntPtr(p + 0x070)); // 0x70 IsPlaySE                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
