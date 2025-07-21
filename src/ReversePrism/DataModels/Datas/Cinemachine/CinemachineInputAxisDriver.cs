using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Multiplier                               ModelPrimitiveType float float float Single
    // 014 AccelTime                                ModelPrimitiveType float float float Single
    // 018 DecelTime                                ModelPrimitiveType float float float Single
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 InputValue                               ModelPrimitiveType float float float Single
    // 02C MCurrentSpeed                            ModelPrimitiveType float float float Single
    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    public partial class CinemachineInputAxisDriver : DataModel
    {
        public float                                    Multiplier                              { get; set; }
        public float                                    AccelTime                               { get; set; }
        public float                                    DecelTime                               { get; set; }
        public string                                   Name                                    { get; set; }
        public float                                    InputValue                              { get; set; }
        public float                                    MCurrentSpeed                           { get; set; }

        public static CinemachineInputAxisDriver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineInputAxisDriver() { Pointer= p0 };

            value.Multiplier                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 Multiplier                  ( ModelPrimitiveType float float float Single )
            value.AccelTime                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 AccelTime                   ( ModelPrimitiveType float float float Single )
            value.DecelTime                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 DecelTime                   ( ModelPrimitiveType float float float Single )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.InputValue                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 InputValue                  ( ModelPrimitiveType float float float Single )
            value.MCurrentSpeed                             = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MCurrentSpeed               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
