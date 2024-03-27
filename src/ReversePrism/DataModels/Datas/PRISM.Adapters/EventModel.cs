using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioID                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 020 Summary                                  000186672F10 ModelPrimitiveType string string string String
    // 028 Read                                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 029 IsAdvPlayable                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class EventModel
    {
        public ScenarioID?                              ScenarioID                              { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Summary                                 { get; set; }
        public bool                                     Read                                    { get; set; }
        public bool                                     IsAdvPlayable                           { get; set; }

        public static EventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventModel();

            value.ScenarioID                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0270D5F2D258 0x10 ScenarioID                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0270D5F2D278 0x18 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 0270D5F2D298 0x20 Summary                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Read                                      = GetBool(new IntPtr(p + 0x028)); // 0270D5F2D2B8 0x28 Read                        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsAdvPlayable                             = GetBool(new IntPtr(p + 0x029)); // 0270D5F2D2D8 0x29 IsAdvPlayable               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
