using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellInfo                                 0001865B6370 ModelClassType CellInfo CellInfo CellInfo Pointer
    // 018 ChunkList                                000185D28AB8 ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer
    // 020 StreamingScore                           000186666050 ModelPrimitiveType float float float Single
    // 024 BlendingFactor                           000186666050 ModelPrimitiveType float float float Single
    // 028 Blending                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class BlendingCellInfo
    {
        public CellInfo?                                CellInfo                                { get; set; }
        public List<BrickChunkAlloc>?                   ChunkList                               { get; set; }
        public float                                    StreamingScore                          { get; set; }
        public float                                    BlendingFactor                          { get; set; }
        public bool                                     Blending                                { get; set; }

        public static BlendingCellInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlendingCellInfo();

            value.CellInfo                                  = GetObject<CellInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CellInfo.FromPointer); // 0270D91E5260 0x10 CellInfo                    ( 0001865B6370 ModelClassType CellInfo CellInfo CellInfo Pointer )
            value.ChunkList                                 = GetEnumList<BrickChunkAlloc>(new IntPtr(p + 0x018)); // 0270D91E5280 0x18 ChunkList                   ( 000185D28AB8 ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer )
            value.StreamingScore                            = GetSingle(new IntPtr(p + 0x020)); // 0270D91E52A0 0x20 StreamingScore              ( 000186666050 ModelPrimitiveType float float float Single )
            value.BlendingFactor                            = GetSingle(new IntPtr(p + 0x024)); // 0270D91E52C0 0x24 BlendingFactor              ( 000186666050 ModelPrimitiveType float float float Single )
            value.Blending                                  = GetBool(new IntPtr(p + 0x028)); // 0270D91E52E0 0x28 Blending                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
