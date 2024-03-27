using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaGaugeImage                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 StaminaGaugeAfterImage                   0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 StaminaFullGaugeImage                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 IncreaseColorImage                       0001866CCDB0 ModelClassType Image Image Image Pointer
    // 040 DecreaseColorImage                       0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class StaminaRecoveryGaugeView
    {
        public Image?                                   StaminaGaugeImage                       { get; set; }
        public Image?                                   StaminaGaugeAfterImage                  { get; set; }
        public Image?                                   StaminaFullGaugeImage                   { get; set; }
        public Image?                                   IncreaseColorImage                      { get; set; }
        public Image?                                   DecreaseColorImage                      { get; set; }

        public static StaminaRecoveryGaugeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryGaugeView();

            value.StaminaGaugeImage                         = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270D560DCA8 0x20 StaminaGaugeImage           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.StaminaGaugeAfterImage                    = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270D560DCC8 0x28 StaminaGaugeAfterImage      ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.StaminaFullGaugeImage                     = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270D560DCE8 0x30 StaminaFullGaugeImage       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.IncreaseColorImage                        = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0270D560DD08 0x38 IncreaseColorImage          ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.DecreaseColorImage                        = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0270D560DD28 0x40 DecreaseColorImage          ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
