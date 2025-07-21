using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxArea                                 int IL2CPP_TYPE_I4
    // 004 kMaxEdgeCount                            int IL2CPP_TYPE_I4
    // 008 kMaxIndexCount                           int IL2CPP_TYPE_I4
    // 00C kMaxVertexCount                          int IL2CPP_TYPE_I4
    // 010 KMaxTriangleCount                        ModelPrimitiveType int int int Int32
    // 014 KMaxRefineIterations                     ModelPrimitiveType int int int Int32
    // 018 KMaxSmoothenIterations                   ModelPrimitiveType int int int Int32
    // 01C KIncrementAreaFactor                     ModelPrimitiveType float float float Single
    public partial class ModuleHandle : DataModel
    {
        public int                                      KMaxTriangleCount                       { get; set; }
        public int                                      KMaxRefineIterations                    { get; set; }
        public int                                      KMaxSmoothenIterations                  { get; set; }
        public float                                    KIncrementAreaFactor                    { get; set; }

        public static ModuleHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModuleHandle() { Pointer= p0 };

            value.KMaxTriangleCount                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 KMaxTriangleCount           ( ModelPrimitiveType int int int Int32 )
            value.KMaxRefineIterations                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 KMaxRefineIterations        ( ModelPrimitiveType int int int Int32 )
            value.KMaxSmoothenIterations                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 KMaxSmoothenIterations      ( ModelPrimitiveType int int int Int32 )
            value.KIncrementAreaFactor                      = GetSingle(new IntPtr(p + 0x01C)); // 0x1C KIncrementAreaFactor        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
