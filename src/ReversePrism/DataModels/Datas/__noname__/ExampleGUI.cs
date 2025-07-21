using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NumberOfButtons                          ModelPrimitiveType int int int Int32
    // 024 IsEnabled                                ModelPrimitiveType bool bool bool Bool
    // 025 ShowPopUp                                ModelPrimitiveType bool bool bool Bool
    // 028 TxtSetEnabled                            ModelPrimitiveType string string string String
    // 030 TxtManualLaunch                          ModelPrimitiveType string string string String
    // 038 TxtSetOfflineMode                        ModelPrimitiveType string string string String
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

            value.NumberOfButtons                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 NumberOfButtons             ( ModelPrimitiveType int int int Int32 )
            value.IsEnabled                                 = GetBool(new IntPtr(p + 0x024)); // 0x24 IsEnabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPopUp                                 = GetBool(new IntPtr(p + 0x025)); // 0x25 ShowPopUp                   ( ModelPrimitiveType bool bool bool Bool )
            value.TxtSetEnabled                             = GetString(new IntPtr(p + 0x028)); // 0x28 TxtSetEnabled               ( ModelPrimitiveType string string string String )
            value.TxtManualLaunch                           = GetString(new IntPtr(p + 0x030)); // 0x30 TxtManualLaunch             ( ModelPrimitiveType string string string String )
            value.TxtSetOfflineMode                         = GetString(new IntPtr(p + 0x038)); // 0x38 TxtSetOfflineMode           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
