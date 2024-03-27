using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitLogoImage                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 UnitImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 ArrowImages                              000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer
    // 038 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class ChallengeTourUnitView
    {
        public Image?                                   UnitLogoImage                           { get; set; }
        public Image?                                   UnitImage                               { get; set; }
        public List<Image>?                             ArrowImages                             { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static ChallengeTourUnitView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitView();

            value.UnitLogoImage                             = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DA1D1258 0x20 UnitLogoImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.UnitImage                                 = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DA1D1278 0x28 UnitImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ArrowImages                               = GetObjectList<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DA1D1298 0x30 ArrowImages                 ( 000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0270DA1D12B8 0x38 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
