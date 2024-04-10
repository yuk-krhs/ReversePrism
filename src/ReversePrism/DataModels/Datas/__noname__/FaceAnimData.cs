using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FaceAnimParamID                          0001866722E0 ModelPrimitiveType string string string String
    // 018 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C TransitionFrame                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class FaceAnimData : DataModel
    {
        public string                                   FaceAnimParamID                         { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      TransitionFrame                         { get; set; }

        public static FaceAnimData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceAnimData() { Pointer= p0 };

            value.FaceAnimParamID                           = GetString(new IntPtr(p + 0x010)); // 0245A60CA630 0x10 FaceAnimParamID             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0245A60CA650 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransitionFrame                           = GetInt32(new IntPtr(p + 0x01C)); // 0245A60CA670 0x1C TransitionFrame             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
