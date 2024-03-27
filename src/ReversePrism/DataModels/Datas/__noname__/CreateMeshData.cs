using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IndexStart                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 IndexLength                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MinVec                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 MaxVec                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CreateMeshData
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
            var value   = new CreateMeshData();

            value.IndexStart                                = GetInt32(new IntPtr(p + 0x010)); // 0270035B4748 0x10 IndexStart                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IndexLength                               = GetInt32(new IntPtr(p + 0x014)); // 0270035B4768 0x14 IndexLength                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinVec                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270035B4788 0x18 MinVec                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MaxVec                                    = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270035B47A8 0x24 MaxVec                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
