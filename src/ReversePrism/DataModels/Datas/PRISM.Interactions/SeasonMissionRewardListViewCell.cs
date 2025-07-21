using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RewardRootObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 RewardTypeObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 050 IndexLabelImage                          ModelClassType Image Image Image Pointer
    // 058 IndexLabelText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 NormalBackGround                         ModelClassType GameObject GameObject GameObject Pointer
    // 068 SpecialBackGround                        ModelClassType GameObject GameObject GameObject Pointer
    // 070 NormalRewardIcons                        ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer
    // 078 PremiumRewardIcons                       ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer
    // 080 PremiumLockIcon                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 LockText                                 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 090 CloseLayout                              ModelClassType GameObject GameObject GameObject Pointer
    // 098 NormalRewardMargin                       ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 PremiumRewardMargin                      ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 NormalScrollSender                       ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer
    // 0B0 PremiumScrollSender                      ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer
    // 0B8 Scroller                                 ModelClassType Scroller Scroller Scroller Pointer
    public partial class SeasonMissionRewardListViewCell : DataModel
    {
        public GameObject?                              RewardRootObject                        { get; set; }
        public GameObject?                              RewardTypeObject                        { get; set; }
        public Image?                                   IndexLabelImage                         { get; set; }
        public TextMeshProUGUI?                         IndexLabelText                          { get; set; }
        public GameObject?                              NormalBackGround                        { get; set; }
        public GameObject?                              SpecialBackGround                       { get; set; }
        public List<SeasonMissionRewardIcon>?           NormalRewardIcons                       { get; set; }
        public List<SeasonMissionRewardIcon>?           PremiumRewardIcons                      { get; set; }
        public GameObject?                              PremiumLockIcon                         { get; set; }
        public TextMeshProUGUI?                         LockText                                { get; set; }
        public GameObject?                              CloseLayout                             { get; set; }
        public GameObject?                              NormalRewardMargin                      { get; set; }
        public GameObject?                              PremiumRewardMargin                     { get; set; }
        public OnScrollSender?                          NormalScrollSender                      { get; set; }
        public OnScrollSender?                          PremiumScrollSender                     { get; set; }
        public Scroller?                                Scroller                                { get; set; }

        public static SeasonMissionRewardListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRewardListViewCell() { Pointer= p0 };

            value.RewardRootObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 RewardRootObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardTypeObject                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 RewardTypeObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IndexLabelImage                           = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 0x50 IndexLabelImage             ( ModelClassType Image Image Image Pointer )
            value.IndexLabelText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x58 IndexLabelText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NormalBackGround                          = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 NormalBackGround            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackGround                         = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 SpecialBackGround           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalRewardIcons                         = GetObjectList<SeasonMissionRewardIcon>(new IntPtr(p + 0x070), ReversePrism.DataModels.SeasonMissionRewardIcon.FromPointer); // 0x70 NormalRewardIcons           ( ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer )
            value.PremiumRewardIcons                        = GetObjectList<SeasonMissionRewardIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.SeasonMissionRewardIcon.FromPointer); // 0x78 PremiumRewardIcons          ( ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer )
            value.PremiumLockIcon                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 PremiumLockIcon             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x88 LockText                    ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CloseLayout                               = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 CloseLayout                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalRewardMargin                        = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 NormalRewardMargin          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PremiumRewardMargin                       = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 PremiumRewardMargin         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalScrollSender                        = GetObject<OnScrollSender>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.OnScrollSender.FromPointer); // 0xA8 NormalScrollSender          ( ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer )
            value.PremiumScrollSender                       = GetObject<OnScrollSender>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OnScrollSender.FromPointer); // 0xB0 PremiumScrollSender         ( ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Scroller.FromPointer); // 0xB8 Scroller                    ( ModelClassType Scroller Scroller Scroller Pointer )

            return value;
        }
    }
}
