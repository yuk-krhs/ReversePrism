using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformArray                           ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32
    // 018 NativeLength                             ModelPrimitiveType int int int Int32
    // 020 emptyStack                               Queue`1<int> IL2CPP_TYPE_GENERICINST
    // 028 useIndexDict                             Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 indexDict                                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 038 referenceDict                            Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    public partial class ExTransformAccessArray : DataModel
    {
        public TransformAccessArray                     TransformArray                          { get; set; }
        public int                                      NativeLength                            { get; set; }

        public static ExTransformAccessArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExTransformAccessArray() { Pointer= p0 };

            value.TransformArray                            = (TransformAccessArray)GetInt32(new IntPtr(p + 0x010)); // 0x10 TransformArray              ( ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32 )
            value.NativeLength                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 NativeLength                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
