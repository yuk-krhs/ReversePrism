using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MstTextNamePrefix                        string IL2CPP_TYPE_STRING
    // 000 MstTextCondtionPrefix                    string IL2CPP_TYPE_STRING
    // 020 IsSelect                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 AchievementIcon                          000186675B10 ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer
    // 030 SelectFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 NormalFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 AchievementName                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GetCondtionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 InformationRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 EmptyText                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class AchievementDetailView
    {
        public bool                                     IsSelect                                { get; set; }
        public AchievementIconView?                     AchievementIcon                         { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public GameObject?                              NormalFrame                             { get; set; }
        public UITextMeshProUGUI?                       AchievementName                         { get; set; }
        public UITextMeshProUGUI?                       GetCondtionText                         { get; set; }
        public GameObject?                              InformationRoot                         { get; set; }
        public GameObject?                              EmptyText                               { get; set; }

        public static AchievementDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementDetailView();

            value.IsSelect                                  = GetBool(new IntPtr(p + 0x020)); // 0270D4BBDFE8 0x20 IsSelect                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AchievementIcon                           = GetObject<AchievementIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AchievementIconView.FromPointer); // 0270D4BBE008 0x28 AchievementIcon             ( 000186675B10 ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BBE028 0x30 SelectFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalFrame                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BBE048 0x38 NormalFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BBE068 0x40 AchievementName             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetCondtionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BBE088 0x48 GetCondtionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InformationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BBE0A8 0x50 InformationRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BBE0C8 0x58 EmptyText                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
