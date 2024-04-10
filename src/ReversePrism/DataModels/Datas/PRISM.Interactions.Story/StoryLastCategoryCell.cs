using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 SubTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MainTitle                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 UnreadBadge                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 FavoriteToggle                           000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 058 StoryRewardItemIconPrefab                00018659B260 ModelClassType StoryRewardItemIcon StoryRewardItemIcon StoryRewardItemIcon Pointer
    // 060 RewardItemIconPos                        0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 068 LockObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 LockText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

        public static StoryLastCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLastCategoryCell() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9CCAF0 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466B9CCB10 0x28 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SubTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9CCB30 0x30 SubTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MainTitle                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9CCB50 0x38 MainTitle                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9CCB70 0x40 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9CCB90 0x48 UnreadBadge                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B9CCBB0 0x50 FavoriteToggle              ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StoryRewardItemIconPrefab                 = GetObject<StoryRewardItemIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.StoryRewardItemIcon.FromPointer); // 02466B9CCBD0 0x58 StoryRewardItemIconPrefab   ( 00018659B260 ModelClassType StoryRewardItemIcon StoryRewardItemIcon StoryRewardItemIcon Pointer )
            value.RewardItemIconPos                         = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 02466B9CCBF0 0x60 RewardItemIconPos           ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9CCC10 0x68 LockObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9CCC30 0x70 LockText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
