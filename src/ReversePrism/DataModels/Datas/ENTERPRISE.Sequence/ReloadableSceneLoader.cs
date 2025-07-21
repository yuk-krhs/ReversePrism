using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 loaderFactory                            Func`1<ISceneLoader> IL2CPP_TYPE_GENERICINST
    // 018 CurrentLoader                            ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer
    // 020 ReloadingStep                            ModelEnumType ReloadingStepMode ReloadingStepMode ReloadingStepMode Int32
    public partial class ReloadableSceneLoader : DataModel
    {
        public ISceneLoader?                            CurrentLoader                           { get; set; }
        public ReloadingStepMode                        ReloadingStep                           { get; set; }

        public static ReloadableSceneLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReloadableSceneLoader() { Pointer= p0 };

            value.CurrentLoader                             = GetObject<ISceneLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISceneLoader.FromPointer); // 0x18 CurrentLoader               ( ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer )
            value.ReloadingStep                             = (ReloadingStepMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 ReloadingStep               ( ModelEnumType ReloadingStepMode ReloadingStepMode ReloadingStepMode Int32 )

            return value;
        }
    }
}
