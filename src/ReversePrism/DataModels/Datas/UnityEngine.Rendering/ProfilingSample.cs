using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Cmd                                    0001865E01D0 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 018 M_Name                                   000186672F10 ModelPrimitiveType string string string String
    // 020 M_Disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_Sampler                                00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    public partial class ProfilingSample
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
            var value   = new ProfilingSample();

            value.M_Cmd                                     = GetObject<CommandBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0270D91A8D38 0x10 M_Cmd                       ( 0001865E01D0 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_Name                                    = GetString(new IntPtr(p + 0x018)); // 0270D91A8D58 0x18 M_Name                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x020)); // 0270D91A8D78 0x20 M_Disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Sampler                                 = GetObject<CustomSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CustomSampler.FromPointer); // 0270D91A8D98 0x28 M_Sampler                   ( 00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer )

            return value;
        }
    }
}
