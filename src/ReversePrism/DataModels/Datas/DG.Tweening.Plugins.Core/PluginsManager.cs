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
    // 010 IntPlugin                                0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 018 UintPlugin                               0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 020 LongPlugin                               0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 028 UlongPlugin                              0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 030 Vector2Plugin                            0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 038 Vector3Plugin                            0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 040 Vector4Plugin                            0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 048 QuaternionPlugin                         0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 050 ColorPlugin                              0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 058 RectPlugin                               0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 060 RectOffsetPlugin                         0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 068 StringPlugin                             0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 070 Vector3ArrayPlugin                       0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
    // 078 Color2Plugin                             0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer
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

            value.IntPlugin                                 = GetObject<ITweenPlugin>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3C90 0x10 IntPlugin                   ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.UintPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3CB0 0x18 UintPlugin                  ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.LongPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3CD0 0x20 LongPlugin                  ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.UlongPlugin                               = GetObject<ITweenPlugin>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3CF0 0x28 UlongPlugin                 ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector2Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3D10 0x30 Vector2Plugin               ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector3Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3D30 0x38 Vector3Plugin               ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector4Plugin                             = GetObject<ITweenPlugin>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3D50 0x40 Vector4Plugin               ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.QuaternionPlugin                          = GetObject<ITweenPlugin>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3D70 0x48 QuaternionPlugin            ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.ColorPlugin                               = GetObject<ITweenPlugin>(new IntPtr(p + 0x050), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3D90 0x50 ColorPlugin                 ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.RectPlugin                                = GetObject<ITweenPlugin>(new IntPtr(p + 0x058), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3DB0 0x58 RectPlugin                  ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.RectOffsetPlugin                          = GetObject<ITweenPlugin>(new IntPtr(p + 0x060), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3DD0 0x60 RectOffsetPlugin            ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.StringPlugin                              = GetObject<ITweenPlugin>(new IntPtr(p + 0x068), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3DF0 0x68 StringPlugin                ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Vector3ArrayPlugin                        = GetObject<ITweenPlugin>(new IntPtr(p + 0x070), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3E10 0x70 Vector3ArrayPlugin          ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )
            value.Color2Plugin                              = GetObject<ITweenPlugin>(new IntPtr(p + 0x078), ReversePrism.DataModels.ITweenPlugin.FromPointer); // 0245A43C3E30 0x78 Color2Plugin                ( 0001866826F0 ModelClassType ITweenPlugin ITweenPlugin ITweenPlugin Pointer )

            return value;
        }
    }
}
