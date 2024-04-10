using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResetScenePath                           string IL2CPP_TYPE_STRING
    // 028 ViewReferences                           000185CB1B08 ModelClassListType ViewBundle[] ViewBundle[] List<ViewBundle> Pointer
    // 030 viewMapping                              Dictionary`2<string, ViewBundle> IL2CPP_TYPE_GENERICINST
    // 038 CurrentViewName                          000186671910 ModelPrimitiveType string string string String
    // 008 isInitialBoot                            bool IL2CPP_TYPE_BOOLEAN
    // 040 ParameterState                           000186704410 ModelEnumType ParameterState ParameterState ParameterState Int32
    // 048 Model3DScene                             000186671910 ModelPrimitiveType string string string String
    // 050 PrismMainPrefab                          000186671910 ModelPrimitiveType string string string String
    // 058 OverlayManagerCaller                     0001866FF170 ModelClassType OverlayManagerCaller OverlayManagerCaller OverlayManagerCaller Pointer
    public partial class BootMenuScene : DataModel
    {
        public List<ViewBundle>?                        ViewReferences                          { get; set; }
        public string                                   CurrentViewName                         { get; set; }
        public ParameterState                           ParameterState                          { get; set; }
        public string                                   Model3DScene                            { get; set; }
        public string                                   PrismMainPrefab                         { get; set; }
        public OverlayManagerCaller?                    OverlayManagerCaller                    { get; set; }

        public static BootMenuScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BootMenuScene() { Pointer= p0 };

            value.ViewReferences                            = GetObjectList<ViewBundle>(new IntPtr(p + 0x028), ReversePrism.DataModels.ViewBundle.FromPointer); // 0246609E1358 0x28 ViewReferences              ( 000185CB1B08 ModelClassListType ViewBundle[] ViewBundle[] List<ViewBundle> Pointer )
            value.CurrentViewName                           = GetString(new IntPtr(p + 0x038)); // 0246609E1398 0x38 CurrentViewName             ( 000186671910 ModelPrimitiveType string string string String )
            value.ParameterState                            = (ParameterState)GetInt32(new IntPtr(p + 0x040)); // 0246609E13D8 0x40 ParameterState              ( 000186704410 ModelEnumType ParameterState ParameterState ParameterState Int32 )
            value.Model3DScene                              = GetString(new IntPtr(p + 0x048)); // 0246609E13F8 0x48 Model3DScene                ( 000186671910 ModelPrimitiveType string string string String )
            value.PrismMainPrefab                           = GetString(new IntPtr(p + 0x050)); // 0246609E1418 0x50 PrismMainPrefab             ( 000186671910 ModelPrimitiveType string string string String )
            value.OverlayManagerCaller                      = GetObject<OverlayManagerCaller>(new IntPtr(p + 0x058), ReversePrism.DataModels.OverlayManagerCaller.FromPointer); // 0246609E1438 0x58 OverlayManagerCaller        ( 0001866FF170 ModelClassType OverlayManagerCaller OverlayManagerCaller OverlayManagerCaller Pointer )

            return value;
        }
    }
}
