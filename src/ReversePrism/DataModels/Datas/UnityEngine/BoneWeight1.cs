using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Weight                                 ModelPrimitiveType float float float Single
    // 014 M_BoneIndex                              ModelPrimitiveType int int int Int32
    public partial class BoneWeight1 : DataModel
    {
        public float                                    M_Weight                                { get; set; }
        public int                                      M_BoneIndex                             { get; set; }

        public static BoneWeight1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneWeight1() { Pointer= p0 };

            value.M_Weight                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Weight                    ( ModelPrimitiveType float float float Single )
            value.M_BoneIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_BoneIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
