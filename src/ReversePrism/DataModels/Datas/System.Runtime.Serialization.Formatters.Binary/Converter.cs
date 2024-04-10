using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 primitiveTypeEnumLength                  int IL2CPP_TYPE_I4
    // 008 typeA                                    Type[] IL2CPP_TYPE_SZARRAY
    // 010 ArrayTypeA                               000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 ValueA                                   000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 TypeCodeA                                000185CAD6B8 ModelEnumListType TypeCode[] TypeCode[] List<TypeCode> Pointer
    // 028 CodeA                                    000185B8E180 ModelEnumListType InternalPrimitiveTypeE[] InternalPrimitiveTypeE[] List<InternalPrimitiveTypeE> Pointer
    // 030 TypeofISerializable                      000186693480 ModelClassType Type Type Type Pointer
    // 038 TypeofString                             000186693480 ModelClassType Type Type Type Pointer
    // 040 TypeofConverter                          000186693480 ModelClassType Type Type Type Pointer
    // 048 TypeofBoolean                            000186693480 ModelClassType Type Type Type Pointer
    // 050 TypeofByte                               000186693480 ModelClassType Type Type Type Pointer
    // 058 TypeofChar                               000186693480 ModelClassType Type Type Type Pointer
    // 060 TypeofDecimal                            000186693480 ModelClassType Type Type Type Pointer
    // 068 TypeofDouble                             000186693480 ModelClassType Type Type Type Pointer
    // 070 TypeofInt16                              000186693480 ModelClassType Type Type Type Pointer
    // 078 TypeofInt32                              000186693480 ModelClassType Type Type Type Pointer
    // 080 TypeofInt64                              000186693480 ModelClassType Type Type Type Pointer
    // 088 TypeofSByte                              000186693480 ModelClassType Type Type Type Pointer
    // 090 TypeofSingle                             000186693480 ModelClassType Type Type Type Pointer
    // 098 TypeofTimeSpan                           000186693480 ModelClassType Type Type Type Pointer
    // 0A0 TypeofDateTime                           000186693480 ModelClassType Type Type Type Pointer
    // 0A8 TypeofUInt16                             000186693480 ModelClassType Type Type Type Pointer
    // 0B0 TypeofUInt32                             000186693480 ModelClassType Type Type Type Pointer
    // 0B8 TypeofUInt64                             000186693480 ModelClassType Type Type Type Pointer
    // 0C0 TypeofObject                             000186693480 ModelClassType Type Type Type Pointer
    // 0C8 TypeofSystemVoid                         000186693480 ModelClassType Type Type Type Pointer
    // 0D0 UrtAssembly                              00018658BBB0 ModelClassType Assembly Assembly Assembly Pointer
    // 0D8 UrtAssemblyString                        0001866727E0 ModelPrimitiveType string string string String
    // 0E0 TypeofTypeArray                          000186693480 ModelClassType Type Type Type Pointer
    // 0E8 TypeofObjectArray                        000186693480 ModelClassType Type Type Type Pointer
    // 0F0 TypeofStringArray                        000186693480 ModelClassType Type Type Type Pointer
    // 0F8 TypeofBooleanArray                       000186693480 ModelClassType Type Type Type Pointer
    // 100 TypeofByteArray                          000186693480 ModelClassType Type Type Type Pointer
    // 108 TypeofCharArray                          000186693480 ModelClassType Type Type Type Pointer
    // 110 TypeofDecimalArray                       000186693480 ModelClassType Type Type Type Pointer
    // 118 TypeofDoubleArray                        000186693480 ModelClassType Type Type Type Pointer
    // 120 TypeofInt16Array                         000186693480 ModelClassType Type Type Type Pointer
    // 128 TypeofInt32Array                         000186693480 ModelClassType Type Type Type Pointer
    // 130 TypeofInt64Array                         000186693480 ModelClassType Type Type Type Pointer
    // 138 TypeofSByteArray                         000186693480 ModelClassType Type Type Type Pointer
    // 140 TypeofSingleArray                        000186693480 ModelClassType Type Type Type Pointer
    // 148 TypeofTimeSpanArray                      000186693480 ModelClassType Type Type Type Pointer
    // 150 TypeofDateTimeArray                      000186693480 ModelClassType Type Type Type Pointer
    // 158 TypeofUInt16Array                        000186693480 ModelClassType Type Type Type Pointer
    // 160 TypeofUInt32Array                        000186693480 ModelClassType Type Type Type Pointer
    // 168 TypeofUInt64Array                        000186693480 ModelClassType Type Type Type Pointer
    // 170 TypeofMarshalByRefObject                 000186693480 ModelClassType Type Type Type Pointer
    public partial class Converter : DataModel
    {
        public List<Type>?                              ArrayTypeA                              { get; set; }
        public List<string>?                            ValueA                                  { get; set; }
        public List<TypeCode>?                          TypeCodeA                               { get; set; }
        public List<InternalPrimitiveTypeE>?            CodeA                                   { get; set; }
        public Type?                                    TypeofISerializable                     { get; set; }
        public Type?                                    TypeofString                            { get; set; }
        public Type?                                    TypeofConverter                         { get; set; }
        public Type?                                    TypeofBoolean                           { get; set; }
        public Type?                                    TypeofByte                              { get; set; }
        public Type?                                    TypeofChar                              { get; set; }
        public Type?                                    TypeofDecimal                           { get; set; }
        public Type?                                    TypeofDouble                            { get; set; }
        public Type?                                    TypeofInt16                             { get; set; }
        public Type?                                    TypeofInt32                             { get; set; }
        public Type?                                    TypeofInt64                             { get; set; }
        public Type?                                    TypeofSByte                             { get; set; }
        public Type?                                    TypeofSingle                            { get; set; }
        public Type?                                    TypeofTimeSpan                          { get; set; }
        public Type?                                    TypeofDateTime                          { get; set; }
        public Type?                                    TypeofUInt16                            { get; set; }
        public Type?                                    TypeofUInt32                            { get; set; }
        public Type?                                    TypeofUInt64                            { get; set; }
        public Type?                                    TypeofObject                            { get; set; }
        public Type?                                    TypeofSystemVoid                        { get; set; }
        public Assembly?                                UrtAssembly                             { get; set; }
        public string                                   UrtAssemblyString                       { get; set; }
        public Type?                                    TypeofTypeArray                         { get; set; }
        public Type?                                    TypeofObjectArray                       { get; set; }
        public Type?                                    TypeofStringArray                       { get; set; }
        public Type?                                    TypeofBooleanArray                      { get; set; }
        public Type?                                    TypeofByteArray                         { get; set; }
        public Type?                                    TypeofCharArray                         { get; set; }
        public Type?                                    TypeofDecimalArray                      { get; set; }
        public Type?                                    TypeofDoubleArray                       { get; set; }
        public Type?                                    TypeofInt16Array                        { get; set; }
        public Type?                                    TypeofInt32Array                        { get; set; }
        public Type?                                    TypeofInt64Array                        { get; set; }
        public Type?                                    TypeofSByteArray                        { get; set; }
        public Type?                                    TypeofSingleArray                       { get; set; }
        public Type?                                    TypeofTimeSpanArray                     { get; set; }
        public Type?                                    TypeofDateTimeArray                     { get; set; }
        public Type?                                    TypeofUInt16Array                       { get; set; }
        public Type?                                    TypeofUInt32Array                       { get; set; }
        public Type?                                    TypeofUInt64Array                       { get; set; }
        public Type?                                    TypeofMarshalByRefObject                { get; set; }

        public static Converter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Converter() { Pointer= p0 };

            value.ArrayTypeA                                = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024666CA54A8 0x10 ArrayTypeA                  ( 000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.ValueA                                    = GetStringList(new IntPtr(p + 0x018)); // 024666CA54C8 0x18 ValueA                      ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TypeCodeA                                 = GetEnumList<TypeCode>(new IntPtr(p + 0x020)); // 024666CA54E8 0x20 TypeCodeA                   ( 000185CAD6B8 ModelEnumListType TypeCode[] TypeCode[] List<TypeCode> Pointer )
            value.CodeA                                     = GetEnumList<InternalPrimitiveTypeE>(new IntPtr(p + 0x028)); // 024666CA5508 0x28 CodeA                       ( 000185B8E180 ModelEnumListType InternalPrimitiveTypeE[] InternalPrimitiveTypeE[] List<InternalPrimitiveTypeE> Pointer )
            value.TypeofISerializable                       = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 024666CA5528 0x30 TypeofISerializable         ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofString                              = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 024666CA5548 0x38 TypeofString                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofConverter                           = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 024666CA5568 0x40 TypeofConverter             ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofBoolean                             = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 024666CA5588 0x48 TypeofBoolean               ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofByte                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 024666CA55A8 0x50 TypeofByte                  ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofChar                                = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 024666CA55C8 0x58 TypeofChar                  ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDecimal                             = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 024666CA55E8 0x60 TypeofDecimal               ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDouble                              = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 024666CA5608 0x68 TypeofDouble                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt16                               = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 024666CA5628 0x70 TypeofInt16                 ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt32                               = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 024666CA5648 0x78 TypeofInt32                 ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt64                               = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 024666CA5668 0x80 TypeofInt64                 ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofSByte                               = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 024666CA5688 0x88 TypeofSByte                 ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofSingle                              = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 024666CA56A8 0x90 TypeofSingle                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofTimeSpan                            = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 024666CA56C8 0x98 TypeofTimeSpan              ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDateTime                            = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 024666CA56E8 0xA0 TypeofDateTime              ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt16                              = GetObject<Type>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Type.FromPointer); // 024666CA5708 0xA8 TypeofUInt16                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt32                              = GetObject<Type>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Type.FromPointer); // 024666CA5728 0xB0 TypeofUInt32                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt64                              = GetObject<Type>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Type.FromPointer); // 024666CA5748 0xB8 TypeofUInt64                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofObject                              = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 024666CA5768 0xC0 TypeofObject                ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofSystemVoid                          = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 024666CA5788 0xC8 TypeofSystemVoid            ( 000186693480 ModelClassType Type Type Type Pointer )
            value.UrtAssembly                               = GetObject<Assembly>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Assembly.FromPointer); // 024666CA57A8 0xD0 UrtAssembly                 ( 00018658BBB0 ModelClassType Assembly Assembly Assembly Pointer )
            value.UrtAssemblyString                         = GetString(new IntPtr(p + 0x0D8)); // 024666CA57C8 0xD8 UrtAssemblyString           ( 0001866727E0 ModelPrimitiveType string string string String )
            value.TypeofTypeArray                           = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 024666CA57E8 0xE0 TypeofTypeArray             ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofObjectArray                         = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 024666CA5808 0xE8 TypeofObjectArray           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofStringArray                         = GetObject<Type>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Type.FromPointer); // 024666CA5828 0xF0 TypeofStringArray           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofBooleanArray                        = GetObject<Type>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Type.FromPointer); // 024666CA5848 0xF8 TypeofBooleanArray          ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofByteArray                           = GetObject<Type>(new IntPtr(p + 0x100), ReversePrism.DataModels.Type.FromPointer); // 024666CA5868 0x100 TypeofByteArray             ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofCharArray                           = GetObject<Type>(new IntPtr(p + 0x108), ReversePrism.DataModels.Type.FromPointer); // 024666CA5888 0x108 TypeofCharArray             ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDecimalArray                        = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 024666CA58A8 0x110 TypeofDecimalArray          ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDoubleArray                         = GetObject<Type>(new IntPtr(p + 0x118), ReversePrism.DataModels.Type.FromPointer); // 024666CA58C8 0x118 TypeofDoubleArray           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt16Array                          = GetObject<Type>(new IntPtr(p + 0x120), ReversePrism.DataModels.Type.FromPointer); // 024666CA58E8 0x120 TypeofInt16Array            ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt32Array                          = GetObject<Type>(new IntPtr(p + 0x128), ReversePrism.DataModels.Type.FromPointer); // 024666CA5908 0x128 TypeofInt32Array            ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofInt64Array                          = GetObject<Type>(new IntPtr(p + 0x130), ReversePrism.DataModels.Type.FromPointer); // 024666CA5928 0x130 TypeofInt64Array            ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofSByteArray                          = GetObject<Type>(new IntPtr(p + 0x138), ReversePrism.DataModels.Type.FromPointer); // 024666CA5948 0x138 TypeofSByteArray            ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofSingleArray                         = GetObject<Type>(new IntPtr(p + 0x140), ReversePrism.DataModels.Type.FromPointer); // 024666CA5968 0x140 TypeofSingleArray           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofTimeSpanArray                       = GetObject<Type>(new IntPtr(p + 0x148), ReversePrism.DataModels.Type.FromPointer); // 024666CA5988 0x148 TypeofTimeSpanArray         ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofDateTimeArray                       = GetObject<Type>(new IntPtr(p + 0x150), ReversePrism.DataModels.Type.FromPointer); // 024666CA59A8 0x150 TypeofDateTimeArray         ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt16Array                         = GetObject<Type>(new IntPtr(p + 0x158), ReversePrism.DataModels.Type.FromPointer); // 024666CA59C8 0x158 TypeofUInt16Array           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt32Array                         = GetObject<Type>(new IntPtr(p + 0x160), ReversePrism.DataModels.Type.FromPointer); // 024666CA59E8 0x160 TypeofUInt32Array           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofUInt64Array                         = GetObject<Type>(new IntPtr(p + 0x168), ReversePrism.DataModels.Type.FromPointer); // 024666CA5A08 0x168 TypeofUInt64Array           ( 000186693480 ModelClassType Type Type Type Pointer )
            value.TypeofMarshalByRefObject                  = GetObject<Type>(new IntPtr(p + 0x170), ReversePrism.DataModels.Type.FromPointer); // 024666CA5A28 0x170 TypeofMarshalByRefObject    ( 000186693480 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
