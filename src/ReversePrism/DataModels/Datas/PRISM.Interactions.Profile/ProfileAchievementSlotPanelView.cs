using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievementIcon                          000186675550 ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer
    // 028 SelectFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 AchievementName                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GetCondtionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 InformationRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 EmptyText                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.AchievementIcon                           = GetObject<AchievementIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIcon.FromPointer); // 02466B7878A0 0x20 AchievementIcon             ( 000186675550 ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B7878C0 0x28 SelectFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B7878E0 0x30 AchievementName             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetCondtionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B787900 0x38 GetCondtionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InformationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B787920 0x40 InformationRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B787940 0x48 EmptyText                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466B787960 0x50 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B787980 0x58 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
