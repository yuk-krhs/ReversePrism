using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementsAdded                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 ElementsRemoved                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 RecursiveClipUpdates                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C RecursiveClipUpdatesExpanded             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 NonRecursiveClipUpdates                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 RecursiveTransformUpdates                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 RecursiveTransformUpdatesExpanded        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C RecursiveOpacityUpdates                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 030 RecursiveOpacityUpdatesExpanded          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 034 OpacityIdUpdates                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 038 ColorUpdates                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 03C ColorUpdatesExpanded                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 040 RecursiveVisualUpdates                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 044 RecursiveVisualUpdatesExpanded           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 048 NonRecursiveVisualUpdates                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 04C DirtyProcessed                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 050 NudgeTransformed                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 054 BoneTransformed                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 058 SkipTransformed                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 05C VisualUpdateTransformed                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 060 UpdatedMeshAllocations                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 064 NewMeshAllocations                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 068 GroupTransformElementsChanged            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 06C ImmedateRenderersActive                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
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

            value.ElementsAdded                             = GetUInt32(new IntPtr(p + 0x010)); // 0245A682A3E8 0x10 ElementsAdded               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ElementsRemoved                           = GetUInt32(new IntPtr(p + 0x014)); // 0245A682A408 0x14 ElementsRemoved             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveClipUpdates                      = GetUInt32(new IntPtr(p + 0x018)); // 0245A682A428 0x18 RecursiveClipUpdates        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveClipUpdatesExpanded              = GetUInt32(new IntPtr(p + 0x01C)); // 0245A682A448 0x1C RecursiveClipUpdatesExpanded ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NonRecursiveClipUpdates                   = GetUInt32(new IntPtr(p + 0x020)); // 0245A682A468 0x20 NonRecursiveClipUpdates     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveTransformUpdates                 = GetUInt32(new IntPtr(p + 0x024)); // 0245A682A488 0x24 RecursiveTransformUpdates   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveTransformUpdatesExpanded         = GetUInt32(new IntPtr(p + 0x028)); // 0245A682A4A8 0x28 RecursiveTransformUpdatesExpanded ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveOpacityUpdates                   = GetUInt32(new IntPtr(p + 0x02C)); // 0245A682A4C8 0x2C RecursiveOpacityUpdates     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveOpacityUpdatesExpanded           = GetUInt32(new IntPtr(p + 0x030)); // 0245A682A4E8 0x30 RecursiveOpacityUpdatesExpanded ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.OpacityIdUpdates                          = GetUInt32(new IntPtr(p + 0x034)); // 0245A682A508 0x34 OpacityIdUpdates            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ColorUpdates                              = GetUInt32(new IntPtr(p + 0x038)); // 0245A682A528 0x38 ColorUpdates                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ColorUpdatesExpanded                      = GetUInt32(new IntPtr(p + 0x03C)); // 0245A682A548 0x3C ColorUpdatesExpanded        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveVisualUpdates                    = GetUInt32(new IntPtr(p + 0x040)); // 0245A682A568 0x40 RecursiveVisualUpdates      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RecursiveVisualUpdatesExpanded            = GetUInt32(new IntPtr(p + 0x044)); // 0245A682A588 0x44 RecursiveVisualUpdatesExpanded ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NonRecursiveVisualUpdates                 = GetUInt32(new IntPtr(p + 0x048)); // 0245A682A5A8 0x48 NonRecursiveVisualUpdates   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DirtyProcessed                            = GetUInt32(new IntPtr(p + 0x04C)); // 0245A682A5C8 0x4C DirtyProcessed              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NudgeTransformed                          = GetUInt32(new IntPtr(p + 0x050)); // 0245A682A5E8 0x50 NudgeTransformed            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.BoneTransformed                           = GetUInt32(new IntPtr(p + 0x054)); // 0245A682A608 0x54 BoneTransformed             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SkipTransformed                           = GetUInt32(new IntPtr(p + 0x058)); // 0245A682A628 0x58 SkipTransformed             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.VisualUpdateTransformed                   = GetUInt32(new IntPtr(p + 0x05C)); // 0245A682A648 0x5C VisualUpdateTransformed     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UpdatedMeshAllocations                    = GetUInt32(new IntPtr(p + 0x060)); // 0245A682A668 0x60 UpdatedMeshAllocations      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.NewMeshAllocations                        = GetUInt32(new IntPtr(p + 0x064)); // 0245A682A688 0x64 NewMeshAllocations          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.GroupTransformElementsChanged             = GetUInt32(new IntPtr(p + 0x068)); // 0245A682A6A8 0x68 GroupTransformElementsChanged ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ImmedateRenderersActive                   = GetUInt32(new IntPtr(p + 0x06C)); // 0245A682A6C8 0x6C ImmedateRenderersActive     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
