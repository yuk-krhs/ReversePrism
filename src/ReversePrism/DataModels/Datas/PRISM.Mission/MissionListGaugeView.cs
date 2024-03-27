using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActiveRootObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 RewardItems                              000185B93CB0 ModelClassListType MissionGaugeRewardItem[] MissionGaugeRewardItem[] List<MissionGaugeRewardItem> Pointer
    // 030 CurrentPointText                         0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 MissionGaugeImg                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 040 AllGetButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 AllGetButtonNormalObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 AllGetButtonLockObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStamp                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 068 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 070 OnClickAllGetButton                      000186679A00 ModelClassType Action Action Action Pointer
    // 078 Model                                    000186625340 ModelClassType MissionListGaugeViewModel MissionListGaugeViewModel MissionListGaugeViewModel Pointer
    public partial class MissionListGaugeView
    {
        public GameObject?                              ActiveRootObject                        { get; set; }
        public List<MissionGaugeRewardItem>?            RewardItems                             { get; set; }
        public TextMeshProUGUI?                         CurrentPointText                        { get; set; }
        public Image?                                   MissionGaugeImg                         { get; set; }
        public UIButton?                                AllGetButton                            { get; set; }
        public GameObject?                              AllGetButtonNormalObject                { get; set; }
        public GameObject?                              AllGetButtonLockObject                  { get; set; }
        public GameObject?                              ClearStamp                              { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public Action?                                  OnClickAllGetButton                     { get; set; }
        public MissionListGaugeViewModel?               Model                                   { get; set; }

        public static MissionListGaugeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListGaugeView();

            value.ActiveRootObject                          = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5556B08 0x20 ActiveRootObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardItems                               = GetObjectList<MissionGaugeRewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionGaugeRewardItem.FromPointer); // 0270D5556B28 0x28 RewardItems                 ( 000185B93CB0 ModelClassListType MissionGaugeRewardItem[] MissionGaugeRewardItem[] List<MissionGaugeRewardItem> Pointer )
            value.CurrentPointText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5556B48 0x30 CurrentPointText            ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MissionGaugeImg                           = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0270D5556B68 0x38 MissionGaugeImg             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.AllGetButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5556B88 0x40 AllGetButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AllGetButtonNormalObject                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5556BA8 0x48 AllGetButtonNormalObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AllGetButtonLockObject                    = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5556BC8 0x50 AllGetButtonLockObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStamp                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5556BE8 0x58 ClearStamp                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5556C08 0x60 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270D5556C28 0x68 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.OnClickAllGetButton                       = GetObject<Action>(new IntPtr(p + 0x070), ReversePrism.DataModels.Action.FromPointer); // 0270D5556C48 0x70 OnClickAllGetButton         ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.Model                                     = GetObject<MissionListGaugeViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.MissionListGaugeViewModel.FromPointer); // 0270D5556C68 0x78 Model                       ( 000186625340 ModelClassType MissionListGaugeViewModel MissionListGaugeViewModel MissionListGaugeViewModel Pointer )

            return value;
        }
    }
}
