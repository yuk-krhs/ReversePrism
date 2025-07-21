using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 CurrentTag                               ModelPrimitiveType string string string String
    // 0C8 IsActiveGetter                           ModelClassType Getter Getter Getter Pointer
    // 0D0 NameGetter                               ModelClassType Getter Getter Getter Pointer
    // 0D8 TagGetter                                ModelClassType Getter Getter Getter Pointer
    // 0E0 IsActiveSetter                           ModelClassType Setter Setter Setter Pointer
    // 0E8 NameSetter                               ModelClassType Setter Setter Setter Pointer
    // 0F0 TagSetter                                ModelClassType Setter Setter Setter Pointer
    // 0F8 LayerProp                                ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 100 Components                               ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer
    // 108 ComponentsExpandedStates                 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    // 110 AddComponentTypes                        ModelClassListType Type[] Type[] List<Type> Pointer
    // 000 addComponentMethod                       ExposedMethod IL2CPP_TYPE_VALUETYPE
    // 018 RemoveComponentMethod                    ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32
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

            value.CurrentTag                                = GetString(new IntPtr(p + 0x0C0)); // 0xC0 CurrentTag                  ( ModelPrimitiveType string string string String )
            value.IsActiveGetter                            = GetObject<Getter>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Getter.FromPointer); // 0xC8 IsActiveGetter              ( ModelClassType Getter Getter Getter Pointer )
            value.NameGetter                                = GetObject<Getter>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Getter.FromPointer); // 0xD0 NameGetter                  ( ModelClassType Getter Getter Getter Pointer )
            value.TagGetter                                 = GetObject<Getter>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Getter.FromPointer); // 0xD8 TagGetter                   ( ModelClassType Getter Getter Getter Pointer )
            value.IsActiveSetter                            = GetObject<Setter>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Setter.FromPointer); // 0xE0 IsActiveSetter              ( ModelClassType Setter Setter Setter Pointer )
            value.NameSetter                                = GetObject<Setter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Setter.FromPointer); // 0xE8 NameSetter                  ( ModelClassType Setter Setter Setter Pointer )
            value.TagSetter                                 = GetObject<Setter>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Setter.FromPointer); // 0xF0 TagSetter                   ( ModelClassType Setter Setter Setter Pointer )
            value.LayerProp                                 = GetObject<PropertyInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xF8 LayerProp                   ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.Components                                = GetObjectList<Component>(new IntPtr(p + 0x100), ReversePrism.DataModels.Component.FromPointer); // 0x100 Components                  ( ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer )
            value.ComponentsExpandedStates                  = GetBoolList(new IntPtr(p + 0x108)); // 0x108 ComponentsExpandedStates    ( ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )
            value.AddComponentTypes                         = GetObjectList<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 0x110 AddComponentTypes           ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.RemoveComponentMethod                     = (ExposedMethod)GetInt32(new IntPtr(p + 0x018)); // 0x18 RemoveComponentMethod       ( ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32 )

            return value;
        }
    }
}
