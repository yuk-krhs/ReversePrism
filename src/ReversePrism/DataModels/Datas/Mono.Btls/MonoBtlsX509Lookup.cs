using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Store                                    ModelClassType MonoBtlsX509Store MonoBtlsX509Store MonoBtlsX509Store Pointer
    // 028 Type                                     ModelEnumType MonoBtlsX509LookupType MonoBtlsX509LookupType MonoBtlsX509LookupType Int32
    // 030 MonoLookups                              ModelClassListType List`1<MonoBtlsX509LookupMono> List`1<MonoBtlsX509LookupMono> List<MonoBtlsX509LookupMono> Pointer
    public partial class MonoBtlsX509Lookup : DataModel
    {
        public MonoBtlsX509Store?                       Store                                   { get; set; }
        public MonoBtlsX509LookupType                   Type                                    { get; set; }
        public List<MonoBtlsX509LookupMono>?            MonoLookups                             { get; set; }

        public static MonoBtlsX509Lookup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsX509Lookup() { Pointer= p0 };

            value.Store                                     = GetObject<MonoBtlsX509Store>(new IntPtr(p + 0x020), ReversePrism.DataModels.MonoBtlsX509Store.FromPointer); // 0x20 Store                       ( ModelClassType MonoBtlsX509Store MonoBtlsX509Store MonoBtlsX509Store Pointer )
            value.Type                                      = (MonoBtlsX509LookupType)GetInt32(new IntPtr(p + 0x028)); // 0x28 Type                        ( ModelEnumType MonoBtlsX509LookupType MonoBtlsX509LookupType MonoBtlsX509LookupType Int32 )
            value.MonoLookups                               = GetObjectList<MonoBtlsX509LookupMono>(new IntPtr(p + 0x030), ReversePrism.DataModels.MonoBtlsX509LookupMono.FromPointer); // 0x30 MonoLookups                 ( ModelClassListType List`1<MonoBtlsX509LookupMono> List`1<MonoBtlsX509LookupMono> List<MonoBtlsX509LookupMono> Pointer )

            return value;
        }
    }
}
