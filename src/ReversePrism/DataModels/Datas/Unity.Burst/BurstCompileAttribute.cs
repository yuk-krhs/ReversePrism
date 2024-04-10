using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FloatMode                                0001865A6240 ModelEnumType FloatMode FloatMode FloatMode Int32
    // 014 FloatPrecision                           0001865A7F50 ModelEnumType FloatPrecision FloatPrecision FloatPrecision Int32
    // 018 _compileSynchronously                    Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01A _debug                                   Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01C _disableSafetyChecks                     Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01E _disableDirectCall                       Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 OptimizeFor                              0001866E61E0 ModelEnumType OptimizeFor OptimizeFor OptimizeFor Int32
    // 028 Options                                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class BurstCompileAttribute : DataModel
    {
        public FloatMode                                FloatMode                               { get; set; }
        public FloatPrecision                           FloatPrecision                          { get; set; }
        public OptimizeFor                              OptimizeFor                             { get; set; }
        public List<string>?                            Options                                 { get; set; }

        public static BurstCompileAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BurstCompileAttribute() { Pointer= p0 };

            value.FloatMode                                 = (FloatMode)GetInt32(new IntPtr(p + 0x010)); // 0245A34B8FE8 0x10 FloatMode                   ( 0001865A6240 ModelEnumType FloatMode FloatMode FloatMode Int32 )
            value.FloatPrecision                            = (FloatPrecision)GetInt32(new IntPtr(p + 0x014)); // 0245A34B9008 0x14 FloatPrecision              ( 0001865A7F50 ModelEnumType FloatPrecision FloatPrecision FloatPrecision Int32 )
            value.OptimizeFor                               = (OptimizeFor)GetInt32(new IntPtr(p + 0x020)); // 0245A34B90A8 0x20 OptimizeFor                 ( 0001866E61E0 ModelEnumType OptimizeFor OptimizeFor OptimizeFor Int32 )
            value.Options                                   = GetStringList(new IntPtr(p + 0x028)); // 0245A34B90C8 0x28 Options                     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
