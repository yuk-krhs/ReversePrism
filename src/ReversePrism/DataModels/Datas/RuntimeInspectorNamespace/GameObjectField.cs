using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 CurrentTag                               000186671910 ModelPrimitiveType string string string String
    // 0C8 IsActiveGetter                           000186640A10 ModelClassType Getter Getter Getter Pointer
    // 0D0 NameGetter                               000186640A10 ModelClassType Getter Getter Getter Pointer
    // 0D8 TagGetter                                000186640A10 ModelClassType Getter Getter Getter Pointer
    // 0E0 IsActiveSetter                           000186640ED0 ModelClassType Setter Setter Setter Pointer
    // 0E8 NameSetter                               000186640ED0 ModelClassType Setter Setter Setter Pointer
    // 0F0 TagSetter                                000186640ED0 ModelClassType Setter Setter Setter Pointer
    // 0F8 LayerProp                                0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 100 Components                               000185CD3FB8 ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer
    // 108 ComponentsExpandedStates                 000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    // 110 AddComponentTypes                        000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 000 addComponentMethod                       ExposedMethod IL2CPP_TYPE_VALUETYPE
    // 018 RemoveComponentMethod                    0001865296B0 ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32
    public partial class GameObjectField : DataModel
    {
        public string                                   CurrentTag                              { get; set; }
        public Getter?                                  IsActiveGetter                          { get; set; }
        public Getter?                                  NameGetter                              { get; set; }
        public Getter?                                  TagGetter                               { get; set; }
        public Setter?                                  IsActiveSetter                          { get; set; }
        public Setter?                                  NameSetter                              { get; set; }
        public Setter?                                  TagSetter                               { get; set; }
        public PropertyInfo?                            LayerProp                               { get; set; }
        public List<Component>?                         Components                              { get; set; }
        public List<bool>?                              ComponentsExpandedStates                { get; set; }
        public List<Type>?                              AddComponentTypes                       { get; set; }
        public ExposedMethod                            RemoveComponentMethod                   { get; set; }

        public static GameObjectField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameObjectField() { Pointer= p0 };

            value.CurrentTag                                = GetString(new IntPtr(p + 0x0C0)); // 02466B2413F8 0xC0 CurrentTag                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsActiveGetter                            = GetObject<Getter>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Getter.FromPointer); // 02466B241418 0xC8 IsActiveGetter              ( 000186640A10 ModelClassType Getter Getter Getter Pointer )
            value.NameGetter                                = GetObject<Getter>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Getter.FromPointer); // 02466B241438 0xD0 NameGetter                  ( 000186640A10 ModelClassType Getter Getter Getter Pointer )
            value.TagGetter                                 = GetObject<Getter>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Getter.FromPointer); // 02466B241458 0xD8 TagGetter                   ( 000186640A10 ModelClassType Getter Getter Getter Pointer )
            value.IsActiveSetter                            = GetObject<Setter>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Setter.FromPointer); // 02466B241478 0xE0 IsActiveSetter              ( 000186640ED0 ModelClassType Setter Setter Setter Pointer )
            value.NameSetter                                = GetObject<Setter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Setter.FromPointer); // 02466B241498 0xE8 NameSetter                  ( 000186640ED0 ModelClassType Setter Setter Setter Pointer )
            value.TagSetter                                 = GetObject<Setter>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Setter.FromPointer); // 02466B2414B8 0xF0 TagSetter                   ( 000186640ED0 ModelClassType Setter Setter Setter Pointer )
            value.LayerProp                                 = GetObject<PropertyInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 02466B2414D8 0xF8 LayerProp                   ( 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.Components                                = GetObjectList<Component>(new IntPtr(p + 0x100), ReversePrism.DataModels.Component.FromPointer); // 02466B2414F8 0x100 Components                  ( 000185CD3FB8 ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer )
            value.ComponentsExpandedStates                  = GetBoolList(new IntPtr(p + 0x108)); // 02466B241518 0x108 ComponentsExpandedStates    ( 000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )
            value.AddComponentTypes                         = GetObjectList<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 02466B241538 0x110 AddComponentTypes           ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.RemoveComponentMethod                     = (ExposedMethod)GetInt32(new IntPtr(p + 0x018)); // 02466B241578 0x18 RemoveComponentMethod       ( 0001865296B0 ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32 )

            return value;
        }
    }
}
