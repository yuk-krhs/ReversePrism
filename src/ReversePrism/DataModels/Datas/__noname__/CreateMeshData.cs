using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IndexStart                               ModelPrimitiveType int int int Int32
    // 014 IndexLength                              ModelPrimitiveType int int int Int32
    // 018 MinVec                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 MaxVec                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CreateMeshData : DataModel
    {
        public int                                      IndexStart                              { get; set; }
        public int                                      IndexLength                             { get; set; }
        public Vector3                                  MinVec                                  { get; set; }
        public Vector3                                  MaxVec                                  { get; set; }

        public static CreateMeshData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateMeshData() { Pointer= p0 };

            value.IndexStart                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 IndexStart                  ( ModelPrimitiveType int int int Int32 )
            value.IndexLength                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 IndexLength                 ( ModelPrimitiveType int int int Int32 )
            value.MinVec                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 MinVec                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MaxVec                                    = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxVec                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
