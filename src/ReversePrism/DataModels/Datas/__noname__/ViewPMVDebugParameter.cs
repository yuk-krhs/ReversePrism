using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDebugPMV                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 DebugMv                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 DebugUnit                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 RemovingCSCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 IsSelectFile                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 SelectFileName                           0001866722E0 ModelPrimitiveType string string string String
    // 038 SelectText                               0001866722E0 ModelPrimitiveType string string string String
    public partial class ViewPMVDebugParameter
    {
        public bool                                     IsDebugPMV                              { get; set; }
        public string                                   DebugMv                                 { get; set; }
        public int                                      DebugUnit                               { get; set; }
        public int                                      RemovingCSCount                         { get; set; }
        public bool                                     IsSelectFile                            { get; set; }
        public string                                   SelectFileName                          { get; set; }
        public string                                   SelectText                              { get; set; }

        public static ViewPMVDebugParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewPMVDebugParameter();

            value.IsDebugPMV                                = GetBool(new IntPtr(p + 0x010)); // 0270D594DD58 0x10 IsDebugPMV                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DebugMv                                   = GetString(new IntPtr(p + 0x018)); // 0270D594DD78 0x18 DebugMv                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DebugUnit                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D594DD98 0x20 DebugUnit                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RemovingCSCount                           = GetInt32(new IntPtr(p + 0x024)); // 0270D594DDB8 0x24 RemovingCSCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsSelectFile                              = GetBool(new IntPtr(p + 0x028)); // 0270D594DDD8 0x28 IsSelectFile                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SelectFileName                            = GetString(new IntPtr(p + 0x030)); // 0270D594DDF8 0x30 SelectFileName              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SelectText                                = GetString(new IntPtr(p + 0x038)); // 0270D594DE18 0x38 SelectText                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
