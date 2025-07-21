using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultVariant                         InternedString IL2CPP_TYPE_VALUETYPE
    // 000 VariantSeparator                         string IL2CPP_TYPE_STRING
    // 010 M_Name                                   ModelEnumType InternedString InternedString InternedString Int32
    // 020 M_Type                                   ModelClassType Type Type Type Pointer
    // 028 M_Variants                               ModelEnumType InternedString InternedString InternedString Int32
    // 038 M_StateFormat                            ModelEnumType FourCC FourCC FourCC Int32
    // 03C M_StateSizeInBytes                       ModelPrimitiveType int int int Int32
    // 040 m_UpdateBeforeRender                     Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 m_BaseLayouts                            InlinedArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 068 m_AppliedOverrides                       InlinedArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 088 M_CommonUsages                           ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer
    // 090 M_Controls                               ModelEnumListType ControlItem[] ControlItem[] List<ControlItem> Pointer
    // 098 M_DisplayName                            ModelPrimitiveType string string string String
    // 0A0 M_Description                            ModelPrimitiveType string string string String
    // 0A8 M_Flags                                  ModelEnumType Flags Flags Flags Int32
    // 010 S_Layouts                                ModelEnumType Collection Collection Collection Int32
    // 050 S_CacheInstance                          ModelEnumType Cache Cache Cache Int32
    // 058 S_CacheInstanceRef                       ModelPrimitiveType int int int Int32
    public partial class InputControlLayout : DataModel
    {
        public InternedString                           M_Name                                  { get; set; }
        public Type?                                    M_Type                                  { get; set; }
        public InternedString                           M_Variants                              { get; set; }
        public FourCC                                   M_StateFormat                           { get; set; }
        public int                                      M_StateSizeInBytes                      { get; set; }
        public List<InternedString>?                    M_CommonUsages                          { get; set; }
        public List<ControlItem>?                       M_Controls                              { get; set; }
        public string                                   M_DisplayName                           { get; set; }
        public string                                   M_Description                           { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public Collection                               S_Layouts                               { get; set; }
        public Cache                                    S_CacheInstance                         { get; set; }
        public int                                      S_CacheInstanceRef                      { get; set; }

        public static InputControlLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControlLayout() { Pointer= p0 };

            value.M_Name                                    = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Type                                    = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 M_Type                      ( ModelClassType Type Type Type Pointer )
            value.M_Variants                                = (InternedString)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Variants                  ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_StateFormat                             = (FourCC)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_StateFormat               ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.M_StateSizeInBytes                        = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_StateSizeInBytes          ( ModelPrimitiveType int int int Int32 )
            value.M_CommonUsages                            = GetEnumList<InternedString>(new IntPtr(p + 0x088)); // 0x88 M_CommonUsages              ( ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer )
            value.M_Controls                                = GetEnumList<ControlItem>(new IntPtr(p + 0x090)); // 0x90 M_Controls                  ( ModelEnumListType ControlItem[] ControlItem[] List<ControlItem> Pointer )
            value.M_DisplayName                             = GetString(new IntPtr(p + 0x098)); // 0x98 M_DisplayName               ( ModelPrimitiveType string string string String )
            value.M_Description                             = GetString(new IntPtr(p + 0x0A0)); // 0xA0 M_Description               ( ModelPrimitiveType string string string String )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_Flags                     ( ModelEnumType Flags Flags Flags Int32 )
            value.S_Layouts                                 = (Collection)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_Layouts                   ( ModelEnumType Collection Collection Collection Int32 )
            value.S_CacheInstance                           = (Cache)GetInt32(new IntPtr(p + 0x050)); // 0x50 S_CacheInstance             ( ModelEnumType Cache Cache Cache Int32 )
            value.S_CacheInstanceRef                        = GetInt32(new IntPtr(p + 0x058)); // 0x58 S_CacheInstanceRef          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
