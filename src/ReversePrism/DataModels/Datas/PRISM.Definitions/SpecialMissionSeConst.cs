using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 StepComplete                             SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 AllStepComplete                          ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class SpecialMissionSeConst : DataModel
    {
        public SoundKey                                 AllStepComplete                         { get; set; }

        public static SpecialMissionSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionSeConst() { Pointer= p0 };

            value.AllStepComplete                           = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 AllStepComplete             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
