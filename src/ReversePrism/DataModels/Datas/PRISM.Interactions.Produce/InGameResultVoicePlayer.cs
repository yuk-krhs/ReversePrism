using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstVoiceModel                          00018660A6A0 ModelClassType VoiceModel VoiceModel VoiceModel Pointer
    // 018 SecondVoiceModel                         00018660A6A0 ModelClassType VoiceModel VoiceModel VoiceModel Pointer
    // 020 VoicePatternNum                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class InGameResultVoicePlayer
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
            var value   = new InGameResultVoicePlayer();

            value.FirstVoiceModel                           = GetObject<VoiceModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.VoiceModel.FromPointer); // 0270DA1D5860 0x10 FirstVoiceModel             ( 00018660A6A0 ModelClassType VoiceModel VoiceModel VoiceModel Pointer )
            value.SecondVoiceModel                          = GetObject<VoiceModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.VoiceModel.FromPointer); // 0270DA1D5880 0x18 SecondVoiceModel            ( 00018660A6A0 ModelClassType VoiceModel VoiceModel VoiceModel Pointer )
            value.VoicePatternNum                           = GetInt32(new IntPtr(p + 0x020)); // 0270DA1D58A0 0x20 VoicePatternNum             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270DA1D58C0 0x28 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270DA1D58E0 0x30 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
