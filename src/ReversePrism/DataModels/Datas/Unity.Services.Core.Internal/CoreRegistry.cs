using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Instance>k__BackingField                CoreRegistry IL2CPP_TYPE_CLASS
    // 010 InstanceId                               ModelPrimitiveType string string string String
    // 018 Type                                     ModelEnumType ServicesType ServicesType ServicesType Int32
    // 020 Options                                  ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer
    // 028 PackageRegistry                          ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer
    // 030 ComponentRegistry                        ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer
    // 038 ServiceRegistry                          ModelClassType IServiceRegistry IServiceRegistry IServiceRegistry Pointer
    public partial class CoreRegistry : DataModel
    {
        public string                                   InstanceId                              { get; set; }
        public ServicesType                             Type                                    { get; set; }
        public InitializationOptions?                   Options                                 { get; set; }
        public IPackageRegistry?                        PackageRegistry                         { get; set; }
        public IComponentRegistry?                      ComponentRegistry                       { get; set; }
        public IServiceRegistry?                        ServiceRegistry                         { get; set; }

        public static CoreRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreRegistry() { Pointer= p0 };

            value.InstanceId                                = GetString(new IntPtr(p + 0x010)); // 0x10 InstanceId                  ( ModelPrimitiveType string string string String )
            value.Type                                      = (ServicesType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ServicesType ServicesType ServicesType Int32 )
            value.Options                                   = GetObject<InitializationOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.InitializationOptions.FromPointer); // 0x20 Options                     ( ModelClassType InitializationOptions InitializationOptions InitializationOptions Pointer )
            value.PackageRegistry                           = GetObject<IPackageRegistry>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPackageRegistry.FromPointer); // 0x28 PackageRegistry             ( ModelClassType IPackageRegistry IPackageRegistry IPackageRegistry Pointer )
            value.ComponentRegistry                         = GetObject<IComponentRegistry>(new IntPtr(p + 0x030), ReversePrism.DataModels.IComponentRegistry.FromPointer); // 0x30 ComponentRegistry           ( ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer )
            value.ServiceRegistry                           = GetObject<IServiceRegistry>(new IntPtr(p + 0x038), ReversePrism.DataModels.IServiceRegistry.FromPointer); // 0x38 ServiceRegistry             ( ModelClassType IServiceRegistry IServiceRegistry IServiceRegistry Pointer )

            return value;
        }
    }
}
