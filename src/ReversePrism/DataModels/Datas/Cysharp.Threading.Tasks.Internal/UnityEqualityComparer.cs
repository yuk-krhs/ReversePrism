using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Vector2                                  IEqualityComparer`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 008 Vector3                                  IEqualityComparer`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 010 Vector4                                  IEqualityComparer`1<Vector4> IL2CPP_TYPE_GENERICINST
    // 018 Color                                    IEqualityComparer`1<Color> IL2CPP_TYPE_GENERICINST
    // 020 Color32                                  IEqualityComparer`1<Color32> IL2CPP_TYPE_GENERICINST
    // 028 Rect                                     IEqualityComparer`1<Rect> IL2CPP_TYPE_GENERICINST
    // 030 Bounds                                   IEqualityComparer`1<Bounds> IL2CPP_TYPE_GENERICINST
    // 038 Quaternion                               IEqualityComparer`1<Quaternion> IL2CPP_TYPE_GENERICINST
    // 040 Vector2Type                              0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 048 Vector3Type                              0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 050 Vector4Type                              0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 058 ColorType                                0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 060 Color32Type                              0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 068 RectType                                 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 070 BoundsType                               0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 078 QuaternionType                           0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 080 Vector2Int                               IEqualityComparer`1<Vector2Int> IL2CPP_TYPE_GENERICINST
    // 088 Vector3Int                               IEqualityComparer`1<Vector3Int> IL2CPP_TYPE_GENERICINST
    // 090 RangeInt                                 IEqualityComparer`1<RangeInt> IL2CPP_TYPE_GENERICINST
    // 098 RectInt                                  IEqualityComparer`1<RectInt> IL2CPP_TYPE_GENERICINST
    // 0A0 BoundsInt                                IEqualityComparer`1<BoundsInt> IL2CPP_TYPE_GENERICINST
    // 0A8 Vector2IntType                           0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 0B0 Vector3IntType                           0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 0B8 RangeIntType                             0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 0C0 RectIntType                              0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 0C8 BoundsIntType                            0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    public partial class UnityEqualityComparer : DataModel
    {
        public RuntimeTypeHandle                        Vector2Type                             { get; set; }
        public RuntimeTypeHandle                        Vector3Type                             { get; set; }
        public RuntimeTypeHandle                        Vector4Type                             { get; set; }
        public RuntimeTypeHandle                        ColorType                               { get; set; }
        public RuntimeTypeHandle                        Color32Type                             { get; set; }
        public RuntimeTypeHandle                        RectType                                { get; set; }
        public RuntimeTypeHandle                        BoundsType                              { get; set; }
        public RuntimeTypeHandle                        QuaternionType                          { get; set; }
        public RuntimeTypeHandle                        Vector2IntType                          { get; set; }
        public RuntimeTypeHandle                        Vector3IntType                          { get; set; }
        public RuntimeTypeHandle                        RangeIntType                            { get; set; }
        public RuntimeTypeHandle                        RectIntType                             { get; set; }
        public RuntimeTypeHandle                        BoundsIntType                           { get; set; }

        public static UnityEqualityComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEqualityComparer() { Pointer= p0 };

            value.Vector2Type                               = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x040)); // 0246690AB448 0x40 Vector2Type                 ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.Vector3Type                               = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x048)); // 0246690AB468 0x48 Vector3Type                 ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.Vector4Type                               = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x050)); // 0246690AB488 0x50 Vector4Type                 ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.ColorType                                 = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x058)); // 0246690AB4A8 0x58 ColorType                   ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.Color32Type                               = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x060)); // 0246690AB4C8 0x60 Color32Type                 ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.RectType                                  = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x068)); // 0246690AB4E8 0x68 RectType                    ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.BoundsType                                = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x070)); // 0246690AB508 0x70 BoundsType                  ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.QuaternionType                            = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x078)); // 0246690AB528 0x78 QuaternionType              ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.Vector2IntType                            = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x0A8)); // 0246690AB5E8 0xA8 Vector2IntType              ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.Vector3IntType                            = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x0B0)); // 0246690AB608 0xB0 Vector3IntType              ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.RangeIntType                              = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x0B8)); // 0246690AB628 0xB8 RangeIntType                ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.RectIntType                               = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x0C0)); // 0246690AB648 0xC0 RectIntType                 ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )
            value.BoundsIntType                             = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x0C8)); // 0246690AB668 0xC8 BoundsIntType               ( 0001866A02E0 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )

            return value;
        }
    }
}
