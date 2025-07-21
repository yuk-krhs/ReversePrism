using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Device                                 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 018 M_LayoutCacheRef                         ModelEnumType CacheRefInstance CacheRefInstance CacheRefInstance Int32
    // 020 m_ChildControlOverrides                  Dictionary`2<string, ControlItem> IL2CPP_TYPE_GENERICINST
    // 028 M_StateOffsetToControlMap                ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 030 M_StringBuilder                          ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 000 kSizeForControlUsingStateFromOtherControl uint IL2CPP_TYPE_U4
    // 000 s_Instance                               InputDeviceBuilder IL2CPP_TYPE_VALUETYPE
    // 028 S_InstanceRef                            ModelPrimitiveType int int int Int32
    public partial class InputDeviceBuilder : DataModel
    {
        public InputDevice?                             M_Device                                { get; set; }
        public CacheRefInstance                         M_LayoutCacheRef                        { get; set; }
        public List<uint>?                              M_StateOffsetToControlMap               { get; set; }
        public StringBuilder?                           M_StringBuilder                         { get; set; }
        public int                                      S_InstanceRef                           { get; set; }

        public static InputDeviceBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDeviceBuilder() { Pointer= p0 };

            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputDevice.FromPointer); // 0x10 M_Device                    ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_LayoutCacheRef                          = (CacheRefInstance)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_LayoutCacheRef            ( ModelEnumType CacheRefInstance CacheRefInstance CacheRefInstance Int32 )
            value.M_StateOffsetToControlMap                 = GetUInt32List(new IntPtr(p + 0x028)); // 0x28 M_StateOffsetToControlMap   ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_StringBuilder                           = GetObject<StringBuilder>(new IntPtr(p + 0x030), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x30 M_StringBuilder             ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.S_InstanceRef                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 S_InstanceRef               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
