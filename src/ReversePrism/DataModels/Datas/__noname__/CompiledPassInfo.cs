using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pass                                     000186654EC0 ModelClassType RenderGraphPass RenderGraphPass RenderGraphPass Pointer
    // 018 resourceCreateList                       List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 020 resourceReleaseList                      List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 028 RefCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Culled                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 02D CulledByRendererList                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 02E HasSideEffect                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 SyncToPassIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 SyncFromPassIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 NeedGraphicsFence                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 Fence                                    000186695660 ModelEnumType GraphicsFence GraphicsFence GraphicsFence Int32
    // 050 EnableAsyncCompute                       000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CompiledPassInfo : DataModel
    {
        public RenderGraphPass?                         Pass                                    { get; set; }
        public int                                      RefCount                                { get; set; }
        public bool                                     Culled                                  { get; set; }
        public bool                                     CulledByRendererList                    { get; set; }
        public bool                                     HasSideEffect                           { get; set; }
        public int                                      SyncToPassIndex                         { get; set; }
        public int                                      SyncFromPassIndex                       { get; set; }
        public bool                                     NeedGraphicsFence                       { get; set; }
        public GraphicsFence                            Fence                                   { get; set; }
        public bool                                     EnableAsyncCompute                      { get; set; }

        public static CompiledPassInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompiledPassInfo() { Pointer= p0 };

            value.Pass                                      = GetObject<RenderGraphPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraphPass.FromPointer); // 0246690D7880 0x10 Pass                        ( 000186654EC0 ModelClassType RenderGraphPass RenderGraphPass RenderGraphPass Pointer )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x028)); // 0246690D78E0 0x28 RefCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Culled                                    = GetBool(new IntPtr(p + 0x02C)); // 0246690D7900 0x2C Culled                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CulledByRendererList                      = GetBool(new IntPtr(p + 0x02D)); // 0246690D7920 0x2D CulledByRendererList        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HasSideEffect                             = GetBool(new IntPtr(p + 0x02E)); // 0246690D7940 0x2E HasSideEffect               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SyncToPassIndex                           = GetInt32(new IntPtr(p + 0x030)); // 0246690D7960 0x30 SyncToPassIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SyncFromPassIndex                         = GetInt32(new IntPtr(p + 0x034)); // 0246690D7980 0x34 SyncFromPassIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NeedGraphicsFence                         = GetBool(new IntPtr(p + 0x038)); // 0246690D79A0 0x38 NeedGraphicsFence           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Fence                                     = (GraphicsFence)GetInt32(new IntPtr(p + 0x040)); // 0246690D79C0 0x40 Fence                       ( 000186695660 ModelEnumType GraphicsFence GraphicsFence GraphicsFence Int32 )
            value.EnableAsyncCompute                        = GetBool(new IntPtr(p + 0x050)); // 0246690D79E0 0x50 EnableAsyncCompute          ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
