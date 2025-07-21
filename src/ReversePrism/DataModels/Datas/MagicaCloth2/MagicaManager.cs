using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 managers                                 List`1<IManager> IL2CPP_TYPE_GENERICINST
    // 008 afterEarlyUpdateDelegate                 UpdateMethod IL2CPP_TYPE_CLASS
    // 010 AfterFixedUpdateDelegate                 ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 018 AfterUpdateDelegate                      ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 020 BeforeLateUpdateDelegate                 ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 028 AfterLateUpdateDelegate                  ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 030 AfterDelayedDelegate                     ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 038 AfterRenderingDelegate                   ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 040 DefaultUpdateDelegate                    ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer
    // 048 IsPlaying                                ModelPrimitiveType bool bool bool Bool
    // 050 OnPreSimulation                          ModelClassType Action Action Action Pointer
    // 058 OnPostSimulation                         ModelClassType Action Action Action Pointer
    // 060 InitializationLocation                   ModelEnumType InitializationLocation InitializationLocation InitializationLocation Int32
    public partial class MagicaManager : DataModel
    {
        public UpdateMethod?                            AfterFixedUpdateDelegate                { get; set; }
        public UpdateMethod?                            AfterUpdateDelegate                     { get; set; }
        public UpdateMethod?                            BeforeLateUpdateDelegate                { get; set; }
        public UpdateMethod?                            AfterLateUpdateDelegate                 { get; set; }
        public UpdateMethod?                            AfterDelayedDelegate                    { get; set; }
        public UpdateMethod?                            AfterRenderingDelegate                  { get; set; }
        public UpdateMethod?                            DefaultUpdateDelegate                   { get; set; }
        public bool                                     IsPlaying                               { get; set; }
        public Action?                                  OnPreSimulation                         { get; set; }
        public Action?                                  OnPostSimulation                        { get; set; }
        public InitializationLocation                   InitializationLocation                  { get; set; }

        public static MagicaManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaManager() { Pointer= p0 };

            value.AfterFixedUpdateDelegate                  = GetObject<UpdateMethod>(new IntPtr(p + 0x010), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x10 AfterFixedUpdateDelegate    ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.AfterUpdateDelegate                       = GetObject<UpdateMethod>(new IntPtr(p + 0x018), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x18 AfterUpdateDelegate         ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.BeforeLateUpdateDelegate                  = GetObject<UpdateMethod>(new IntPtr(p + 0x020), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x20 BeforeLateUpdateDelegate    ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.AfterLateUpdateDelegate                   = GetObject<UpdateMethod>(new IntPtr(p + 0x028), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x28 AfterLateUpdateDelegate     ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.AfterDelayedDelegate                      = GetObject<UpdateMethod>(new IntPtr(p + 0x030), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x30 AfterDelayedDelegate        ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.AfterRenderingDelegate                    = GetObject<UpdateMethod>(new IntPtr(p + 0x038), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x38 AfterRenderingDelegate      ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.DefaultUpdateDelegate                     = GetObject<UpdateMethod>(new IntPtr(p + 0x040), ReversePrism.DataModels.UpdateMethod.FromPointer); // 0x40 DefaultUpdateDelegate       ( ModelClassType UpdateMethod UpdateMethod UpdateMethod Pointer )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x048)); // 0x48 IsPlaying                   ( ModelPrimitiveType bool bool bool Bool )
            value.OnPreSimulation                           = GetObject<Action>(new IntPtr(p + 0x050), ReversePrism.DataModels.Action.FromPointer); // 0x50 OnPreSimulation             ( ModelClassType Action Action Action Pointer )
            value.OnPostSimulation                          = GetObject<Action>(new IntPtr(p + 0x058), ReversePrism.DataModels.Action.FromPointer); // 0x58 OnPostSimulation            ( ModelClassType Action Action Action Pointer )
            value.InitializationLocation                    = (InitializationLocation)GetInt32(new IntPtr(p + 0x060)); // 0x60 InitializationLocation      ( ModelEnumType InitializationLocation InitializationLocation InitializationLocation Int32 )

            return value;
        }
    }
}
