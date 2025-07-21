using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Chunk                                    ModelEnumType DataChunk DataChunk DataChunk Int32
    // 018 Sw                                       ModelPrimitiveType bool bool bool Bool
    // 020 flagList                                 NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    public partial class EnableTransformJob : DataModel
    {
        public DataChunk                                Chunk                                   { get; set; }
        public bool                                     Sw                                      { get; set; }

        public static EnableTransformJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnableTransformJob() { Pointer= p0 };

            value.Chunk                                     = (DataChunk)GetInt32(new IntPtr(p + 0x010)); // 0x10 Chunk                       ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.Sw                                        = GetBool(new IntPtr(p + 0x018)); // 0x18 Sw                          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
