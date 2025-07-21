using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDebugPMV                               ModelPrimitiveType bool bool bool Bool
    // 018 DebugMv                                  ModelPrimitiveType string string string String
    // 020 DebugUnit                                ModelPrimitiveType int int int Int32
    // 024 RemovingCSCount                          ModelPrimitiveType int int int Int32
    // 028 IsSelectFile                             ModelPrimitiveType bool bool bool Bool
    // 030 SelectFileName                           ModelPrimitiveType string string string String
    // 038 SelectText                               ModelPrimitiveType string string string String
    public partial class ViewPMVDebugParameter : DataModel
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
            var value   = new ViewPMVDebugParameter() { Pointer= p0 };

            value.IsDebugPMV                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDebugPMV                  ( ModelPrimitiveType bool bool bool Bool )
            value.DebugMv                                   = GetString(new IntPtr(p + 0x018)); // 0x18 DebugMv                     ( ModelPrimitiveType string string string String )
            value.DebugUnit                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 DebugUnit                   ( ModelPrimitiveType int int int Int32 )
            value.RemovingCSCount                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 RemovingCSCount             ( ModelPrimitiveType int int int Int32 )
            value.IsSelectFile                              = GetBool(new IntPtr(p + 0x028)); // 0x28 IsSelectFile                ( ModelPrimitiveType bool bool bool Bool )
            value.SelectFileName                            = GetString(new IntPtr(p + 0x030)); // 0x30 SelectFileName              ( ModelPrimitiveType string string string String )
            value.SelectText                                = GetString(new IntPtr(p + 0x038)); // 0x38 SelectText                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
