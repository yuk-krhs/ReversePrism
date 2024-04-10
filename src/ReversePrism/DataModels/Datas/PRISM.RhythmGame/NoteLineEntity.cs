using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     0001866ADC10 ModelClassType NoteEntity NoteEntity NoteEntity Pointer
    // 018 Tail                                     0001866ADC10 ModelClassType NoteEntity NoteEntity NoteEntity Pointer
    // 020 SplitCount                               0001865F4940 ModelPrimitiveType int int int Int32
    // 028 Interpolate                              Func`2<float, ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    public partial class NoteLineEntity : DataModel
    {
        public NoteEntity?                              Head                                    { get; set; }
        public NoteEntity?                              Tail                                    { get; set; }
        public int                                      SplitCount                              { get; set; }

        public static NoteLineEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLineEntity() { Pointer= p0 };

            value.Head                                      = GetObject<NoteEntity>(new IntPtr(p + 0x010), ReversePrism.DataModels.NoteEntity.FromPointer); // 024664FEA820 0x10 Head                        ( 0001866ADC10 ModelClassType NoteEntity NoteEntity NoteEntity Pointer )
            value.Tail                                      = GetObject<NoteEntity>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteEntity.FromPointer); // 024664FEA840 0x18 Tail                        ( 0001866ADC10 ModelClassType NoteEntity NoteEntity NoteEntity Pointer )
            value.SplitCount                                = GetInt32(new IntPtr(p + 0x020)); // 024664FEA860 0x20 SplitCount                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
