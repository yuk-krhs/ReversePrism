using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLayerID                             ModelPrimitiveType int int int Int32
    // 014 EndLayerValue                            ModelPrimitiveType int int int Int32
    // 018 LayerRange                               ModelEnumType SortingLayerRange SortingLayerRange SortingLayerRange Int32
    // 01C LightStats                               ModelEnumType LightStats LightStats LightStats Int32
    // 030 RenderTargetIds                          ModelEnumType <renderTargetIds>e__FixedBuffer <renderTargetIds>e__FixedBuffer <renderTargetIds>e__FixedBuffer Int32
    // 040 RenderTargetUsed                         ModelEnumType <renderTargetUsed>e__FixedBuffer <renderTargetUsed>e__FixedBuffer <renderTargetUsed>e__FixedBuffer Int32
    public partial class LayerBatch : DataModel
    {
        public int                                      StartLayerID                            { get; set; }
        public int                                      EndLayerValue                           { get; set; }
        public SortingLayerRange                        LayerRange                              { get; set; }
        public LightStats                               LightStats                              { get; set; }
        public <renderTargetIds>e__FixedBuffer          RenderTargetIds                         { get; set; }
        public <renderTargetUsed>e__FixedBuffer         RenderTargetUsed                        { get; set; }

        public static LayerBatch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayerBatch() { Pointer= p0 };

            value.StartLayerID                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartLayerID                ( ModelPrimitiveType int int int Int32 )
            value.EndLayerValue                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 EndLayerValue               ( ModelPrimitiveType int int int Int32 )
            value.LayerRange                                = (SortingLayerRange)GetInt32(new IntPtr(p + 0x018)); // 0x18 LayerRange                  ( ModelEnumType SortingLayerRange SortingLayerRange SortingLayerRange Int32 )
            value.LightStats                                = (LightStats)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LightStats                  ( ModelEnumType LightStats LightStats LightStats Int32 )
            value.RenderTargetIds                           = (<renderTargetIds>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0x30 RenderTargetIds             ( ModelEnumType <renderTargetIds>e__FixedBuffer <renderTargetIds>e__FixedBuffer <renderTargetIds>e__FixedBuffer Int32 )
            value.RenderTargetUsed                          = (<renderTargetUsed>e__FixedBuffer)GetInt32(new IntPtr(p + 0x040)); // 0x40 RenderTargetUsed            ( ModelEnumType <renderTargetUsed>e__FixedBuffer <renderTargetUsed>e__FixedBuffer <renderTargetUsed>e__FixedBuffer Int32 )

            return value;
        }
    }
}
