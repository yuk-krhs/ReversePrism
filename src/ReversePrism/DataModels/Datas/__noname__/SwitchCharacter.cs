using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitIdols                                000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 018 AnimationName                            000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class SwitchCharacter
    {
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public List<string>?                            AnimationName                           { get; set; }

        public static SwitchCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchCharacter();

            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D4D9E440 0x10 UnitIdols                   ( 000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.AnimationName                             = GetStringList(new IntPtr(p + 0x018)); // 0270D4D9E460 0x18 AnimationName               ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
