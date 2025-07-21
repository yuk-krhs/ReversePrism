using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GaugeAnimationSpeed                      float IL2CPP_TYPE_R4
    // 020 RootObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 RewardItemIcons                          ModelClassListType MissionGaugeRewardItemIcon[] MissionGaugeRewardItemIcon[] List<MissionGaugeRewardItemIcon> Pointer
    // 030 CurrentPointText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 GaugeImage                               ModelClassType Image Image Image Pointer
    // 040 AllGaugeReceiveButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 048 ClearStampObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 050 ListView                                 ModelClassType MissionListView MissionListView MissionListView Pointer
    // 058 ReceiveLimitedRootObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 060 ReceiveLimitedText                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 AllReceiveButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 070 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class MissionDailyContentPanelView : DataModel
    {
        public GameObject?                              RootObject                              { get; set; }
        public List<MissionGaugeRewardItemIcon>?        RewardItemIcons                         { get; set; }
        public TextMeshProUGUI?                         CurrentPointText                        { get; set; }
        public Image?                                   GaugeImage                              { get; set; }
        public UIButton?                                AllGaugeReceiveButton                   { get; set; }
        public GameObject?                              ClearStampObject                        { get; set; }
        public MissionListView?                         ListView                                { get; set; }
        public GameObject?                              ReceiveLimitedRootObject                { get; set; }
        public TextMeshProUGUI?                         ReceiveLimitedText                      { get; set; }
        public UIButton?                                AllReceiveButton                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MissionDailyContentPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionDailyContentPanelView() { Pointer= p0 };

            value.RootObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 RootObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardItemIcons                           = GetObjectList<MissionGaugeRewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionGaugeRewardItemIcon.FromPointer); // 0x28 RewardItemIcons             ( ModelClassListType MissionGaugeRewardItemIcon[] MissionGaugeRewardItemIcon[] List<MissionGaugeRewardItemIcon> Pointer )
            value.CurrentPointText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 CurrentPointText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.GaugeImage                                = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 GaugeImage                  ( ModelClassType Image Image Image Pointer )
            value.AllGaugeReceiveButton                     = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 AllGaugeReceiveButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ClearStampObject                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ClearStampObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ListView                                  = GetObject<MissionListView>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionListView.FromPointer); // 0x50 ListView                    ( ModelClassType MissionListView MissionListView MissionListView Pointer )
            value.ReceiveLimitedRootObject                  = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ReceiveLimitedRootObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReceiveLimitedText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x60 ReceiveLimitedText          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.AllReceiveButton                          = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 AllReceiveButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x70 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
