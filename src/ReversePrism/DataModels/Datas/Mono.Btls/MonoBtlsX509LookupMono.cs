using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Gch                                      ModelEnumType GCHandle GCHandle GCHandle Int32
    // 028 instance                                 <int> IL2CPP_TYPE_I
    // 030 BySubjectFunc                            ModelClassType BySubjectFunc BySubjectFunc BySubjectFunc Pointer
    // 038 bySubjectFuncPtr                         <int> IL2CPP_TYPE_I
    // 040 Lookup                                   ModelClassType MonoBtlsX509Lookup MonoBtlsX509Lookup MonoBtlsX509Lookup Pointer
    public partial class MonoBtlsX509LookupMono : DataModel
    {
        public GCHandle                                 Gch                                     { get; set; }
        public BySubjectFunc?                           BySubjectFunc                           { get; set; }
        public MonoBtlsX509Lookup?                      Lookup                                  { get; set; }

        public static MonoBtlsX509LookupMono? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsX509LookupMono() { Pointer= p0 };

            value.Gch                                       = (GCHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 Gch                         ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.BySubjectFunc                             = GetObject<BySubjectFunc>(new IntPtr(p + 0x030), ReversePrism.DataModels.BySubjectFunc.FromPointer); // 0x30 BySubjectFunc               ( ModelClassType BySubjectFunc BySubjectFunc BySubjectFunc Pointer )
            value.Lookup                                    = GetObject<MonoBtlsX509Lookup>(new IntPtr(p + 0x040), ReversePrism.DataModels.MonoBtlsX509Lookup.FromPointer); // 0x40 Lookup                      ( ModelClassType MonoBtlsX509Lookup MonoBtlsX509Lookup MonoBtlsX509Lookup Pointer )

            return value;
        }
    }
}
