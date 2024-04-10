using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kUintPerEntry                            int IL2CPP_TYPE_I4
    // 010 EstimatedVMemCost                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_IndexOfIndicesBuffer                   0001865F59C0 ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 020 M_IndexOfIndicesData                     000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 028 M_CellCount                              0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 034 M_CellMin                                0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 040 M_CellSizeInMinBricks                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_NeedUpdateComputeBuffer                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProbeCellIndices : DataModel
    {
        public int                                      EstimatedVMemCost                       { get; set; }
        public ComputeBuffer?                           M_IndexOfIndicesBuffer                  { get; set; }
        public List<uint>?                              M_IndexOfIndicesData                    { get; set; }
        public Vector3Int                               M_CellCount                             { get; set; }
        public Vector3Int                               M_CellMin                               { get; set; }
        public int                                      M_CellSizeInMinBricks                   { get; set; }
        public bool                                     M_NeedUpdateComputeBuffer               { get; set; }

        public static ProbeCellIndices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeCellIndices() { Pointer= p0 };

            value.EstimatedVMemCost                         = GetInt32(new IntPtr(p + 0x010)); // 024669237C18 0x10 EstimatedVMemCost           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_IndexOfIndicesBuffer                    = GetObject<ComputeBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 024669237C38 0x18 M_IndexOfIndicesBuffer      ( 0001865F59C0 ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_IndexOfIndicesData                      = GetUInt32List(new IntPtr(p + 0x020)); // 024669237C58 0x20 M_IndexOfIndicesData        ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_CellCount                               = (Vector3Int)GetInt32(new IntPtr(p + 0x028)); // 024669237C78 0x28 M_CellCount                 ( 0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_CellMin                                 = (Vector3Int)GetInt32(new IntPtr(p + 0x034)); // 024669237C98 0x34 M_CellMin                   ( 0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_CellSizeInMinBricks                     = GetInt32(new IntPtr(p + 0x040)); // 024669237CB8 0x40 M_CellSizeInMinBricks       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NeedUpdateComputeBuffer                 = GetBool(new IntPtr(p + 0x044)); // 024669237CD8 0x44 M_NeedUpdateComputeBuffer   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
