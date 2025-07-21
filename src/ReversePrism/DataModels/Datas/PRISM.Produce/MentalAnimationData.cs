using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelEnumType MentalState MentalState MentalState Int32
    // 014 Current                                  ModelPrimitiveType int int int Int32
    // 018 Max                                      ModelPrimitiveType int int int Int32
    // 01C IsCrease                                 ModelPrimitiveType bool bool bool Bool
    // 020 ChangeValue                              ModelPrimitiveType int int int Int32
    public partial class MentalAnimationData : DataModel
    {
        public MentalState                              State                                   { get; set; }
        public int                                      Current                                 { get; set; }
        public int                                      Max                                     { get; set; }
        public bool                                     IsCrease                                { get; set; }
        public int                                      ChangeValue                             { get; set; }

        public static MentalAnimationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MentalAnimationData() { Pointer= p0 };

            value.State                                     = (MentalState)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType MentalState MentalState MentalState Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 Current                     ( ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Max                         ( ModelPrimitiveType int int int Int32 )
            value.IsCrease                                  = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsCrease                    ( ModelPrimitiveType bool bool bool Bool )
            value.ChangeValue                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 ChangeValue                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
