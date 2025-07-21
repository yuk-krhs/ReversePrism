using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupNo                                  ModelPrimitiveType uint uint uint UInt32
    // 014 Id                                       ModelPrimitiveType uint uint uint UInt32
    // 018 namePtr                                  <int> IL2CPP_TYPE_I
    // 020 NumCueLimits                             ModelPrimitiveType uint uint uint UInt32
    // 024 Volume                                   ModelPrimitiveType float float float Single
    public partial class CategoryInfoForMarshaling : DataModel
    {
        public uint                                     GroupNo                                 { get; set; }
        public uint                                     Id                                      { get; set; }
        public uint                                     NumCueLimits                            { get; set; }
        public float                                    Volume                                  { get; set; }

        public static CategoryInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryInfoForMarshaling() { Pointer= p0 };

            value.GroupNo                                   = GetUInt32(new IntPtr(p + 0x010)); // 0x10 GroupNo                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.Id                                        = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Id                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.NumCueLimits                              = GetUInt32(new IntPtr(p + 0x020)); // 0x20 NumCueLimits                ( ModelPrimitiveType uint uint uint UInt32 )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x024)); // 0x24 Volume                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
