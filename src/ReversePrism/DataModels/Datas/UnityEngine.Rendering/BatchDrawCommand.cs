using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VisibleOffset                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 VisibleCount                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 BatchID                                  00018674C0B0 ModelEnumType BatchID BatchID BatchID Int32
    // 01C MaterialID                               00018674C830 ModelEnumType BatchMaterialID BatchMaterialID BatchMaterialID Int32
    // 020 MeshID                                   00018674CF10 ModelEnumType BatchMeshID BatchMeshID BatchMeshID Int32
    // 024 SubmeshIndex                             000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 026 SplitVisibilityMask                      000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 028 Flags                                    00018674AC10 ModelEnumType BatchDrawCommandFlags BatchDrawCommandFlags BatchDrawCommandFlags Int32
    // 02C SortingPosition                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class BatchDrawCommand
    {
        public uint                                     VisibleOffset                           { get; set; }
        public uint                                     VisibleCount                            { get; set; }
        public BatchID                                  BatchID                                 { get; set; }
        public BatchMaterialID                          MaterialID                              { get; set; }
        public BatchMeshID                              MeshID                                  { get; set; }
        public ushort                                   SubmeshIndex                            { get; set; }
        public ushort                                   SplitVisibilityMask                     { get; set; }
        public BatchDrawCommandFlags                    Flags                                   { get; set; }
        public int                                      SortingPosition                         { get; set; }

        public static BatchDrawCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchDrawCommand();

            value.VisibleOffset                             = GetUInt32(new IntPtr(p + 0x010)); // 0270068CAA28 0x10 VisibleOffset               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.VisibleCount                              = GetUInt32(new IntPtr(p + 0x014)); // 0270068CAA48 0x14 VisibleCount                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.BatchID                                   = (BatchID)GetInt32(new IntPtr(p + 0x018)); // 0270068CAA68 0x18 BatchID                     ( 00018674C0B0 ModelEnumType BatchID BatchID BatchID Int32 )
            value.MaterialID                                = (BatchMaterialID)GetInt32(new IntPtr(p + 0x01C)); // 0270068CAA88 0x1C MaterialID                  ( 00018674C830 ModelEnumType BatchMaterialID BatchMaterialID BatchMaterialID Int32 )
            value.MeshID                                    = (BatchMeshID)GetInt32(new IntPtr(p + 0x020)); // 0270068CAAA8 0x20 MeshID                      ( 00018674CF10 ModelEnumType BatchMeshID BatchMeshID BatchMeshID Int32 )
            value.SubmeshIndex                              = GetUInt16(new IntPtr(p + 0x024)); // 0270068CAAC8 0x24 SubmeshIndex                ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SplitVisibilityMask                       = GetUInt16(new IntPtr(p + 0x026)); // 0270068CAAE8 0x26 SplitVisibilityMask         ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Flags                                     = (BatchDrawCommandFlags)GetInt32(new IntPtr(p + 0x028)); // 0270068CAB08 0x28 Flags                       ( 00018674AC10 ModelEnumType BatchDrawCommandFlags BatchDrawCommandFlags BatchDrawCommandFlags Int32 )
            value.SortingPosition                           = GetInt32(new IntPtr(p + 0x02C)); // 0270068CAB28 0x2C SortingPosition             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
