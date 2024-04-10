using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsEnableButton                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 AchievementButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 AchievementImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 SelectButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 SelectPulsIcon                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 NewBadgeObj                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 onClickSubject                           Subject`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 058 onLongPressSubject                       Subject`1<GameObject> IL2CPP_TYPE_GENERICINST
    public partial class AchievementIconView : DataModel
    {
        public bool                                     IsEnableButton                          { get; set; }
        public UIButton?                                AchievementButton                       { get; set; }
        public Image?                                   AchievementImage                        { get; set; }
        public UIButton?                                SelectButton                            { get; set; }
        public GameObject?                              SelectPulsIcon                          { get; set; }
        public GameObject?                              NewBadgeObj                             { get; set; }

        public static AchievementIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementIconView() { Pointer= p0 };

            value.IsEnableButton                            = GetBool(new IntPtr(p + 0x020)); // 024664C20C50 0x20 IsEnableButton              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AchievementButton                         = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 024664C20C70 0x28 AchievementButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AchievementImage                          = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 024664C20C90 0x30 AchievementImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SelectButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024664C20CB0 0x38 SelectButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SelectPulsIcon                            = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024664C20CD0 0x40 SelectPulsIcon              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NewBadgeObj                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024664C20CF0 0x48 NewBadgeObj                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
