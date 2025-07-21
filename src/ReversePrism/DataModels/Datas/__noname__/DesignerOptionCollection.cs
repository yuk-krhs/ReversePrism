using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType DesignerOptionService DesignerOptionService DesignerOptionService Pointer
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 028 Children                                 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 Properties                               ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    public partial class DesignerOptionCollection : DataModel
    {
        public DesignerOptionService?                   Service                                 { get; set; }
        public string                                   Name                                    { get; set; }
        public ArrayList?                               Children                                { get; set; }
        public PropertyDescriptorCollection?            Properties                              { get; set; }

        public static DesignerOptionCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DesignerOptionCollection() { Pointer= p0 };

            value.Service                                   = GetObject<DesignerOptionService>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignerOptionService.FromPointer); // 0x10 Service                     ( ModelClassType DesignerOptionService DesignerOptionService DesignerOptionService Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Children                                  = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 Children                    ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Properties                                = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 0x30 Properties                  ( ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )

            return value;
        }
    }
}
