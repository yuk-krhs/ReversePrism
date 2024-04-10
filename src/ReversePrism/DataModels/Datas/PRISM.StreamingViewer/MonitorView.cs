using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 MeshRenderer                             000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 028 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 030 InitializedMonitor                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 MonitorTextureFilePath                   000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 MonitorTextures                          000185CAB058 ModelClassListType Texture[] Texture[] List<Texture> Pointer
    // 050 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MonitorView : DataModel
    {
        public MeshRenderer?                            MeshRenderer                            { get; set; }
        public bool                                     InitializedMonitor                      { get; set; }
        public List<string>?                            MonitorTextureFilePath                  { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public List<Texture>?                           MonitorTextures                         { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static MonitorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonitorView() { Pointer= p0 };

            value.MeshRenderer                              = GetObject<MeshRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshRenderer.FromPointer); // 024664FB9150 0x20 MeshRenderer                ( 000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.InitializedMonitor                        = GetBool(new IntPtr(p + 0x030)); // 024664FB9190 0x30 InitializedMonitor          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MonitorTextureFilePath                    = GetStringList(new IntPtr(p + 0x038)); // 024664FB91B0 0x38 MonitorTextureFilePath      ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x040)); // 024664FB91D0 0x40 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MonitorTextures                           = GetObjectList<Texture>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture.FromPointer); // 024664FB91F0 0x48 MonitorTextures             ( 000185CAB058 ModelClassListType Texture[] Texture[] List<Texture> Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x050)); // 024664FB9210 0x50 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
