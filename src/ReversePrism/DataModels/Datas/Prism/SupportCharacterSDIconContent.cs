using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportCharaObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 028 SupportCharaCooperationObject            ModelClassType GameObject GameObject GameObject Pointer
    // 030 SupportCharaCooperationIconObject        ModelClassType GameObject GameObject GameObject Pointer
    // 038 SupportCharaImage                        ModelClassType UIImage UIImage UIImage Pointer
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

            value.SupportCharaObject                        = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 SupportCharaObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationObject             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 SupportCharaCooperationObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaCooperationIconObject         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SupportCharaCooperationIconObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharaImage                         = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 SupportCharaImage           ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
