using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxAtlasSize                             0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MaxImageWidth                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MaxImageHeight                           0001865F4260 ModelPrimitiveType int int int Int32
    // 01C VirtualWidth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 VirtualHeight                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 PhysicalWidth                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 PhysicalHeight                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_FirstUnpartitionedArea                 00018665FF30 ModelClassType AreaNode AreaNode AreaNode Pointer
    // 038 M_OpenRows                               000185CC4A38 ModelClassListType Row[] Row[] List<Row> Pointer
    // 040 M_1SidePadding                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_2SidePadding                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 s_MarkerTryAllocate                      ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 048 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UIRAtlasAllocator : DataModel
    {
        public int                                      MaxAtlasSize                            { get; set; }
        public int                                      MaxImageWidth                           { get; set; }
        public int                                      MaxImageHeight                          { get; set; }
        public int                                      VirtualWidth                            { get; set; }
        public int                                      VirtualHeight                           { get; set; }
        public int                                      PhysicalWidth                           { get; set; }
        public int                                      PhysicalHeight                          { get; set; }
        public AreaNode?                                M_FirstUnpartitionedArea                { get; set; }
        public List<Row>?                               M_OpenRows                              { get; set; }
        public int                                      M_1SidePadding                          { get; set; }
        public int                                      M_2SidePadding                          { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static UIRAtlasAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRAtlasAllocator() { Pointer= p0 };

            value.MaxAtlasSize                              = GetInt32(new IntPtr(p + 0x010)); // 0245A67A4108 0x10 MaxAtlasSize                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MaxImageWidth                             = GetInt32(new IntPtr(p + 0x014)); // 0245A67A4128 0x14 MaxImageWidth               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MaxImageHeight                            = GetInt32(new IntPtr(p + 0x018)); // 0245A67A4148 0x18 MaxImageHeight              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.VirtualWidth                              = GetInt32(new IntPtr(p + 0x01C)); // 0245A67A4168 0x1C VirtualWidth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VirtualHeight                             = GetInt32(new IntPtr(p + 0x020)); // 0245A67A4188 0x20 VirtualHeight               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhysicalWidth                             = GetInt32(new IntPtr(p + 0x024)); // 0245A67A41A8 0x24 PhysicalWidth               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhysicalHeight                            = GetInt32(new IntPtr(p + 0x028)); // 0245A67A41C8 0x28 PhysicalHeight              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FirstUnpartitionedArea                  = GetObject<AreaNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.AreaNode.FromPointer); // 0245A67A41E8 0x30 M_FirstUnpartitionedArea    ( 00018665FF30 ModelClassType AreaNode AreaNode AreaNode Pointer )
            value.M_OpenRows                                = GetObjectList<Row>(new IntPtr(p + 0x038), ReversePrism.DataModels.Row.FromPointer); // 0245A67A4208 0x38 M_OpenRows                  ( 000185CC4A38 ModelClassListType Row[] Row[] List<Row> Pointer )
            value.M_1SidePadding                            = GetInt32(new IntPtr(p + 0x040)); // 0245A67A4228 0x40 M_1SidePadding              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_2SidePadding                            = GetInt32(new IntPtr(p + 0x044)); // 0245A67A4248 0x44 M_2SidePadding              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x048)); // 0245A67A4288 0x48 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
