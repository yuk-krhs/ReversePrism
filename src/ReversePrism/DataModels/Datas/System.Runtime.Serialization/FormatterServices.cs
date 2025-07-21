using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_MemberInfoTable                        ConcurrentDictionary`2<MemberHolder, MemberInfo[]> IL2CPP_TYPE_GENERICINST
    // 008 unsafeTypeForwardersIsEnabled            bool IL2CPP_TYPE_BOOLEAN
    // 009 unsafeTypeForwardersIsEnabledInitialized bool IL2CPP_TYPE_BOOLEAN
    // 010 AdvancedTypes                            ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 S_binder                                 ModelClassType Binder Binder Binder Pointer
    public partial class FormatterServices : DataModel
    {
        public List<Type>?                              AdvancedTypes                           { get; set; }
        public Binder?                                  S_binder                                { get; set; }

        public static FormatterServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormatterServices() { Pointer= p0 };

            value.AdvancedTypes                             = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 AdvancedTypes               ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.S_binder                                  = GetObject<Binder>(new IntPtr(p + 0x018), ReversePrism.DataModels.Binder.FromPointer); // 0x18 S_binder                    ( ModelClassType Binder Binder Binder Pointer )

            return value;
        }
    }
}
