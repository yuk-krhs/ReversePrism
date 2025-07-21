using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 typeToVariables                          Dictionary`2<Type, MemberInfo[]> IL2CPP_TYPE_GENERICINST
    // 008 typeToExposedMethods                     Dictionary`2<Type, ExposedMethod[]> IL2CPP_TYPE_GENERICINST
    // 010 commonSerializableTypes                  HashSet`1<Type> IL2CPP_TYPE_GENERICINST
    // 018 ValidVariablesList                       ModelClassListType List`1<MemberInfo> List`1<MemberInfo> List<MemberInfo> Pointer
    // 020 TypesToSearchForVariablesList            ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer
    // 028 PropertyNamesInVariablesList             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 030 ExposedMethodsList                       ModelEnumListType List`1<ExposedMethod> List`1<ExposedMethod> List<ExposedMethod> Pointer
    // 038 ExposedExtensionMethods                  ModelEnumListType List`1<ExposedExtensionMethodHolder> List`1<ExposedExtensionMethodHolder> List<ExposedExtensionMethodHolder> Pointer
    // 040 customEditors                            Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 048 CustomEditorAttributes                   ModelClassListType List`1<RuntimeInspectorCustomEditorAttribute> List`1<RuntimeInspectorCustomEditorAttribute> List<RuntimeInspectorCustomEditorAttribute> Pointer
    // 050 IgnoredTransformsInHierarchy             HashSet`1<Transform> IL2CPP_TYPE_GENERICINST
    // 058 PopupCanvas                              ModelClassType Canvas Canvas Canvas Pointer
    // 060 PopupReferenceCanvas                     ModelClassType Canvas Canvas Canvas Pointer
    // 068 TooltipPopup                             ModelClassType Tooltip Tooltip Tooltip Pointer
    // 070 draggedReferenceItemsPool                Stack`1<DraggedReferenceItem> IL2CPP_TYPE_GENERICINST
    // 078 NumberFormat                             ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer
    // 080 StringBuilder                            ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    public partial class RuntimeInspectorUtils : DataModel
    {
        public List<MemberInfo>?                        ValidVariablesList                      { get; set; }
        public List<Type>?                              TypesToSearchForVariablesList           { get; set; }
        public List<string>?                            PropertyNamesInVariablesList            { get; set; }
        public List<ExposedMethod>?                     ExposedMethodsList                      { get; set; }
        public List<ExposedExtensionMethodHolder>?      ExposedExtensionMethods                 { get; set; }
        public List<RuntimeInspectorCustomEditorAttribute>? CustomEditorAttributes                  { get; set; }
        public Canvas?                                  PopupCanvas                             { get; set; }
        public Canvas?                                  PopupReferenceCanvas                    { get; set; }
        public Tooltip?                                 TooltipPopup                            { get; set; }
        public NumberFormatInfo?                        NumberFormat                            { get; set; }
        public StringBuilder?                           StringBuilder                           { get; set; }

        public static RuntimeInspectorUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInspectorUtils() { Pointer= p0 };

            value.ValidVariablesList                        = GetObjectList<MemberInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x18 ValidVariablesList          ( ModelClassListType List`1<MemberInfo> List`1<MemberInfo> List<MemberInfo> Pointer )
            value.TypesToSearchForVariablesList             = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 TypesToSearchForVariablesList ( ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer )
            value.PropertyNamesInVariablesList              = GetStringList(new IntPtr(p + 0x028)); // 0x28 PropertyNamesInVariablesList ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.ExposedMethodsList                        = GetEnumList<ExposedMethod>(new IntPtr(p + 0x030)); // 0x30 ExposedMethodsList          ( ModelEnumListType List`1<ExposedMethod> List`1<ExposedMethod> List<ExposedMethod> Pointer )
            value.ExposedExtensionMethods                   = GetEnumList<ExposedExtensionMethodHolder>(new IntPtr(p + 0x038)); // 0x38 ExposedExtensionMethods     ( ModelEnumListType List`1<ExposedExtensionMethodHolder> List`1<ExposedExtensionMethodHolder> List<ExposedExtensionMethodHolder> Pointer )
            value.CustomEditorAttributes                    = GetObjectList<RuntimeInspectorCustomEditorAttribute>(new IntPtr(p + 0x048), ReversePrism.DataModels.RuntimeInspectorCustomEditorAttribute.FromPointer); // 0x48 CustomEditorAttributes      ( ModelClassListType List`1<RuntimeInspectorCustomEditorAttribute> List`1<RuntimeInspectorCustomEditorAttribute> List<RuntimeInspectorCustomEditorAttribute> Pointer )
            value.PopupCanvas                               = GetObject<Canvas>(new IntPtr(p + 0x058), ReversePrism.DataModels.Canvas.FromPointer); // 0x58 PopupCanvas                 ( ModelClassType Canvas Canvas Canvas Pointer )
            value.PopupReferenceCanvas                      = GetObject<Canvas>(new IntPtr(p + 0x060), ReversePrism.DataModels.Canvas.FromPointer); // 0x60 PopupReferenceCanvas        ( ModelClassType Canvas Canvas Canvas Pointer )
            value.TooltipPopup                              = GetObject<Tooltip>(new IntPtr(p + 0x068), ReversePrism.DataModels.Tooltip.FromPointer); // 0x68 TooltipPopup                ( ModelClassType Tooltip Tooltip Tooltip Pointer )
            value.NumberFormat                              = GetObject<NumberFormatInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.NumberFormatInfo.FromPointer); // 0x78 NumberFormat                ( ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer )
            value.StringBuilder                             = GetObject<StringBuilder>(new IntPtr(p + 0x080), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x80 StringBuilder               ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )

            return value;
        }
    }
}
