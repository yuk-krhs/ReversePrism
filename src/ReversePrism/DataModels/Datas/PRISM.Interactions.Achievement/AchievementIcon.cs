using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 AchievementImage                         ModelClassType Image Image Image Pointer
    // 030 NonSettingsObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 038 SelectPulsIcon                           ModelClassType GameObject GameObject GameObject Pointer
    // 040 NewBadgeIcon                             ModelClassType GameObject GameObject GameObject Pointer
    // 048 SelectedCursor                           ModelClassType GameObject GameObject GameObject Pointer
    // 050 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onLongPress                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 AchievementId                            ModelPrimitiveType int int int Int32
    // 068 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class AchievementIcon : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public Image?                                   AchievementImage                        { get; set; }
        public GameObject?                              NonSettingsObject                       { get; set; }
        public GameObject?                              SelectPulsIcon                          { get; set; }
        public GameObject?                              NewBadgeIcon                            { get; set; }
        public GameObject?                              SelectedCursor                          { get; set; }
        public int                                      AchievementId                           { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static AchievementIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementIcon() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AchievementImage                          = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 AchievementImage            ( ModelClassType Image Image Image Pointer )
            value.NonSettingsObject                         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 NonSettingsObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectPulsIcon                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SelectPulsIcon              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NewBadgeIcon                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NewBadgeIcon                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedCursor                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SelectedCursor              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementId                             = GetInt32(new IntPtr(p + 0x060)); // 0x60 AchievementId               ( ModelPrimitiveType int int int Int32 )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x068)); // 0x68 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
