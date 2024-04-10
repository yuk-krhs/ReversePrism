using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RewardRootObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 RewardTypeObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 IndexLabelImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 058 IndexLabelText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 NormalBackGround                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 SpecialBackGround                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 NormalRewardIcons                        000185CA2F38 ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer
    // 078 PremiumRewardIcons                       000185CA2F38 ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer
    // 080 PremiumLockIcon                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 LockText                                 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 090 CloseLayout                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 NormalRewardMargin                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 PremiumRewardMargin                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 NormalScrollSender                       0001866DC710 ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer
    // 0B0 PremiumScrollSender                      0001866DC710 ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer
    // 0B8 Scroller                                 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer
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

            value.RewardRootObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA5C0 0x40 RewardRootObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardTypeObject                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA5E0 0x48 RewardTypeObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IndexLabelImage                           = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 02466BDAA600 0x50 IndexLabelImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.IndexLabelText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BDAA620 0x58 IndexLabelText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NormalBackGround                          = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA640 0x60 NormalBackGround            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackGround                         = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA660 0x68 SpecialBackGround           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalRewardIcons                         = GetObjectList<SeasonMissionRewardIcon>(new IntPtr(p + 0x070), ReversePrism.DataModels.SeasonMissionRewardIcon.FromPointer); // 02466BDAA680 0x70 NormalRewardIcons           ( 000185CA2F38 ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer )
            value.PremiumRewardIcons                        = GetObjectList<SeasonMissionRewardIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.SeasonMissionRewardIcon.FromPointer); // 02466BDAA6A0 0x78 PremiumRewardIcons          ( 000185CA2F38 ModelClassListType SeasonMissionRewardIcon[] SeasonMissionRewardIcon[] List<SeasonMissionRewardIcon> Pointer )
            value.PremiumLockIcon                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA6C0 0x80 PremiumLockIcon             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BDAA6E0 0x88 LockText                    ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CloseLayout                               = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA700 0x90 CloseLayout                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalRewardMargin                        = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA720 0x98 NormalRewardMargin          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PremiumRewardMargin                       = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAA740 0xA0 PremiumRewardMargin         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalScrollSender                        = GetObject<OnScrollSender>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.OnScrollSender.FromPointer); // 02466BDAA760 0xA8 NormalScrollSender          ( 0001866DC710 ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer )
            value.PremiumScrollSender                       = GetObject<OnScrollSender>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OnScrollSender.FromPointer); // 02466BDAA780 0xB0 PremiumScrollSender         ( 0001866DC710 ModelClassType OnScrollSender OnScrollSender OnScrollSender Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Scroller.FromPointer); // 02466BDAA7A0 0xB8 Scroller                    ( 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer )

            return value;
        }
    }
}
