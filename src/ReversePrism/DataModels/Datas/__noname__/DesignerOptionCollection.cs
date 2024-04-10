using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  0001866C7DE0 ModelClassType DesignerOptionService DesignerOptionService DesignerOptionService Pointer
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 028 Children                                 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 Properties                               0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
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

            value.Service                                   = GetObject<DesignerOptionService>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignerOptionService.FromPointer); // 024667BA6538 0x10 Service                     ( 0001866C7DE0 ModelClassType DesignerOptionService DesignerOptionService DesignerOptionService Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 024667BA6558 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Children                                  = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 024667BA6598 0x28 Children                    ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Properties                                = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 024667BA65B8 0x30 Properties                  ( 0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )

            return value;
        }
    }
}
