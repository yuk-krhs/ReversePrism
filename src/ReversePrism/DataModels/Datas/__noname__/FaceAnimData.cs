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
    public partial class FaceAnimData
    {
        public string                                   FaceAnimParamID                         { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      TransitionFrame                         { get; set; }

        public static FaceAnimData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceAnimData();

            value.FaceAnimParamID                           = GetString(new IntPtr(p + 0x010)); // 0270060F0F28 0x10 FaceAnimParamID             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0270060F0F48 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransitionFrame                           = GetInt32(new IntPtr(p + 0x01C)); // 0270060F0F68 0x1C TransitionFrame             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
