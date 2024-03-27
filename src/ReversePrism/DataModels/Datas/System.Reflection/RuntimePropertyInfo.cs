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
    // 020 Info                                     0001866167E0 ModelEnumType MonoPropertyInfo MonoPropertyInfo MonoPropertyInfo Int32
    // 050 Cached                                   00018670E470 ModelEnumType PInfo PInfo PInfo Int32
    // 058 Cached_getter                            0001866EE830 ModelClassType GetterAdapter GetterAdapter GetterAdapter Pointer
    public partial class RuntimePropertyInfo
    {
        public MonoPropertyInfo                         Info                                    { get; set; }
        public PInfo                                    Cached                                  { get; set; }
        public GetterAdapter?                           Cached_getter                           { get; set; }

        public static RuntimePropertyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimePropertyInfo();

            value.Info                                      = (MonoPropertyInfo)GetInt32(new IntPtr(p + 0x020)); // 0270034D0608 0x20 Info                        ( 0001866167E0 ModelEnumType MonoPropertyInfo MonoPropertyInfo MonoPropertyInfo Int32 )
            value.Cached                                    = (PInfo)GetInt32(new IntPtr(p + 0x050)); // 0270034D0628 0x50 Cached                      ( 00018670E470 ModelEnumType PInfo PInfo PInfo Int32 )
            value.Cached_getter                             = GetObject<GetterAdapter>(new IntPtr(p + 0x058), ReversePrism.DataModels.GetterAdapter.FromPointer); // 0270034D0648 0x58 Cached_getter               ( 0001866EE830 ModelClassType GetterAdapter GetterAdapter GetterAdapter Pointer )

            return value;
        }
    }
}
