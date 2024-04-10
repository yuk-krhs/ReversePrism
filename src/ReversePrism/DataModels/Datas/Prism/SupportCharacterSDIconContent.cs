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
    public partial class SupportCharacterSDIconContent : DataModel
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
            var value   = new SupportCharacterSDIconContent() { Pointer= p0 };

            value.SupportCharaObject                        = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466A114398 0x20 SupportCharaObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationObject             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1143B8 0x28 SupportCharaCooperationObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationIconObject         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1143D8 0x30 SupportCharaCooperationIconObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaImage                         = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 02466A1143F8 0x38 SupportCharaImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
