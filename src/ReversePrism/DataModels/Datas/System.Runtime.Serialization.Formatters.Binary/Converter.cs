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
    // 010 ArrayTypeA                               ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 ValueA                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 TypeCodeA                                ModelEnumListType TypeCode[] TypeCode[] List<TypeCode> Pointer
    // 028 CodeA                                    ModelEnumListType InternalPrimitiveTypeE[] InternalPrimitiveTypeE[] List<InternalPrimitiveTypeE> Pointer
    // 030 TypeofISerializable                      ModelClassType Type Type Type Pointer
    // 038 TypeofString                             ModelClassType Type Type Type Pointer
    // 040 TypeofConverter                          ModelClassType Type Type Type Pointer
    // 048 TypeofBoolean                            ModelClassType Type Type Type Pointer
    // 050 TypeofByte                               ModelClassType Type Type Type Pointer
    // 058 TypeofChar                               ModelClassType Type Type Type Pointer
    // 060 TypeofDecimal                            ModelClassType Type Type Type Pointer
    // 068 TypeofDouble                             ModelClassType Type Type Type Pointer
    // 070 TypeofInt16                              ModelClassType Type Type Type Pointer
    // 078 TypeofInt32                              ModelClassType Type Type Type Pointer
    // 080 TypeofInt64                              ModelClassType Type Type Type Pointer
    // 088 TypeofSByte                              ModelClassType Type Type Type Pointer
    // 090 TypeofSingle                             ModelClassType Type Type Type Pointer
    // 098 TypeofTimeSpan                           ModelClassType Type Type Type Pointer
    // 0A0 TypeofDateTime                           ModelClassType Type Type Type Pointer
    // 0A8 TypeofUInt16                             ModelClassType Type Type Type Pointer
    // 0B0 TypeofUInt32                             ModelClassType Type Type Type Pointer
    // 0B8 TypeofUInt64                             ModelClassType Type Type Type Pointer
    // 0C0 TypeofObject                             ModelClassType Type Type Type Pointer
    // 0C8 TypeofSystemVoid                         ModelClassType Type Type Type Pointer
    // 0D0 UrtAssembly                              ModelClassType Assembly Assembly Assembly Pointer
    // 0D8 UrtAssemblyString                        ModelPrimitiveType string string string String
    // 0E0 TypeofTypeArray                          ModelClassType Type Type Type Pointer
    // 0E8 TypeofObjectArray                        ModelClassType Type Type Type Pointer
    // 0F0 TypeofStringArray                        ModelClassType Type Type Type Pointer
    // 0F8 TypeofBooleanArray                       ModelClassType Type Type Type Pointer
    // 100 TypeofByteArray                          ModelClassType Type Type Type Pointer
    // 108 TypeofCharArray                          ModelClassType Type Type Type Pointer
    // 110 TypeofDecimalArray                       ModelClassType Type Type Type Pointer
    // 118 TypeofDoubleArray                        ModelClassType Type Type Type Pointer
    // 120 TypeofInt16Array                         ModelClassType Type Type Type Pointer
    // 128 TypeofInt32Array                         ModelClassType Type Type Type Pointer
    // 130 TypeofInt64Array                         ModelClassType Type Type Type Pointer
    // 138 TypeofSByteArray                         ModelClassType Type Type Type Pointer
    // 140 TypeofSingleArray                        ModelClassType Type Type Type Pointer
    // 148 TypeofTimeSpanArray                      ModelClassType Type Type Type Pointer
    // 150 TypeofDateTimeArray                      ModelClassType Type Type Type Pointer
    // 158 TypeofUInt16Array                        ModelClassType Type Type Type Pointer
    // 160 TypeofUInt32Array                        ModelClassType Type Type Type Pointer
    // 168 TypeofUInt64Array                        ModelClassType Type Type Type Pointer
    // 170 TypeofMarshalByRefObject                 ModelClassType Type Type Type Pointer
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

            value.ArrayTypeA                                = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ArrayTypeA                  ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.ValueA                                    = GetStringList(new IntPtr(p + 0x018)); // 0x18 ValueA                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TypeCodeA                                 = GetEnumList<TypeCode>(new IntPtr(p + 0x020)); // 0x20 TypeCodeA                   ( ModelEnumListType TypeCode[] TypeCode[] List<TypeCode> Pointer )
            value.CodeA                                     = GetEnumList<InternalPrimitiveTypeE>(new IntPtr(p + 0x028)); // 0x28 CodeA                       ( ModelEnumListType InternalPrimitiveTypeE[] InternalPrimitiveTypeE[] List<InternalPrimitiveTypeE> Pointer )
            value.TypeofISerializable                       = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 TypeofISerializable         ( ModelClassType Type Type Type Pointer )
            value.TypeofString                              = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 TypeofString                ( ModelClassType Type Type Type Pointer )
            value.TypeofConverter                           = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 TypeofConverter             ( ModelClassType Type Type Type Pointer )
            value.TypeofBoolean                             = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 0x48 TypeofBoolean               ( ModelClassType Type Type Type Pointer )
            value.TypeofByte                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0x50 TypeofByte                  ( ModelClassType Type Type Type Pointer )
            value.TypeofChar                                = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 0x58 TypeofChar                  ( ModelClassType Type Type Type Pointer )
            value.TypeofDecimal                             = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 TypeofDecimal               ( ModelClassType Type Type Type Pointer )
            value.TypeofDouble                              = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 0x68 TypeofDouble                ( ModelClassType Type Type Type Pointer )
            value.TypeofInt16                               = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0x70 TypeofInt16                 ( ModelClassType Type Type Type Pointer )
            value.TypeofInt32                               = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0x78 TypeofInt32                 ( ModelClassType Type Type Type Pointer )
            value.TypeofInt64                               = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 0x80 TypeofInt64                 ( ModelClassType Type Type Type Pointer )
            value.TypeofSByte                               = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 0x88 TypeofSByte                 ( ModelClassType Type Type Type Pointer )
            value.TypeofSingle                              = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0x90 TypeofSingle                ( ModelClassType Type Type Type Pointer )
            value.TypeofTimeSpan                            = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 0x98 TypeofTimeSpan              ( ModelClassType Type Type Type Pointer )
            value.TypeofDateTime                            = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0xA0 TypeofDateTime              ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt16                              = GetObject<Type>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Type.FromPointer); // 0xA8 TypeofUInt16                ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt32                              = GetObject<Type>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Type.FromPointer); // 0xB0 TypeofUInt32                ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt64                              = GetObject<Type>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Type.FromPointer); // 0xB8 TypeofUInt64                ( ModelClassType Type Type Type Pointer )
            value.TypeofObject                              = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 0xC0 TypeofObject                ( ModelClassType Type Type Type Pointer )
            value.TypeofSystemVoid                          = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 0xC8 TypeofSystemVoid            ( ModelClassType Type Type Type Pointer )
            value.UrtAssembly                               = GetObject<Assembly>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Assembly.FromPointer); // 0xD0 UrtAssembly                 ( ModelClassType Assembly Assembly Assembly Pointer )
            value.UrtAssemblyString                         = GetString(new IntPtr(p + 0x0D8)); // 0xD8 UrtAssemblyString           ( ModelPrimitiveType string string string String )
            value.TypeofTypeArray                           = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0xE0 TypeofTypeArray             ( ModelClassType Type Type Type Pointer )
            value.TypeofObjectArray                         = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 0xE8 TypeofObjectArray           ( ModelClassType Type Type Type Pointer )
            value.TypeofStringArray                         = GetObject<Type>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Type.FromPointer); // 0xF0 TypeofStringArray           ( ModelClassType Type Type Type Pointer )
            value.TypeofBooleanArray                        = GetObject<Type>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Type.FromPointer); // 0xF8 TypeofBooleanArray          ( ModelClassType Type Type Type Pointer )
            value.TypeofByteArray                           = GetObject<Type>(new IntPtr(p + 0x100), ReversePrism.DataModels.Type.FromPointer); // 0x100 TypeofByteArray             ( ModelClassType Type Type Type Pointer )
            value.TypeofCharArray                           = GetObject<Type>(new IntPtr(p + 0x108), ReversePrism.DataModels.Type.FromPointer); // 0x108 TypeofCharArray             ( ModelClassType Type Type Type Pointer )
            value.TypeofDecimalArray                        = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 0x110 TypeofDecimalArray          ( ModelClassType Type Type Type Pointer )
            value.TypeofDoubleArray                         = GetObject<Type>(new IntPtr(p + 0x118), ReversePrism.DataModels.Type.FromPointer); // 0x118 TypeofDoubleArray           ( ModelClassType Type Type Type Pointer )
            value.TypeofInt16Array                          = GetObject<Type>(new IntPtr(p + 0x120), ReversePrism.DataModels.Type.FromPointer); // 0x120 TypeofInt16Array            ( ModelClassType Type Type Type Pointer )
            value.TypeofInt32Array                          = GetObject<Type>(new IntPtr(p + 0x128), ReversePrism.DataModels.Type.FromPointer); // 0x128 TypeofInt32Array            ( ModelClassType Type Type Type Pointer )
            value.TypeofInt64Array                          = GetObject<Type>(new IntPtr(p + 0x130), ReversePrism.DataModels.Type.FromPointer); // 0x130 TypeofInt64Array            ( ModelClassType Type Type Type Pointer )
            value.TypeofSByteArray                          = GetObject<Type>(new IntPtr(p + 0x138), ReversePrism.DataModels.Type.FromPointer); // 0x138 TypeofSByteArray            ( ModelClassType Type Type Type Pointer )
            value.TypeofSingleArray                         = GetObject<Type>(new IntPtr(p + 0x140), ReversePrism.DataModels.Type.FromPointer); // 0x140 TypeofSingleArray           ( ModelClassType Type Type Type Pointer )
            value.TypeofTimeSpanArray                       = GetObject<Type>(new IntPtr(p + 0x148), ReversePrism.DataModels.Type.FromPointer); // 0x148 TypeofTimeSpanArray         ( ModelClassType Type Type Type Pointer )
            value.TypeofDateTimeArray                       = GetObject<Type>(new IntPtr(p + 0x150), ReversePrism.DataModels.Type.FromPointer); // 0x150 TypeofDateTimeArray         ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt16Array                         = GetObject<Type>(new IntPtr(p + 0x158), ReversePrism.DataModels.Type.FromPointer); // 0x158 TypeofUInt16Array           ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt32Array                         = GetObject<Type>(new IntPtr(p + 0x160), ReversePrism.DataModels.Type.FromPointer); // 0x160 TypeofUInt32Array           ( ModelClassType Type Type Type Pointer )
            value.TypeofUInt64Array                         = GetObject<Type>(new IntPtr(p + 0x168), ReversePrism.DataModels.Type.FromPointer); // 0x168 TypeofUInt64Array           ( ModelClassType Type Type Type Pointer )
            value.TypeofMarshalByRefObject                  = GetObject<Type>(new IntPtr(p + 0x170), ReversePrism.DataModels.Type.FromPointer); // 0x170 TypeofMarshalByRefObject    ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
