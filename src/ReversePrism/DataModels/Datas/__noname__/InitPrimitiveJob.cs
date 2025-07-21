using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TeamId                                   ModelPrimitiveType int int int Int32
    // 018 Tdata                                    ModelEnumType TeamData TeamData TeamData Int32
    // 170 Kind                                     ModelPrimitiveType uint uint uint UInt32
    // 174 StartPrimitive                           ModelPrimitiveType int int int Int32
    // 178 StartSort                                ModelPrimitiveType int int int Int32
    // 180 edges                                    NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 190 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 1A0 primitiveArray                           NativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 1B0 sortArray                                NativeArray`1<SortData> IL2CPP_TYPE_GENERICINST
    public partial class InitPrimitiveJob : DataModel
    {
        public int                                      TeamId                                  { get; set; }
        public TeamData                                 Tdata                                   { get; set; }
        public uint                                     Kind                                    { get; set; }
        public int                                      StartPrimitive                          { get; set; }
        public int                                      StartSort                               { get; set; }

        public static InitPrimitiveJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitPrimitiveJob() { Pointer= p0 };

            value.TeamId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 TeamId                      ( ModelPrimitiveType int int int Int32 )
            value.Tdata                                     = (TeamData)GetInt32(new IntPtr(p + 0x018)); // 0x18 Tdata                       ( ModelEnumType TeamData TeamData TeamData Int32 )
            value.Kind                                      = GetUInt32(new IntPtr(p + 0x170)); // 0x170 Kind                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.StartPrimitive                            = GetInt32(new IntPtr(p + 0x174)); // 0x174 StartPrimitive              ( ModelPrimitiveType int int int Int32 )
            value.StartSort                                 = GetInt32(new IntPtr(p + 0x178)); // 0x178 StartSort                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
