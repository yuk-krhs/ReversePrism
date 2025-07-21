using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommuSkipMode                            ModelEnumType CommuSkipModeEnum CommuSkipModeEnum CommuSkipModeEnum Int32
    // 024 IsSkipIdolSkillCutIn                     ModelPrimitiveType bool bool bool Bool
    // 025 IsSkipConfirmView                        ModelPrimitiveType bool bool bool Bool
    // 026 IsNotStopAutoMode                        ModelPrimitiveType bool bool bool Bool
    // 027 IsStopTapIngameContent                   ModelPrimitiveType bool bool bool Bool
    public partial class ProduceOptionSaveData : DataModel
    {
        public CommuSkipModeEnum                        CommuSkipMode                           { get; set; }
        public bool                                     IsSkipIdolSkillCutIn                    { get; set; }
        public bool                                     IsSkipConfirmView                       { get; set; }
        public bool                                     IsNotStopAutoMode                       { get; set; }
        public bool                                     IsStopTapIngameContent                  { get; set; }

        public static ProduceOptionSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceOptionSaveData() { Pointer= p0 };

            value.CommuSkipMode                             = (CommuSkipModeEnum)GetInt32(new IntPtr(p + 0x020)); // 0x20 CommuSkipMode               ( ModelEnumType CommuSkipModeEnum CommuSkipModeEnum CommuSkipModeEnum Int32 )
            value.IsSkipIdolSkillCutIn                      = GetBool(new IntPtr(p + 0x024)); // 0x24 IsSkipIdolSkillCutIn        ( ModelPrimitiveType bool bool bool Bool )
            value.IsSkipConfirmView                         = GetBool(new IntPtr(p + 0x025)); // 0x25 IsSkipConfirmView           ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotStopAutoMode                         = GetBool(new IntPtr(p + 0x026)); // 0x26 IsNotStopAutoMode           ( ModelPrimitiveType bool bool bool Bool )
            value.IsStopTapIngameContent                    = GetBool(new IntPtr(p + 0x027)); // 0x27 IsStopTapIngameContent      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
