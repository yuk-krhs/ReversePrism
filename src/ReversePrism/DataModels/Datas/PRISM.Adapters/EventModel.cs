using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioID                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Summary                                  ModelPrimitiveType string string string String
    // 028 Read                                     ModelPrimitiveType bool bool bool Bool
    // 029 IsAdvPlayable                            ModelPrimitiveType bool bool bool Bool
    public partial class EventModel : DataModel
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
            var value   = new EventModel() { Pointer= p0 };

            value.ScenarioID                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x10 ScenarioID                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Summary                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Summary                     ( ModelPrimitiveType string string string String )
            value.Read                                      = GetBool(new IntPtr(p + 0x028)); // 0x28 Read                        ( ModelPrimitiveType bool bool bool Bool )
            value.IsAdvPlayable                             = GetBool(new IntPtr(p + 0x029)); // 0x29 IsAdvPlayable               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
