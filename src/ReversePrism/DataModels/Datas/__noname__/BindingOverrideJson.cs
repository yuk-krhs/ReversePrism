using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Interactions                             0001866722E0 ModelPrimitiveType string string string String
    // 030 Processors                               0001866722E0 ModelPrimitiveType string string string String
    public partial class BindingOverrideJson
    {
        public string                                   Action                                  { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   Path                                    { get; set; }
        public string                                   Interactions                            { get; set; }
        public string                                   Processors                              { get; set; }

        public static BindingOverrideJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingOverrideJson();

            value.Action                                    = GetString(new IntPtr(p + 0x010)); // 0270D764D608 0x10 Action                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0270D764D628 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 0270D764D648 0x20 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x028)); // 0270D764D668 0x28 Interactions                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x030)); // 0270D764D688 0x30 Processors                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
