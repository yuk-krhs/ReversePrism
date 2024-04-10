using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionID                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C TransitionFrame                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 OffsetFrame                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Rate                                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ActData : DataModel
    {
        public string                                   ActionID                                { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      TransitionFrame                         { get; set; }
        public int                                      OffsetFrame                             { get; set; }
        public int                                      Rate                                    { get; set; }

        public static ActData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActData() { Pointer= p0 };

            value.ActionID                                  = GetString(new IntPtr(p + 0x010)); // 0245A7091090 0x10 ActionID                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0245A70910B0 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransitionFrame                           = GetInt32(new IntPtr(p + 0x01C)); // 0245A70910D0 0x1C TransitionFrame             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OffsetFrame                               = GetInt32(new IntPtr(p + 0x020)); // 0245A70910F0 0x20 OffsetFrame                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetInt32(new IntPtr(p + 0x024)); // 0245A7091110 0x24 Rate                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
