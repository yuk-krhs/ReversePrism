using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 unitIdWithCharacterIdList                List`1<Tuple`2<int, List`1<int>>> IL2CPP_TYPE_GENERICINST
    // 010 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 018 ChapterTitle                             000186672F10 ModelPrimitiveType string string string String
    // 020 Summary                                  000186672F10 ModelPrimitiveType string string string String
    // 028 ScenarioId                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    public partial class AdvScenarioInfo : DataModel
    {
        public string                                   Title                                   { get; set; }
        public string                                   ChapterTitle                            { get; set; }
        public string                                   Summary                                 { get; set; }
        public ScenarioID?                              ScenarioId                              { get; set; }

        public static AdvScenarioInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScenarioInfo() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 024665E48EA0 0x10 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.ChapterTitle                              = GetString(new IntPtr(p + 0x018)); // 024665E48EC0 0x18 ChapterTitle                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 024665E48EE0 0x20 Summary                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScenarioID.FromPointer); // 024665E48F00 0x28 ScenarioId                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )

            return value;
        }
    }
}
