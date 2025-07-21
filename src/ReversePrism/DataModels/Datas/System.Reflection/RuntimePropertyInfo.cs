using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 klass                                    <int> IL2CPP_TYPE_I
    // 018 prop                                     <int> IL2CPP_TYPE_I
    // 020 Info                                     ModelEnumType MonoPropertyInfo MonoPropertyInfo MonoPropertyInfo Int32
    // 050 Cached                                   ModelEnumType PInfo PInfo PInfo Int32
    // 058 Cached_getter                            ModelClassType GetterAdapter GetterAdapter GetterAdapter Pointer
    public partial class RuntimePropertyInfo : DataModel
    {
        public MonoPropertyInfo                         Info                                    { get; set; }
        public PInfo                                    Cached                                  { get; set; }
        public GetterAdapter?                           Cached_getter                           { get; set; }

        public static RuntimePropertyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimePropertyInfo() { Pointer= p0 };

            value.Info                                      = (MonoPropertyInfo)GetInt32(new IntPtr(p + 0x020)); // 0x20 Info                        ( ModelEnumType MonoPropertyInfo MonoPropertyInfo MonoPropertyInfo Int32 )
            value.Cached                                    = (PInfo)GetInt32(new IntPtr(p + 0x050)); // 0x50 Cached                      ( ModelEnumType PInfo PInfo PInfo Int32 )
            value.Cached_getter                             = GetObject<GetterAdapter>(new IntPtr(p + 0x058), ReversePrism.DataModels.GetterAdapter.FromPointer); // 0x58 Cached_getter               ( ModelClassType GetterAdapter GetterAdapter GetterAdapter Pointer )

            return value;
        }
    }
}
