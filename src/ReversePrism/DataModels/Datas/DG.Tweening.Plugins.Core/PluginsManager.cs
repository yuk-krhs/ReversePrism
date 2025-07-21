using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _floatPlugin                             ITweenPlugin IL2CPP_TYPE_CLASS
    // 008 _doublePlugin                            ITweenPlugin IL2CPP_TYPE_CLASS
    // 010 IntPlugin                                ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 018 UintPlugin                               ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 020 LongPlugin                               ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 028 UlongPlugin                              ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 030 Vector2Plugin                            ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 038 Vector3Plugin                            ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 040 Vector4Plugin                            ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 048 QuaternionPlugin                         ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 050 ColorPlugin                              ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 058 RectPlugin                               ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 060 RectOffsetPlugin                         ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 068 StringPlugin                             ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 070 Vector3ArrayPlugin                       ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 078 Color2Plugin                             ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 000 _MaxCustomPlugins                        int IL2CPP_TYPE_I4
    // 080 _customPlugins                           Dictionary`2<Type, ITweenPlugin> IL2CPP_TYPE_GENERICINST
    public partial class PluginsManager : DataModel
    {
        public ITweenPlugin?                            IntPlugin                               { get; set; }
        public ITweenPlugin?                            UintPlugin                              { get; set; }
        public ITweenPlugin?                            LongPlugin                              { get; set; }
        public ITweenPlugin?                            UlongPlugin                             { get; set; }
        public ITweenPlugin?                            Vector2Plugin                           { get; set; }
        public ITweenPlugin?                            Vector3Plugin                           { get; set; }
        public ITweenPlugin?                            Vector4Plugin                           { get; set; }
        public ITweenPlugin?                            QuaternionPlugin                        { get; set; }
        public ITweenPlugin?                            ColorPlugin                             { get; set; }
        public ITweenPlugin?                            RectPlugin                              { get; set; }
        public ITweenPlugin?                            RectOffsetPlugin                        { get; set; }
        public ITweenPlugin?                            StringPlugin                            { get; set; }
        public ITweenPlugin?                            Vector3ArrayPlugin                      { get; set; }
        public ITweenPlugin?                            Color2Plugin                            { get; set; }

        public static PluginsManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PluginsManager() { Pointer= p0 };

            value.IntPlugin                                 = GetObject<ITweenPlugin>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x10 IntPlugin                   ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.UintPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x18 UintPlugin                  ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.LongPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x20 LongPlugin                  ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.UlongPlugin                               = GetObject<ITweenPlugin>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x28 UlongPlugin                 ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector2Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x30 Vector2Plugin               ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector3Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x38 Vector3Plugin               ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector4Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x40 Vector4Plugin               ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.QuaternionPlugin                          = GetObject<ITweenPlugin>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x48 QuaternionPlugin            ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.ColorPlugin                               = GetObject<ITweenPlugin>(new IntPtr(p + 0x050), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x50 ColorPlugin                 ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.RectPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x058), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x58 RectPlugin                  ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.RectOffsetPlugin                          = GetObject<ITweenPlugin>(new IntPtr(p + 0x060), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x60 RectOffsetPlugin            ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.StringPlugin                              = GetObject<ITweenPlugin>(new IntPtr(p + 0x068), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x68 StringPlugin                ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector3ArrayPlugin                        = GetObject<ITweenPlugin>(new IntPtr(p + 0x070), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x70 Vector3ArrayPlugin          ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Color2Plugin                              = GetObject<ITweenPlugin>(new IntPtr(p + 0x078), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0x78 Color2Plugin                ( ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )

            return value;
        }
    }
}
