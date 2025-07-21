using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  MemoryPackSerializerOptions IL2CPP_TYPE_CLASS
    // 008 Utf8                                     MemoryPackSerializerOptions IL2CPP_TYPE_CLASS
    // 010 Utf16                                    ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer
    // 010 StringEncoding                           ModelEnumType StringEncoding StringEncoding StringEncoding Int32
    // 018 ServiceProvider                          ModelClassType IServiceProvider IServiceProvider IServiceProvider Pointer
    public partial class MemoryPackSerializerOptions : DataModel
    {
        public MemoryPackSerializerOptions?             Utf16                                   { get; set; }
        public StringEncoding                           StringEncoding                          { get; set; }
        public IServiceProvider?                        ServiceProvider                         { get; set; }

        public static MemoryPackSerializerOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackSerializerOptions() { Pointer= p0 };

            value.Utf16                                     = GetObject<MemoryPackSerializerOptions>(new IntPtr(p + 0x010), ReversePrism.DataModels.MemoryPackSerializerOptions.FromPointer); // 0x10 Utf16                       ( ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer )
            value.StringEncoding                            = (StringEncoding)GetInt32(new IntPtr(p + 0x010)); // 0x10 StringEncoding              ( ModelEnumType StringEncoding StringEncoding StringEncoding Int32 )
            value.ServiceProvider                           = GetObject<IServiceProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IServiceProvider.FromPointer); // 0x18 ServiceProvider             ( ModelClassType IServiceProvider IServiceProvider IServiceProvider Pointer )

            return value;
        }
    }
}
