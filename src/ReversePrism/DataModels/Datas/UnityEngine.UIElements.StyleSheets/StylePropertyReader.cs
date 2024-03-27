using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 getCursorIdFunc                          GetCursorIdFunction IL2CPP_TYPE_CLASS
    // 010 M_Values                                 000185D0E4D8 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer
    // 018 M_ValueCount                             000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 M_Resolver                               0001865D1F90 ModelClassType StyleVariableResolver StyleVariableResolver StyleVariableResolver Pointer
    // 028 M_Sheet                                  0001865CD5E0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 030 M_Properties                             000185CA7728 ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer
    // 038 M_PropertyIds                            000185CA7908 ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer
    // 040 M_CurrentValueIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_CurrentPropertyIndex                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 Property                                 0001865C9050 ModelClassType StyleProperty StyleProperty StyleProperty Pointer
    // 050 PropertyId                               0001865C9870 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 054 ValueCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 DpiScaling                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class StylePropertyReader
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
            var value   = new StylePropertyReader();

            value.M_Values                                  = GetEnumList<StylePropertyValue>(new IntPtr(p + 0x010)); // 027006886228 0x10 M_Values                    ( 000185D0E4D8 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer )
            value.M_ValueCount                              = GetInt32List(new IntPtr(p + 0x018)); // 027006886248 0x18 M_ValueCount                ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_Resolver                                = GetObject<StyleVariableResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.StyleVariableResolver.FromPointer); // 027006886268 0x20 M_Resolver                  ( 0001865D1F90 ModelClassType StyleVariableResolver StyleVariableResolver StyleVariableResolver Pointer )
            value.M_Sheet                                   = GetObject<StyleSheet>(new IntPtr(p + 0x028), ReversePrism.DataModels.StyleSheet.FromPointer); // 027006886288 0x28 M_Sheet                     ( 0001865CD5E0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.M_Properties                              = GetObjectList<StyleProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.StyleProperty.FromPointer); // 0270068862A8 0x30 M_Properties                ( 000185CA7728 ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer )
            value.M_PropertyIds                             = GetEnumList<StylePropertyId>(new IntPtr(p + 0x038)); // 0270068862C8 0x38 M_PropertyIds               ( 000185CA7908 ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer )
            value.M_CurrentValueIndex                       = GetInt32(new IntPtr(p + 0x040)); // 0270068862E8 0x40 M_CurrentValueIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentPropertyIndex                    = GetInt32(new IntPtr(p + 0x044)); // 027006886308 0x44 M_CurrentPropertyIndex      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Property                                  = GetObject<StyleProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.StyleProperty.FromPointer); // 027006886328 0x48 Property                    ( 0001865C9050 ModelClassType StyleProperty StyleProperty StyleProperty Pointer )
            value.PropertyId                                = (StylePropertyId)GetInt32(new IntPtr(p + 0x050)); // 027006886348 0x50 PropertyId                  ( 0001865C9870 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.ValueCount                                = GetInt32(new IntPtr(p + 0x054)); // 027006886368 0x54 ValueCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DpiScaling                                = GetSingle(new IntPtr(p + 0x058)); // 027006886388 0x58 DpiScaling                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
