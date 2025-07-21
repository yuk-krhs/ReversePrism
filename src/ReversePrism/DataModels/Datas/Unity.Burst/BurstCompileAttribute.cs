using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FloatMode                                ModelEnumType FloatMode FloatMode FloatMode Int32
    // 014 FloatPrecision                           ModelEnumType FloatPrecision FloatPrecision FloatPrecision Int32
    // 018 _compileSynchronously                    Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01A _debug                                   Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01C _disableSafetyChecks                     Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01E _disableDirectCall                       Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 OptimizeFor                              ModelEnumType OptimizeFor OptimizeFor OptimizeFor Int32
    // 028 Options                                  ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.FloatMode                                 = (FloatMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 FloatMode                   ( ModelEnumType FloatMode FloatMode FloatMode Int32 )
            value.FloatPrecision                            = (FloatPrecision)GetInt32(new IntPtr(p + 0x014)); // 0x14 FloatPrecision              ( ModelEnumType FloatPrecision FloatPrecision FloatPrecision Int32 )
            value.OptimizeFor                               = (OptimizeFor)GetInt32(new IntPtr(p + 0x020)); // 0x20 OptimizeFor                 ( ModelEnumType OptimizeFor OptimizeFor OptimizeFor Int32 )
            value.Options                                   = GetStringList(new IntPtr(p + 0x028)); // 0x28 Options                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
