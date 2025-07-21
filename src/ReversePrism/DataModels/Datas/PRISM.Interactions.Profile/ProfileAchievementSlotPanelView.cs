using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievementIcon                          ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer
    // 028 SelectFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 030 AchievementName                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GetCondtionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 InformationRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 048 EmptyText                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 058 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 onClicked                                Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProfileAchievementSlotPanelView : DataModel
    {
        public AchievementIcon?                         AchievementIcon                         { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public UITextMeshProUGUI?                       AchievementName                         { get; set; }
        public UITextMeshProUGUI?                       GetCondtionText                         { get; set; }
        public GameObject?                              InformationRoot                         { get; set; }
        public GameObject?                              EmptyText                               { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ProfileAchievementSlotPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSlotPanelView() { Pointer= p0 };

            value.AchievementIcon                           = GetObject<AchievementIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIcon.FromPointer); // 0x20 AchievementIcon             ( ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 SelectFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 AchievementName             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetCondtionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 GetCondtionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InformationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 InformationRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 EmptyText                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
