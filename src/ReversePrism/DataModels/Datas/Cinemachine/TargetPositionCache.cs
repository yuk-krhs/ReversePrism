using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UseCache                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 CacheStepSize                            float IL2CPP_TYPE_R4
    // 004 m_CacheMode                              Mode IL2CPP_TYPE_VALUETYPE
    // 008 CurrentTime                              float IL2CPP_TYPE_R4
    // 00C CurrentFrame                             int IL2CPP_TYPE_I4
    // 010 IsCameraCut                              ModelPrimitiveType bool bool bool Bool
    // 018 m_Cache                                  Dictionary`2<Transform, CacheEntry> IL2CPP_TYPE_GENERICINST
    // 020 M_CacheTimeRange                         ModelEnumType TimeRange TimeRange TimeRange Int32
    // 000 kWraparoundSlush                         float IL2CPP_TYPE_R4
    public partial class TargetPositionCache : DataModel
    {
        public bool                                     IsCameraCut                             { get; set; }
        public TimeRange                                M_CacheTimeRange                        { get; set; }

        public static TargetPositionCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TargetPositionCache() { Pointer= p0 };

            value.IsCameraCut                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsCameraCut                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_CacheTimeRange                          = (TimeRange)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_CacheTimeRange            ( ModelEnumType TimeRange TimeRange TimeRange Int32 )

            return value;
        }
    }
}
