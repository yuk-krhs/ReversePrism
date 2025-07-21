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
    // 020 IsSelect                                 ModelPrimitiveType bool bool bool Bool
    // 028 AchievementIcon                          ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer
    // 030 SelectFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 NormalFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 040 AchievementName                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GetCondtionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 InformationRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 058 EmptyText                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class AchievementDetailView : DataModel
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
            var value   = new AchievementDetailView() { Pointer= p0 };

            value.IsSelect                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSelect                    ( ModelPrimitiveType bool bool bool Bool )
            value.AchievementIcon                           = GetObject<AchievementIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AchievementIconView.FromPointer); // 0x28 AchievementIcon             ( ModelClassType AchievementIconView AchievementIconView AchievementIconView Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SelectFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalFrame                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NormalFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 AchievementName             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetCondtionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 GetCondtionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InformationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 InformationRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 EmptyText                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
