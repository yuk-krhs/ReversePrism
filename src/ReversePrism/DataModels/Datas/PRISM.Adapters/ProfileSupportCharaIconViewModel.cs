using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IconData                                 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 018 IsSelectChara                            ModelPrimitiveType bool bool bool Bool
    public partial class ProfileSupportCharaIconViewModel : DataModel
    {
        public SCharaIcon?                              IconData                                { get; set; }
        public bool                                     IsSelectChara                           { get; set; }

        public static ProfileSupportCharaIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaIconViewModel() { Pointer= p0 };

            value.IconData                                  = GetObject<SCharaIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x10 IconData                    ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.IsSelectChara                             = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSelectChara               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
