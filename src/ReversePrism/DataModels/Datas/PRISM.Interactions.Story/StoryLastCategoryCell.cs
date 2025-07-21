using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 030 SubTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MainTitle                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    // 048 UnreadBadge                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 FavoriteToggle                           ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 058 StoryRewardItemIconPrefab                ModelClassType StoryRewardItemIcon StoryRewardItemIcon StoryRewardItemIcon Pointer
    // 060 RewardItemIconPos                        ModelClassType Transform Transform Transform Pointer
    // 068 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 070 LockText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 rewardIconPool                           ObjectPool`1<StoryRewardItemIcon> IL2CPP_TYPE_GENERICINST
    // 080 ActiveRewardIconList                     ModelClassListType List`1<StoryRewardItemIcon> List`1<StoryRewardItemIcon> List<StoryRewardItemIcon> Pointer
    public partial class StoryLastCategoryCell : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UITextMeshProUGUI?                       SubTitle                                { get; set; }
        public UITextMeshProUGUI?                       MainTitle                               { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public ToggleButton?                            FavoriteToggle                          { get; set; }
        public StoryRewardItemIcon?                     StoryRewardItemIconPrefab               { get; set; }
        public Transform?                               RewardItemIconPos                       { get; set; }
        public GameObject?                              LockObject                              { get; set; }
        public UITextMeshProUGUI?                       LockText                                { get; set; }
        public List<StoryRewardItemIcon>?               ActiveRewardIconList                    { get; set; }

        public static StoryLastCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLastCategoryCell() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SubTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 SubTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MainTitle                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MainTitle                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 UnreadBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x50 FavoriteToggle              ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StoryRewardItemIconPrefab                 = GetObject<StoryRewardItemIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.StoryRewardItemIcon.FromPointer); // 0x58 StoryRewardItemIconPrefab   ( ModelClassType StoryRewardItemIcon StoryRewardItemIcon StoryRewardItemIcon Pointer )
            value.RewardItemIconPos                         = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0x60 RewardItemIconPos           ( ModelClassType Transform Transform Transform Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 LockText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActiveRewardIconList                      = GetObjectList<StoryRewardItemIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.StoryRewardItemIcon.FromPointer); // 0x80 ActiveRewardIconList        ( ModelClassListType List`1<StoryRewardItemIcon> List`1<StoryRewardItemIcon> List<StoryRewardItemIcon> Pointer )

            return value;
        }
    }
}
