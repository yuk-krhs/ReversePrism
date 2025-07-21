using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Cmd                                    ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 018 M_Name                                   ModelPrimitiveType string string string String
    // 020 M_Disposed                               ModelPrimitiveType bool bool bool Bool
    // 028 M_Sampler                                ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    public partial class ProfilingSample : DataModel
    {
        public CommandBuffer?                           M_Cmd                                   { get; set; }
        public string                                   M_Name                                  { get; set; }
        public bool                                     M_Disposed                              { get; set; }
        public CustomSampler?                           M_Sampler                               { get; set; }

        public static ProfilingSample? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilingSample() { Pointer= p0 };

            value.M_Cmd                                     = GetObject<CommandBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x10 M_Cmd                       ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_Name                                    = GetString(new IntPtr(p + 0x018)); // 0x18 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x020)); // 0x20 M_Disposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Sampler                                 = GetObject<CustomSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CustomSampler.FromPointer); // 0x28 M_Sampler                   ( ModelClassType CustomSampler CustomSampler CustomSampler Pointer )

            return value;
        }
    }
}
