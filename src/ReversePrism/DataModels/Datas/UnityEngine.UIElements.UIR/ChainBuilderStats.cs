using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementsAdded                            ModelPrimitiveType uint uint uint UInt32
    // 014 ElementsRemoved                          ModelPrimitiveType uint uint uint UInt32
    // 018 RecursiveClipUpdates                     ModelPrimitiveType uint uint uint UInt32
    // 01C RecursiveClipUpdatesExpanded             ModelPrimitiveType uint uint uint UInt32
    // 020 NonRecursiveClipUpdates                  ModelPrimitiveType uint uint uint UInt32
    // 024 RecursiveTransformUpdates                ModelPrimitiveType uint uint uint UInt32
    // 028 RecursiveTransformUpdatesExpanded        ModelPrimitiveType uint uint uint UInt32
    // 02C RecursiveOpacityUpdates                  ModelPrimitiveType uint uint uint UInt32
    // 030 RecursiveOpacityUpdatesExpanded          ModelPrimitiveType uint uint uint UInt32
    // 034 OpacityIdUpdates                         ModelPrimitiveType uint uint uint UInt32
    // 038 ColorUpdates                             ModelPrimitiveType uint uint uint UInt32
    // 03C ColorUpdatesExpanded                     ModelPrimitiveType uint uint uint UInt32
    // 040 RecursiveVisualUpdates                   ModelPrimitiveType uint uint uint UInt32
    // 044 RecursiveVisualUpdatesExpanded           ModelPrimitiveType uint uint uint UInt32
    // 048 NonRecursiveVisualUpdates                ModelPrimitiveType uint uint uint UInt32
    // 04C DirtyProcessed                           ModelPrimitiveType uint uint uint UInt32
    // 050 NudgeTransformed                         ModelPrimitiveType uint uint uint UInt32
    // 054 BoneTransformed                          ModelPrimitiveType uint uint uint UInt32
    // 058 SkipTransformed                          ModelPrimitiveType uint uint uint UInt32
    // 05C VisualUpdateTransformed                  ModelPrimitiveType uint uint uint UInt32
    // 060 UpdatedMeshAllocations                   ModelPrimitiveType uint uint uint UInt32
    // 064 NewMeshAllocations                       ModelPrimitiveType uint uint uint UInt32
    // 068 GroupTransformElementsChanged            ModelPrimitiveType uint uint uint UInt32
    // 06C ImmedateRenderersActive                  ModelPrimitiveType uint uint uint UInt32
    public partial class ChainBuilderStats : DataModel
    {
        public uint                                     ElementsAdded                           { get; set; }
        public uint                                     ElementsRemoved                         { get; set; }
        public uint                                     RecursiveClipUpdates                    { get; set; }
        public uint                                     RecursiveClipUpdatesExpanded            { get; set; }
        public uint                                     NonRecursiveClipUpdates                 { get; set; }
        public uint                                     RecursiveTransformUpdates               { get; set; }
        public uint                                     RecursiveTransformUpdatesExpanded       { get; set; }
        public uint                                     RecursiveOpacityUpdates                 { get; set; }
        public uint                                     RecursiveOpacityUpdatesExpanded         { get; set; }
        public uint                                     OpacityIdUpdates                        { get; set; }
        public uint                                     ColorUpdates                            { get; set; }
        public uint                                     ColorUpdatesExpanded                    { get; set; }
        public uint                                     RecursiveVisualUpdates                  { get; set; }
        public uint                                     RecursiveVisualUpdatesExpanded          { get; set; }
        public uint                                     NonRecursiveVisualUpdates               { get; set; }
        public uint                                     DirtyProcessed                          { get; set; }
        public uint                                     NudgeTransformed                        { get; set; }
        public uint                                     BoneTransformed                         { get; set; }
        public uint                                     SkipTransformed                         { get; set; }
        public uint                                     VisualUpdateTransformed                 { get; set; }
        public uint                                     UpdatedMeshAllocations                  { get; set; }
        public uint                                     NewMeshAllocations                      { get; set; }
        public uint                                     GroupTransformElementsChanged           { get; set; }
        public uint                                     ImmedateRenderersActive                 { get; set; }

        public static ChainBuilderStats? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainBuilderStats() { Pointer= p0 };

            value.ElementsAdded                             = GetUInt32(new IntPtr(p + 0x010)); // 0x10 ElementsAdded               ( ModelPrimitiveType uint uint uint UInt32 )
            value.ElementsRemoved                           = GetUInt32(new IntPtr(p + 0x014)); // 0x14 ElementsRemoved             ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveClipUpdates                      = GetUInt32(new IntPtr(p + 0x018)); // 0x18 RecursiveClipUpdates        ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveClipUpdatesExpanded              = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C RecursiveClipUpdatesExpanded ( ModelPrimitiveType uint uint uint UInt32 )
            value.NonRecursiveClipUpdates                   = GetUInt32(new IntPtr(p + 0x020)); // 0x20 NonRecursiveClipUpdates     ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveTransformUpdates                 = GetUInt32(new IntPtr(p + 0x024)); // 0x24 RecursiveTransformUpdates   ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveTransformUpdatesExpanded         = GetUInt32(new IntPtr(p + 0x028)); // 0x28 RecursiveTransformUpdatesExpanded ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveOpacityUpdates                   = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C RecursiveOpacityUpdates     ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveOpacityUpdatesExpanded           = GetUInt32(new IntPtr(p + 0x030)); // 0x30 RecursiveOpacityUpdatesExpanded ( ModelPrimitiveType uint uint uint UInt32 )
            value.OpacityIdUpdates                          = GetUInt32(new IntPtr(p + 0x034)); // 0x34 OpacityIdUpdates            ( ModelPrimitiveType uint uint uint UInt32 )
            value.ColorUpdates                              = GetUInt32(new IntPtr(p + 0x038)); // 0x38 ColorUpdates                ( ModelPrimitiveType uint uint uint UInt32 )
            value.ColorUpdatesExpanded                      = GetUInt32(new IntPtr(p + 0x03C)); // 0x3C ColorUpdatesExpanded        ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveVisualUpdates                    = GetUInt32(new IntPtr(p + 0x040)); // 0x40 RecursiveVisualUpdates      ( ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveVisualUpdatesExpanded            = GetUInt32(new IntPtr(p + 0x044)); // 0x44 RecursiveVisualUpdatesExpanded ( ModelPrimitiveType uint uint uint UInt32 )
            value.NonRecursiveVisualUpdates                 = GetUInt32(new IntPtr(p + 0x048)); // 0x48 NonRecursiveVisualUpdates   ( ModelPrimitiveType uint uint uint UInt32 )
            value.DirtyProcessed                            = GetUInt32(new IntPtr(p + 0x04C)); // 0x4C DirtyProcessed              ( ModelPrimitiveType uint uint uint UInt32 )
            value.NudgeTransformed                          = GetUInt32(new IntPtr(p + 0x050)); // 0x50 NudgeTransformed            ( ModelPrimitiveType uint uint uint UInt32 )
            value.BoneTransformed                           = GetUInt32(new IntPtr(p + 0x054)); // 0x54 BoneTransformed             ( ModelPrimitiveType uint uint uint UInt32 )
            value.SkipTransformed                           = GetUInt32(new IntPtr(p + 0x058)); // 0x58 SkipTransformed             ( ModelPrimitiveType uint uint uint UInt32 )
            value.VisualUpdateTransformed                   = GetUInt32(new IntPtr(p + 0x05C)); // 0x5C VisualUpdateTransformed     ( ModelPrimitiveType uint uint uint UInt32 )
            value.UpdatedMeshAllocations                    = GetUInt32(new IntPtr(p + 0x060)); // 0x60 UpdatedMeshAllocations      ( ModelPrimitiveType uint uint uint UInt32 )
            value.NewMeshAllocations                        = GetUInt32(new IntPtr(p + 0x064)); // 0x64 NewMeshAllocations          ( ModelPrimitiveType uint uint uint UInt32 )
            value.GroupTransformElementsChanged             = GetUInt32(new IntPtr(p + 0x068)); // 0x68 GroupTransformElementsChanged ( ModelPrimitiveType uint uint uint UInt32 )
            value.ImmedateRenderersActive                   = GetUInt32(new IntPtr(p + 0x06C)); // 0x6C ImmedateRenderersActive     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
