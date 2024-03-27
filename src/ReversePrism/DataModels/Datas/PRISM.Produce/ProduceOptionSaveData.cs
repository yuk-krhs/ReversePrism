using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommuSkipMode                            000186601E60 ModelEnumType CommuSkipModeEnum CommuSkipModeEnum CommuSkipModeEnum Int32
    // 024 IsSkipIdolSkillCutIn                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 IsSkipConfirmView                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 026 IsNotStopAutoMode                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceOptionSaveData
    {
        public CommuSkipModeEnum                        CommuSkipMode                           { get; set; }
        public bool                                     IsSkipIdolSkillCutIn                    { get; set; }
        public bool                                     IsSkipConfirmView                       { get; set; }
        public bool                                     IsNotStopAutoMode                       { get; set; }

        public static ProduceOptionSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceOptionSaveData();

            value.CommuSkipMode                             = (CommuSkipModeEnum)GetInt32(new IntPtr(p + 0x020)); // 027003A7C7D8 0x20 CommuSkipMode               ( 000186601E60 ModelEnumType CommuSkipModeEnum CommuSkipModeEnum CommuSkipModeEnum Int32 )
            value.IsSkipIdolSkillCutIn                      = GetBool(new IntPtr(p + 0x024)); // 027003A7C7F8 0x24 IsSkipIdolSkillCutIn        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsSkipConfirmView                         = GetBool(new IntPtr(p + 0x025)); // 027003A7C818 0x25 IsSkipConfirmView           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNotStopAutoMode                         = GetBool(new IntPtr(p + 0x026)); // 027003A7C838 0x26 IsNotStopAutoMode           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
