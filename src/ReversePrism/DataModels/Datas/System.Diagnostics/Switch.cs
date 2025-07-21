using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 switchSettings                           <object> IL2CPP_TYPE_OBJECT
    // 018 Description                              ModelPrimitiveType string string string String
    // 020 DisplayName                              ModelPrimitiveType string string string String
    // 028 SwitchSetting                            ModelPrimitiveType int int int Int32
    // 02C Initialized                              ModelPrimitiveType bool bool bool Bool
    // 02D Initializing                             ModelPrimitiveType bool bool bool Bool
    // 030 SwitchValueString                        ModelPrimitiveType string string string String
    // 038 DefaultValue                             ModelPrimitiveType string string string String
    // 040 m_intializedLock                         <object> IL2CPP_TYPE_OBJECT
    // 000 switches                                 List`1<WeakReference> IL2CPP_TYPE_GENERICINST
    // 008 s_LastCollectionCount                    int IL2CPP_TYPE_I4
    public partial class Switch : DataModel
    {
        public string                                   Description                             { get; set; }
        public string                                   DisplayName                             { get; set; }
        public int                                      SwitchSetting                           { get; set; }
        public bool                                     Initialized                             { get; set; }
        public bool                                     Initializing                            { get; set; }
        public string                                   SwitchValueString                       { get; set; }
        public string                                   DefaultValue                            { get; set; }

        public static Switch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Switch() { Pointer= p0 };

            value.Description                               = GetString(new IntPtr(p + 0x018)); // 0x18 Description                 ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0x20 DisplayName                 ( ModelPrimitiveType string string string String )
            value.SwitchSetting                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 SwitchSetting               ( ModelPrimitiveType int int int Int32 )
            value.Initialized                               = GetBool(new IntPtr(p + 0x02C)); // 0x2C Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.Initializing                              = GetBool(new IntPtr(p + 0x02D)); // 0x2D Initializing                ( ModelPrimitiveType bool bool bool Bool )
            value.SwitchValueString                         = GetString(new IntPtr(p + 0x030)); // 0x30 SwitchValueString           ( ModelPrimitiveType string string string String )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x038)); // 0x38 DefaultValue                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
