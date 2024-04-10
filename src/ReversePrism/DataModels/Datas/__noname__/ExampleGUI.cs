using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NumberOfButtons                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IsEnabled                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 ShowPopUp                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 TxtSetEnabled                            000186671910 ModelPrimitiveType string string string String
    // 030 TxtManualLaunch                          000186671910 ModelPrimitiveType string string string String
    // 038 TxtSetOfflineMode                        000186671910 ModelPrimitiveType string string string String
    public partial class ExampleGUI : DataModel
    {
        public int                                      NumberOfButtons                         { get; set; }
        public bool                                     IsEnabled                               { get; set; }
        public bool                                     ShowPopUp                               { get; set; }
        public string                                   TxtSetEnabled                           { get; set; }
        public string                                   TxtManualLaunch                         { get; set; }
        public string                                   TxtSetOfflineMode                       { get; set; }

        public static ExampleGUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExampleGUI() { Pointer= p0 };

            value.NumberOfButtons                           = GetInt32(new IntPtr(p + 0x020)); // 02466BF84FA0 0x20 NumberOfButtons             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsEnabled                                 = GetBool(new IntPtr(p + 0x024)); // 02466BF84FC0 0x24 IsEnabled                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShowPopUp                                 = GetBool(new IntPtr(p + 0x025)); // 02466BF84FE0 0x25 ShowPopUp                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TxtSetEnabled                             = GetString(new IntPtr(p + 0x028)); // 02466BF85000 0x28 TxtSetEnabled               ( 000186671910 ModelPrimitiveType string string string String )
            value.TxtManualLaunch                           = GetString(new IntPtr(p + 0x030)); // 02466BF85020 0x30 TxtManualLaunch             ( 000186671910 ModelPrimitiveType string string string String )
            value.TxtSetOfflineMode                         = GetString(new IntPtr(p + 0x038)); // 02466BF85040 0x38 TxtSetOfflineMode           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
