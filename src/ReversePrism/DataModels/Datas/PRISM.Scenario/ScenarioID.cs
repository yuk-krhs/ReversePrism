using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001867095C0 ModelEnumType ScenarioType ScenarioType ScenarioType Int32
    // 018 Id_center                                000186671910 ModelPrimitiveType string string string String
    // 020 Id_tail                                  000186671910 ModelPrimitiveType string string string String
    public partial class ScenarioID
    {
        public ScenarioType                             Type                                    { get; set; }
        public string                                   Id_center                               { get; set; }
        public string                                   Id_tail                                 { get; set; }

        public static ScenarioID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioID();

            value.Type                                      = (ScenarioType)GetInt32(new IntPtr(p + 0x010)); // 027006F3C820 0x10 Type                        ( 0001867095C0 ModelEnumType ScenarioType ScenarioType ScenarioType Int32 )
            value.Id_center                                 = GetString(new IntPtr(p + 0x018)); // 027006F3C840 0x18 Id_center                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Id_tail                                   = GetString(new IntPtr(p + 0x020)); // 027006F3C860 0x20 Id_tail                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
