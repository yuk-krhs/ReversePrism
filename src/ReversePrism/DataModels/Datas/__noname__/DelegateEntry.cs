using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186671910 ModelPrimitiveType string string string String
    // 018 Assembly                                 000186671910 ModelPrimitiveType string string string String
    // 020 target                                   <object> IL2CPP_TYPE_OBJECT
    // 028 TargetTypeAssembly                       000186671910 ModelPrimitiveType string string string String
    // 030 TargetTypeName                           000186671910 ModelPrimitiveType string string string String
    // 038 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 040 _DelegateEntry                           00018659B280 ModelClassType DelegateEntry DelegateEntry DelegateEntry Pointer
    public partial class DelegateEntry
    {
        public string                                   Type                                    { get; set; }
        public string                                   Assembly                                { get; set; }
        public string                                   TargetTypeAssembly                      { get; set; }
        public string                                   TargetTypeName                          { get; set; }
        public string                                   MethodName                              { get; set; }
        public DelegateEntry?                           _DelegateEntry                          { get; set; }

        public static DelegateEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelegateEntry();

            value.Type                                      = GetString(new IntPtr(p + 0x010)); // 0270D6A66718 0x10 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Assembly                                  = GetString(new IntPtr(p + 0x018)); // 0270D6A66738 0x18 Assembly                    ( 000186671910 ModelPrimitiveType string string string String )
            value.TargetTypeAssembly                        = GetString(new IntPtr(p + 0x028)); // 0270D6A66778 0x28 TargetTypeAssembly          ( 000186671910 ModelPrimitiveType string string string String )
            value.TargetTypeName                            = GetString(new IntPtr(p + 0x030)); // 0270D6A66798 0x30 TargetTypeName              ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x038)); // 0270D6A667B8 0x38 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value._DelegateEntry                            = GetObject<DelegateEntry>(new IntPtr(p + 0x040), ReversePrism.DataModels.DelegateEntry.FromPointer); // 0270D6A667D8 0x40 _DelegateEntry              ( 00018659B280 ModelClassType DelegateEntry DelegateEntry DelegateEntry Pointer )

            return value;
        }
    }
}
