using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActiveRootObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 028 RewardItems                              ModelClassListType MissionGaugeRewardItem[] MissionGaugeRewardItem[] List<MissionGaugeRewardItem> Pointer
    // 030 CurrentPointText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 MissionGaugeImg                          ModelClassType Image Image Image Pointer
    // 040 AllGetButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 AllGetButtonNormalObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 050 AllGetButtonLockObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStamp                               ModelClassType GameObject GameObject GameObject Pointer
    // 060 PIdolDetailPopupCaller                   ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 068 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 070 OnClickAllGetButton                      ModelClassType Action Action Action Pointer
    // 078 Model                                    ModelClassType MissionListGaugeViewModel MissionListGaugeViewModel MissionListGaugeViewModel Pointer
    public partial class MissionListGaugeView : DataModel
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
            var value   = new MissionListGaugeView() { Pointer= p0 };

            value.ActiveRootObject                          = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ActiveRootObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardItems                               = GetObjectList<MissionGaugeRewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionGaugeRewardItem.FromPointer); // 0x28 RewardItems                 ( ModelClassListType MissionGaugeRewardItem[] MissionGaugeRewardItem[] List<MissionGaugeRewardItem> Pointer )
            value.CurrentPointText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 CurrentPointText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MissionGaugeImg                           = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 MissionGaugeImg             ( ModelClassType Image Image Image Pointer )
            value.AllGetButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 AllGetButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AllGetButtonNormalObject                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 AllGetButtonNormalObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AllGetButtonLockObject                    = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 AllGetButtonLockObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStamp                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ClearStamp                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0x60 PIdolDetailPopupCaller      ( ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0x68 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.OnClickAllGetButton                       = GetObject<Action>(new IntPtr(p + 0x070), ReversePrism.DataModels.Action.FromPointer); // 0x70 OnClickAllGetButton         ( ModelClassType Action Action Action Pointer )
            value.Model                                     = GetObject<MissionListGaugeViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.MissionListGaugeViewModel.FromPointer); // 0x78 Model                       ( ModelClassType MissionListGaugeViewModel MissionListGaugeViewModel MissionListGaugeViewModel Pointer )

            return value;
        }
    }
}
