using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstChunkIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 NumberOfChunks                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MinSubdivInCell                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C MinValidBrickIndexForCellAtMaxRes        0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 028 MaxValidBrickIndexForCellAtMaxResPlusOne 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 034 CellPositionInBricksAtMaxRes             0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
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

            value.FirstChunkIndex                           = GetInt32(new IntPtr(p + 0x010)); // 02466921CE28 0x10 FirstChunkIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumberOfChunks                            = GetInt32(new IntPtr(p + 0x014)); // 02466921CE48 0x14 NumberOfChunks              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinSubdivInCell                           = GetInt32(new IntPtr(p + 0x018)); // 02466921CE68 0x18 MinSubdivInCell             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinValidBrickIndexForCellAtMaxRes         = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 02466921CE88 0x1C MinValidBrickIndexForCellAtMaxRes ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MaxValidBrickIndexForCellAtMaxResPlusOne  = (Vector3Int)GetInt32(new IntPtr(p + 0x028)); // 02466921CEA8 0x28 MaxValidBrickIndexForCellAtMaxResPlusOne ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.CellPositionInBricksAtMaxRes              = (Vector3Int)GetInt32(new IntPtr(p + 0x034)); // 02466921CEC8 0x34 CellPositionInBricksAtMaxRes ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
