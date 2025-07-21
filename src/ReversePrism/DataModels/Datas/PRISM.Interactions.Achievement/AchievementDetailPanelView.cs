using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer
    // 028 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 030 SelectFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 NormalFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 040 AchievementName                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GetCondtionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 InformationRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 058 EmptyText                                ModelClassType GameObject GameObject GameObject Pointer
    // 060 AchievementId                            ModelPrimitiveType int int int Int32
    // 068 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onLongPress                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AchievementDetailPanelView : DataModel
    {
        public AchievementIcon?                         Icon                                    { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public GameObject?                              NormalFrame                             { get; set; }
        public UITextMeshProUGUI?                       AchievementName                         { get; set; }
        public UITextMeshProUGUI?                       GetCondtionText                         { get; set; }
        public GameObject?                              InformationRoot                         { get; set; }
        public GameObject?                              EmptyText                               { get; set; }
        public int                                      AchievementId                           { get; set; }

        public static AchievementDetailPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementDetailPanelView() { Pointer= p0 };

            value.Icon                                      = GetObject<AchievementIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIcon.FromPointer); // 0x20 Icon                        ( ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SelectFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalFrame                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NormalFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 AchievementName             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetCondtionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 GetCondtionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InformationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 InformationRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 EmptyText                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementId                             = GetInt32(new IntPtr(p + 0x060)); // 0x60 AchievementId               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
