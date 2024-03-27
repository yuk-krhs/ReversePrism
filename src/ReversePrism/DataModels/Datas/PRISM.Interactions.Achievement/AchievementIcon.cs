using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 AchievementImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 NonSettingsObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SelectPulsIcon                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 NewBadgeIcon                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 SelectedCursor                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onLongPress                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 AchievementId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class AchievementIcon
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
            var value   = new AchievementIcon();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB7419B8 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AchievementImage                          = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DB7419D8 0x28 AchievementImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NonSettingsObject                         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB7419F8 0x30 NonSettingsObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectPulsIcon                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB741A18 0x38 SelectPulsIcon              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NewBadgeIcon                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB741A38 0x40 NewBadgeIcon                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedCursor                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB741A58 0x48 SelectedCursor              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AchievementId                             = GetInt32(new IntPtr(p + 0x060)); // 0270DB741AB8 0x60 AchievementId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x068)); // 0270DB741AD8 0x68 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
