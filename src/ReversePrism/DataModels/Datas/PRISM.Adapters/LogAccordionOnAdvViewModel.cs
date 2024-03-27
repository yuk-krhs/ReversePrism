using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ScenarioTypeID                           0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 020 SpeakerID                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 SpeakerName                              000186671910 ModelPrimitiveType string string string String
    // 030 Dialogue                                 000186671910 ModelPrimitiveType string string string String
    public partial class LogAccordionOnAdvViewModel
    {
        public ScenarioID?                              ScenarioTypeID                          { get; set; }
        public int                                      SpeakerID                               { get; set; }
        public string                                   SpeakerName                             { get; set; }
        public string                                   Dialogue                                { get; set; }

        public static LogAccordionOnAdvViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogAccordionOnAdvViewModel();

            value.ScenarioTypeID                            = GetObject<ScenarioID>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScenarioID.FromPointer); // 0270D6506D00 0x18 ScenarioTypeID              ( 0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.SpeakerID                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D6506D20 0x20 SpeakerID                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpeakerName                               = GetString(new IntPtr(p + 0x028)); // 0270D6506D40 0x28 SpeakerName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Dialogue                                  = GetString(new IntPtr(p + 0x030)); // 0270D6506D60 0x30 Dialogue                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
