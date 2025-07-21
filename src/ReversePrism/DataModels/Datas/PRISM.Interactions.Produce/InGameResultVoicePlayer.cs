using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstVoiceModel                          ModelClassType VoiceModel VoiceModel VoiceModel Pointer
    // 018 SecondVoiceModel                         ModelClassType VoiceModel VoiceModel VoiceModel Pointer
    // 020 VoicePatternNum                          ModelPrimitiveType int int int Int32
    // 028 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class InGameResultVoicePlayer : DataModel
    {
        public VoiceModel?                              FirstVoiceModel                         { get; set; }
        public VoiceModel?                              SecondVoiceModel                        { get; set; }
        public int                                      VoicePatternNum                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static InGameResultVoicePlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultVoicePlayer() { Pointer= p0 };

            value.FirstVoiceModel                           = GetObject<VoiceModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.VoiceModel.FromPointer); // 0x10 FirstVoiceModel             ( ModelClassType VoiceModel VoiceModel VoiceModel Pointer )
            value.SecondVoiceModel                          = GetObject<VoiceModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.VoiceModel.FromPointer); // 0x18 SecondVoiceModel            ( ModelClassType VoiceModel VoiceModel VoiceModel Pointer )
            value.VoicePatternNum                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 VoicePatternNum             ( ModelPrimitiveType int int int Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x28 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x30 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
