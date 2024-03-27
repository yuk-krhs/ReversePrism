using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportCharaObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 SupportCharaCooperationObject            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 SupportCharaCooperationIconObject        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SupportCharaImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class SupportCharacterSDIconContent
    {
        public GameObject?                              SupportCharaObject                      { get; set; }
        public GameObject?                              SupportCharaCooperationObject           { get; set; }
        public GameObject?                              SupportCharaCooperationIconObject       { get; set; }
        public UIImage?                                 SupportCharaImage                       { get; set; }

        public static SupportCharacterSDIconContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterSDIconContent();

            value.SupportCharaObject                        = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C08A8 0x20 SupportCharaObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationObject             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C08C8 0x28 SupportCharaCooperationObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationIconObject         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C08E8 0x30 SupportCharaCooperationIconObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaImage                         = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0C0908 0x38 SupportCharaImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
