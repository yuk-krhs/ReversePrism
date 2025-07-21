using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 getCursorIdFunc                          GetCursorIdFunction IL2CPP_TYPE_CLASS
    // 010 M_Values                                 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer
    // 018 M_ValueCount                             ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 M_Resolver                               ModelClassType StyleVariableResolver StyleVariableResolver StyleVariableResolver Pointer
    // 028 M_Sheet                                  ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 030 M_Properties                             ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer
    // 038 M_PropertyIds                            ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer
    // 040 M_CurrentValueIndex                      ModelPrimitiveType int int int Int32
    // 044 M_CurrentPropertyIndex                   ModelPrimitiveType int int int Int32
    // 048 Property                                 ModelClassType StyleProperty StyleProperty StyleProperty Pointer
    // 050 PropertyId                               ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 054 ValueCount                               ModelPrimitiveType int int int Int32
    // 058 DpiScaling                               ModelPrimitiveType float float float Single
    public partial class StylePropertyReader : DataModel
    {
        public List<StylePropertyValue>?                M_Values                                { get; set; }
        public List<int>?                               M_ValueCount                            { get; set; }
        public StyleVariableResolver?                   M_Resolver                              { get; set; }
        public StyleSheet?                              M_Sheet                                 { get; set; }
        public List<StyleProperty>?                     M_Properties                            { get; set; }
        public List<StylePropertyId>?                   M_PropertyIds                           { get; set; }
        public int                                      M_CurrentValueIndex                     { get; set; }
        public int                                      M_CurrentPropertyIndex                  { get; set; }
        public StyleProperty?                           Property                                { get; set; }
        public StylePropertyId                          PropertyId                              { get; set; }
        public int                                      ValueCount                              { get; set; }
        public float                                    DpiScaling                              { get; set; }

        public static StylePropertyReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyReader() { Pointer= p0 };

            value.M_Values                                  = GetEnumList<StylePropertyValue>(new IntPtr(p + 0x010)); // 0x10 M_Values                    ( ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer )
            value.M_ValueCount                              = GetInt32List(new IntPtr(p + 0x018)); // 0x18 M_ValueCount                ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_Resolver                                = GetObject<StyleVariableResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.StyleVariableResolver.FromPointer); // 0x20 M_Resolver                  ( ModelClassType StyleVariableResolver StyleVariableResolver StyleVariableResolver Pointer )
            value.M_Sheet                                   = GetObject<StyleSheet>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x28 M_Sheet                     ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.M_Properties                              = GetObjectList<StyleProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.StyleProperty.FromPointer); // 0x30 M_Properties                ( ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer )
            value.M_PropertyIds                             = GetEnumList<StylePropertyId>(new IntPtr(p + 0x038)); // 0x38 M_PropertyIds               ( ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer )
            value.M_CurrentValueIndex                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_CurrentValueIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentPropertyIndex                    = GetInt32(new IntPtr(p + 0x044)); // 0x44 M_CurrentPropertyIndex      ( ModelPrimitiveType int int int Int32 )
            value.Property                                  = GetObject<StyleProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.StyleProperty.FromPointer); // 0x48 Property                    ( ModelClassType StyleProperty StyleProperty StyleProperty Pointer )
            value.PropertyId                                = (StylePropertyId)GetInt32(new IntPtr(p + 0x050)); // 0x50 PropertyId                  ( ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.ValueCount                                = GetInt32(new IntPtr(p + 0x054)); // 0x54 ValueCount                  ( ModelPrimitiveType int int int Int32 )
            value.DpiScaling                                = GetSingle(new IntPtr(p + 0x058)); // 0x58 DpiScaling                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
