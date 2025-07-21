using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstChunkIndex                          ModelPrimitiveType int int int Int32
    // 014 NumberOfChunks                           ModelPrimitiveType int int int Int32
    // 018 MinSubdivInCell                          ModelPrimitiveType int int int Int32
    // 01C MinValidBrickIndexForCellAtMaxRes        ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 028 MaxValidBrickIndexForCellAtMaxResPlusOne ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 034 CellPositionInBricksAtMaxRes             ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    public partial class CellIndexUpdateInfo : DataModel
    {
        public int                                      FirstChunkIndex                         { get; set; }
        public int                                      NumberOfChunks                          { get; set; }
        public int                                      MinSubdivInCell                         { get; set; }
        public Vector3Int                               MinValidBrickIndexForCellAtMaxRes       { get; set; }
        public Vector3Int                               MaxValidBrickIndexForCellAtMaxResPlusOne { get; set; }
        public Vector3Int                               CellPositionInBricksAtMaxRes            { get; set; }

        public static CellIndexUpdateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CellIndexUpdateInfo() { Pointer= p0 };

            value.FirstChunkIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 FirstChunkIndex             ( ModelPrimitiveType int int int Int32 )
            value.NumberOfChunks                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumberOfChunks              ( ModelPrimitiveType int int int Int32 )
            value.MinSubdivInCell                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MinSubdivInCell             ( ModelPrimitiveType int int int Int32 )
            value.MinValidBrickIndexForCellAtMaxRes         = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 0x1C MinValidBrickIndexForCellAtMaxRes ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MaxValidBrickIndexForCellAtMaxResPlusOne  = (Vector3Int)GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxValidBrickIndexForCellAtMaxResPlusOne ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.CellPositionInBricksAtMaxRes              = (Vector3Int)GetInt32(new IntPtr(p + 0x034)); // 0x34 CellPositionInBricksAtMaxRes ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
