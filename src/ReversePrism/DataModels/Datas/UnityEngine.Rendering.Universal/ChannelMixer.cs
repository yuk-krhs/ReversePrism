using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RedOutRedIn                              ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 040 RedOutGreenIn                            ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 048 RedOutBlueIn                             ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 050 GreenOutRedIn                            ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 GreenOutGreenIn                          ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 060 GreenOutBlueIn                           ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 068 BlueOutRedIn                             ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 070 BlueOutGreenIn                           ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 078 BlueOutBlueIn                            ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class ChannelMixer : DataModel
    {
        public ClampedFloatParameter?                   RedOutRedIn                             { get; set; }
        public ClampedFloatParameter?                   RedOutGreenIn                           { get; set; }
        public ClampedFloatParameter?                   RedOutBlueIn                            { get; set; }
        public ClampedFloatParameter?                   GreenOutRedIn                           { get; set; }
        public ClampedFloatParameter?                   GreenOutGreenIn                         { get; set; }
        public ClampedFloatParameter?                   GreenOutBlueIn                          { get; set; }
        public ClampedFloatParameter?                   BlueOutRedIn                            { get; set; }
        public ClampedFloatParameter?                   BlueOutGreenIn                          { get; set; }
        public ClampedFloatParameter?                   BlueOutBlueIn                           { get; set; }

        public static ChannelMixer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelMixer() { Pointer= p0 };

            value.RedOutRedIn                               = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x38 RedOutRedIn                 ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.RedOutGreenIn                             = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 RedOutGreenIn               ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.RedOutBlueIn                              = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 RedOutBlueIn                ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.GreenOutRedIn                             = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 GreenOutRedIn               ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.GreenOutGreenIn                           = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x58 GreenOutGreenIn             ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.GreenOutBlueIn                            = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x60 GreenOutBlueIn              ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.BlueOutRedIn                              = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x68 BlueOutRedIn                ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.BlueOutGreenIn                            = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x70 BlueOutGreenIn              ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.BlueOutBlueIn                             = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x78 BlueOutBlueIn               ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
