using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Interactions                             0001866722E0 ModelPrimitiveType string string string String
    // 030 Processors                               0001866722E0 ModelPrimitiveType string string string String
    // 038 Groups                                   0001866722E0 ModelPrimitiveType string string string String
    // 040 Action                                   0001866722E0 ModelPrimitiveType string string string String
    // 048 IsComposite                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 049 IsPartOfComposite                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class BindingJson
    {
        public string                                   Name                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   Path                                    { get; set; }
        public string                                   Interactions                            { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   Groups                                  { get; set; }
        public string                                   Action                                  { get; set; }
        public bool                                     IsComposite                             { get; set; }
        public bool                                     IsPartOfComposite                       { get; set; }

        public static BindingJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingJson();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D764F610 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0270D764F630 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 0270D764F650 0x20 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x028)); // 0270D764F670 0x28 Interactions                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x030)); // 0270D764F690 0x30 Processors                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Groups                                    = GetString(new IntPtr(p + 0x038)); // 0270D764F6B0 0x38 Groups                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Action                                    = GetString(new IntPtr(p + 0x040)); // 0270D764F6D0 0x40 Action                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsComposite                               = GetBool(new IntPtr(p + 0x048)); // 0270D764F6F0 0x48 IsComposite                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsPartOfComposite                         = GetBool(new IntPtr(p + 0x049)); // 0270D764F710 0x49 IsPartOfComposite           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
