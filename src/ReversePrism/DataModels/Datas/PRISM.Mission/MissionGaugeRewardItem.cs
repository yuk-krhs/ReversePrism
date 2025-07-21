using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 PointText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 BallonImage                              ModelClassType Image Image Image Pointer
    // 038 SelectFrameObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 040 LightFrameObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 BadgeObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 CheckMarkObject                          ModelClassType GameObject GameObject GameObject Pointer
    public partial class MissionGaugeRewardItem : DataModel
    {
        public RewardItemIcon?                          RewardItem                              { get; set; }
        public TextMeshProUGUI?                         PointText                               { get; set; }
        public Image?                                   BallonImage                             { get; set; }
        public GameObject?                              SelectFrameObject                       { get; set; }
        public GameObject?                              LightFrameObject                        { get; set; }
        public GameObject?                              BadgeObject                             { get; set; }
        public GameObject?                              CheckMarkObject                         { get; set; }

        public static MissionGaugeRewardItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeRewardItem() { Pointer= p0 };

            value.RewardItem                                = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 RewardItem                  ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.PointText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 PointText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.BallonImage                               = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 BallonImage                 ( ModelClassType Image Image Image Pointer )
            value.SelectFrameObject                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SelectFrameObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LightFrameObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 LightFrameObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeObject                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 BadgeObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CheckMarkObject                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 CheckMarkObject             ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
