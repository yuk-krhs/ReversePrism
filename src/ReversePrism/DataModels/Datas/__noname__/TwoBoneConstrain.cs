using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseTransform0                           ModelClassType Transform Transform Transform Pointer
    // 028 Rate0                                    ModelPrimitiveType float float float Single
    // 02C X0                                       ModelPrimitiveType bool bool bool Bool
    // 02D Y0                                       ModelPrimitiveType bool bool bool Bool
    // 02E Z0                                       ModelPrimitiveType bool bool bool Bool
    // 030 BaseTransform1                           ModelClassType Transform Transform Transform Pointer
    // 038 Rate1                                    ModelPrimitiveType float float float Single
    // 03C X1                                       ModelPrimitiveType bool bool bool Bool
    // 03D Y1                                       ModelPrimitiveType bool bool bool Bool
    // 03E Z1                                       ModelPrimitiveType bool bool bool Bool
    public partial class TwoBoneConstrain : DataModel
    {
        public Transform?                               BaseTransform0                          { get; set; }
        public float                                    Rate0                                   { get; set; }
        public bool                                     X0                                      { get; set; }
        public bool                                     Y0                                      { get; set; }
        public bool                                     Z0                                      { get; set; }
        public Transform?                               BaseTransform1                          { get; set; }
        public float                                    Rate1                                   { get; set; }
        public bool                                     X1                                      { get; set; }
        public bool                                     Y1                                      { get; set; }
        public bool                                     Z1                                      { get; set; }

        public static TwoBoneConstrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwoBoneConstrain() { Pointer= p0 };

            value.BaseTransform0                            = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 BaseTransform0              ( ModelClassType Transform Transform Transform Pointer )
            value.Rate0                                     = GetSingle(new IntPtr(p + 0x028)); // 0x28 Rate0                       ( ModelPrimitiveType float float float Single )
            value.X0                                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C X0                          ( ModelPrimitiveType bool bool bool Bool )
            value.Y0                                        = GetBool(new IntPtr(p + 0x02D)); // 0x2D Y0                          ( ModelPrimitiveType bool bool bool Bool )
            value.Z0                                        = GetBool(new IntPtr(p + 0x02E)); // 0x2E Z0                          ( ModelPrimitiveType bool bool bool Bool )
            value.BaseTransform1                            = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 BaseTransform1              ( ModelClassType Transform Transform Transform Pointer )
            value.Rate1                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 Rate1                       ( ModelPrimitiveType float float float Single )
            value.X1                                        = GetBool(new IntPtr(p + 0x03C)); // 0x3C X1                          ( ModelPrimitiveType bool bool bool Bool )
            value.Y1                                        = GetBool(new IntPtr(p + 0x03D)); // 0x3D Y1                          ( ModelPrimitiveType bool bool bool Bool )
            value.Z1                                        = GetBool(new IntPtr(p + 0x03E)); // 0x3E Z1                          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
